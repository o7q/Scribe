using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

using static Scribe.Global;
using static Scribe.Tools.Files;
using static Scribe.Tools.Strings;

namespace Scribe.Setup
{
    public static class Installer
    {
        public static void InstallPythonPackages(string device)
        {
            try
            {
                Directory.Delete("Scribe\\engine\\python", true);
            }
            catch { }
            Directory.CreateDirectory("Scribe\\engine\\python");

            bool isGpu = false;

            string torchScript = "";
            switch (device)
            {
                case "cuda117":
                    torchScript = "pip install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu117";
                    isGpu = true;
                    break;
                case "cuda118":
                    torchScript = "pip install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118";
                    isGpu = true;
                    break;
                case "cpu":
                    torchScript = "pip install torch torchvision torchaudio";
                    break;
            }

            string command = "/c title Scribe Python Setup - Configuring: engine/python   [1/6] & " +
                             "echo Please Wait... & " +
                             "py -m venv Scribe\\engine\\python & " +
                             "Scribe\\engine\\python\\Scripts\\activate & " +

                             "title Scribe Python Setup - Installing: engine/python/pip   [2/6] & " +
                             "py -m pip install --upgrade pip & " +

                             "title Scribe Python Setup - Installing: engine/python/stable-ts   [3/6] & " +
                             "pip install -U stable-ts & " +

                             "title Scribe Python Setup - Patching: engine/python/torch   [4/6] & " +
                             torchScript + " & " +

                             "title Scribe Python Setup - Patching: engine/python/numpy   [5/6] & " +
                             "pip install \"numpy<2\" & " +

                             "title Scribe Python Setup - Purging pip cache   [6/6] & " +
                             "pip cache purge & " +

                             "title Done!";
            Process.Start("cmd.exe", command).WaitForExit();

            File.WriteAllText("Scribe\\engine\\python\\.scribe_version", VERSION);

            if (isGpu)
            {
                File.WriteAllText("Scribe\\engine\\python\\.scribe_is_gpu", "# This file tells Scribe if a GPU install was performed or not.");
            }
        }

        public static void InstallFFmpeg()
        {
            try
            {
                Directory.Delete("Scribe\\engine\\_temp", true);
            }
            catch { }
            Directory.CreateDirectory("Scribe\\engine\\_temp");
            try
            {
                Directory.Delete("Scribe\\engine\\ffmpeg", true);
            }
            catch { }

            DownloadFile("https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-essentials.zip", "Scribe\\engine\\_temp\\ffmpeg.zip");

            ZipFile.ExtractToDirectory("Scribe\\engine\\_temp\\ffmpeg.zip", "Scribe\\engine\\_temp");
            File.Delete("Scribe\\engine\\_temp\\ffmpeg.zip");

            string[] ffmpegRedistPaths = Directory.GetDirectories("Scribe\\engine\\_temp");
            Directory.Move(ffmpegRedistPaths[0], "Scribe\\engine\\ffmpeg");
        }

        public static void ConfigureFFmpegPath()
        {
            DialogResult prompt = MessageBox.Show("FFmpeg needs to be set in the PATH environment variable, do you want Scribe to set it automatically?", "", MessageBoxButtons.YesNo);
            if (prompt == DialogResult.No)
            {
                Environment.Exit(0);
            }

            string ffmpegValue = Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location) + "\\Scribe\\engine\\ffmpeg\\bin";
            if (StringContainsSubstring(Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User) ?? "", ffmpegValue, false) == 0)
            {
                var oldValues = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);
                var newValues = oldValues + ffmpegValue + ";";
                Environment.SetEnvironmentVariable("PATH", newValues, EnvironmentVariableTarget.User);
            }
        }

        public static bool IsPyEnvConfigured()
        {
            bool pyEnvIsConfigured = true;

            if (File.Exists("Scribe\\engine\\python\\.scribe_version") && File.Exists("Scribe\\engine\\python\\Scripts\\stable-ts.exe"))
            {
                if (File.ReadAllText("Scribe\\engine\\python\\.scribe_version") != VERSION)
                {
                    pyEnvIsConfigured = false;
                }
            }
            else
            {
                pyEnvIsConfigured = false;
            }

            return pyEnvIsConfigured;
        }
    }
}