using System;
using System.IO;
using Scribe.Setup;
using System.Windows.Forms;
using System.Diagnostics;

using static Scribe.Tools.Files;
using static Scribe.Setup.Installer;

namespace Scribe
{
    internal static class Init
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // prevent multiple openings
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                return;
            }

            // check for python
            if (DoesFileExistInPath("python.exe"))
            {
                if (!File.Exists("Scribe\\engine\\ffmpeg\\bin\\ffmpeg.exe"))
                {
                    DialogResult prompt = MessageBox.Show("FFmpeg is going to be downloaded. Do you want to continue?", "", MessageBoxButtons.YesNo);
                    if (prompt == DialogResult.No)
                    {
                        Environment.Exit(0);
                    }
                    InstallFFmpeg();
                }

                if (!DoesFileExistInPath("ffmpeg.exe"))
                {
                    ConfigureFFmpegPath();
                }

                if (!IsPyEnvConfigured())
                {
                    Application.Run(new PyEnvSetupMenu());
                    if (!IsPyEnvConfigured())
                    {
                        MessageBox.Show("Scribe Python Packages were not installed correctly! Please re-run the setup wizard.");
                        Environment.Exit(0);
                    }
                }

                Application.Run(new MainMenu());
            }
            else
            {
                MessageBox.Show("Python was not found on your system!\nPlease install it from https://www.python.org");
                return;
            }
        }
    }
}