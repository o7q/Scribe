using System;
using System.IO;
using Scribe.Setup;
using System.Diagnostics;
using System.Windows.Forms;
using static Scribe.Tools.Strings;

namespace Scribe
{
    internal static class Init
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // prevent multiple openings
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
                return;

            // check for python
            ProcessStartInfo pythonCheck = new ProcessStartInfo();
            pythonCheck.FileName = "python.exe";
            pythonCheck.Arguments = "--version";
            pythonCheck.UseShellExecute = false;
            pythonCheck.RedirectStandardOutput = true;
            pythonCheck.CreateNoWindow = true;
            using (Process process = Process.Start(pythonCheck))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    var pythonSearch = StringContainsSubstring(result, "Python", true);

                    if (pythonSearch.Item1)
                    {
                        Application.Run(new SetupMenu());
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
    }
}