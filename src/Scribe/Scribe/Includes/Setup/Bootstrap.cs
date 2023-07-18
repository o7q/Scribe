using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Diagnostics;
using System.IO.Compression;
using static Scribe.Tools.Strings;

namespace Scribe.Setup
{
    public static class Installer
    {
        public static void InstallEngine(string device, bool installBase, bool installFFmpeg)
        {
            if (installBase)
                InstallBase(device);

            if (installFFmpeg)
                InstallFFmpeg();
        }

        private static void InstallBase(string device)
        {
            try
            {
                Directory.Delete("Scribe\\engine\\base", true);
            }
            catch { }
            Directory.CreateDirectory("Scribe\\engine\\base");

            string torchScript = "";
            switch (device)
            {
                case "cuda117":
                    torchScript = "pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu117";
                    break;
                case "cuda118":
                    torchScript = "pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118";
                    break;
                case "cpu":
                    torchScript = "pip3 install torch torchvision torchaudio";
                    break;
            }

            string command = "/c title Scribe Setup - Configuring: engine/base   [1/5] & " +
                             "echo Please Wait... & " +
                             "py -m venv Scribe\\engine\\base & " +
                             "Scribe\\engine\\base\\Scripts\\activate & " +
                             "title Scribe Setup - Updating: engine/base/pip   [2/5] & " +
                             "py -m pip install --upgrade pip & " +
                             "title Scribe Setup - Updating: engine/base/whisper   [3/5] & " +
                             "pip3 install -U openai-whisper & " +
                             "title Scribe Setup - Cleaning: engine/base/torch   [4/5] & " +
                             "pip3 uninstall -y torch && pip cache purge & " +
                             "title Scribe Setup - Updating: engine/base/torch   [5/5] & " +
                             torchScript + " & " +
                             "title Done!";
            Process.Start("cmd.exe", command).WaitForExit();
        }

        private static void InstallFFmpeg()
        {
            try
            {
                Directory.Delete("Scribe\\engine\\redist\\ffmpeg", true);
            } catch { }
            Directory.CreateDirectory("Scribe\\engine\\redist\\ffmpeg");

            using (var client = new WebClient())
                client.DownloadFile("https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-essentials.zip", "Scribe\\engine\\redist\\ffmpeg\\ffmpeg.zip");

            ZipFile.ExtractToDirectory("Scribe\\engine\\redist\\ffmpeg\\ffmpeg.zip", "Scribe\\engine\\redist\\ffmpeg");

            string[] ffmpegRedistPaths = Directory.GetDirectories("Scribe\\engine\\redist\\ffmpeg");
            Directory.Move(ffmpegRedistPaths[0], "Scribe\\engine\\redist\\ffmpeg\\ffmpeg");

            ConfigureFFmpegPath();
        }

        public static void ConfigureFFmpegPath()
        {
            string ffmpegValue = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Scribe\\engine\\redist\\ffmpeg\\ffmpeg\\bin";
            if (!StringContainsSubstring(Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User), ffmpegValue, false).Item1)
            {
                var oldValues = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);
                var newValues = oldValues + ffmpegValue + ";";
                Environment.SetEnvironmentVariable("PATH", newValues, EnvironmentVariableTarget.User);
            }
        }
    }
}