using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using static Scribe.Tools.Forms;
using static Scribe.Setup.Installer;

namespace Scribe.Setup
{
    public partial class SetupMenu : Form
    {
        public SetupMenu()
        {
            InitializeComponent();
        }

        private void SetupMenu_Load(object sender, EventArgs e)
        {
            int engineState = 0;

            if (File.Exists("Scribe\\engine\\base\\Scripts\\whisper.exe"))
                engineState++;

            if (File.Exists("Scribe\\engine\\redist\\ffmpeg\\ffmpeg\\bin\\ffmpeg.exe"))
                engineState++;

            if (engineState == 2)
                Close();
        }

        private void DeviceCpuRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DeviceCpuRadioButton.Checked)
                DeviceCudaCombobox.Enabled = false;
        }

        private void DeviceGpuRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DeviceGpuRadioButton.Checked)
                DeviceCudaCombobox.Enabled = true;
        }

        private void DeviceCudaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://stackoverflow.com/a/55717476");
        }

        bool enableInstall = true;
        private void InstallButton_Click(object sender, EventArgs e)
        {
            if (!enableInstall)
                return;

            InstallButton.Text = "Installing...";

            enableInstall = false;

            string device = "";
            if (DeviceCpuRadioButton.Checked)
                device = "cpu";
            if (DeviceGpuRadioButton.Checked)
            {
                switch (DeviceCudaCombobox.Text)
                {
                    case "CUDA 11.8":
                        device = "cuda118";
                        break;
                    case "CUDA 11.7":
                        device = "cuda117";
                        break;
                }
            }

            bool baseExists = File.Exists("Scribe\\engine\\base\\Scripts\\whisper.exe");
            bool ffmpegExists = File.Exists("Scribe\\engine\\redist\\ffmpeg\\ffmpeg\\bin\\ffmpeg.exe");
            InstallEngine(device, !baseExists, !ffmpegExists);

            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SetupMenu_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(Handle, e);
        }

        private void DeviceLabel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(Handle, e);
        }
    }
}