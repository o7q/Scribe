using System.Drawing;
using System.Windows.Forms;

namespace Scribe.Setup
{
    partial class PyEnvSetupMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PyEnvSetupMenu));
            DeviceOptionsLabel = new Label();
            DeviceCpuRadioButton = new RadioButton();
            DeviceCudaLinkLabel = new LinkLabel();
            DeviceCudaCombobox = new ComboBox();
            InstallButton = new Button();
            CloseButton = new Button();
            DeviceGpuRadioButton = new RadioButton();
            SuspendLayout();
            // 
            // DeviceOptionsLabel
            // 
            DeviceOptionsLabel.AutoSize = true;
            DeviceOptionsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeviceOptionsLabel.ForeColor = Color.FromArgb(220, 230, 240);
            DeviceOptionsLabel.Location = new Point(5, 7);
            DeviceOptionsLabel.Name = "DeviceOptionsLabel";
            DeviceOptionsLabel.Size = new Size(96, 17);
            DeviceOptionsLabel.TabIndex = 0;
            DeviceOptionsLabel.Text = "Device Options";
            // 
            // DeviceCpuRadioButton
            // 
            DeviceCpuRadioButton.AutoSize = true;
            DeviceCpuRadioButton.ForeColor = Color.FromArgb(220, 230, 240);
            DeviceCpuRadioButton.Location = new Point(7, 24);
            DeviceCpuRadioButton.Name = "DeviceCpuRadioButton";
            DeviceCpuRadioButton.Size = new Size(48, 19);
            DeviceCpuRadioButton.TabIndex = 0;
            DeviceCpuRadioButton.Text = "CPU";
            DeviceCpuRadioButton.UseVisualStyleBackColor = true;
            DeviceCpuRadioButton.CheckedChanged += DeviceCpuRadioButton_CheckedChanged;
            // 
            // DeviceCudaLinkLabel
            // 
            DeviceCudaLinkLabel.AutoSize = true;
            DeviceCudaLinkLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeviceCudaLinkLabel.LinkColor = Color.FromArgb(100, 100, 255);
            DeviceCudaLinkLabel.Location = new Point(22, 83);
            DeviceCudaLinkLabel.Name = "DeviceCudaLinkLabel";
            DeviceCudaLinkLabel.Size = new Size(177, 13);
            DeviceCudaLinkLabel.TabIndex = 3;
            DeviceCudaLinkLabel.TabStop = true;
            DeviceCudaLinkLabel.Text = "How can I find my CUDA version?";
            DeviceCudaLinkLabel.VisitedLinkColor = Color.FromArgb(128, 0, 255);
            DeviceCudaLinkLabel.LinkClicked += DeviceCudaLinkLabel_LinkClicked;
            // 
            // DeviceCudaCombobox
            // 
            DeviceCudaCombobox.BackColor = Color.FromArgb(30, 32, 34);
            DeviceCudaCombobox.FlatStyle = FlatStyle.Flat;
            DeviceCudaCombobox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeviceCudaCombobox.ForeColor = Color.FromArgb(220, 230, 240);
            DeviceCudaCombobox.FormattingEnabled = true;
            DeviceCudaCombobox.Items.AddRange(new object[] { "CUDA 11.8", "CUDA 11.7" });
            DeviceCudaCombobox.Location = new Point(26, 60);
            DeviceCudaCombobox.Name = "DeviceCudaCombobox";
            DeviceCudaCombobox.Size = new Size(83, 21);
            DeviceCudaCombobox.TabIndex = 2;
            DeviceCudaCombobox.Text = "CUDA 11.8";
            // 
            // InstallButton
            // 
            InstallButton.BackColor = Color.FromArgb(130, 150, 130);
            InstallButton.FlatAppearance.BorderColor = Color.FromArgb(165, 180, 165);
            InstallButton.FlatStyle = FlatStyle.Flat;
            InstallButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InstallButton.ForeColor = Color.Honeydew;
            InstallButton.Location = new Point(5, 101);
            InstallButton.Name = "InstallButton";
            InstallButton.Size = new Size(60, 26);
            InstallButton.TabIndex = 4;
            InstallButton.Text = "Install";
            InstallButton.UseVisualStyleBackColor = false;
            InstallButton.Click += InstallButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(150, 130, 130);
            CloseButton.FlatAppearance.BorderColor = Color.FromArgb(180, 165, 165);
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CloseButton.ForeColor = Color.FromArgb(255, 240, 240);
            CloseButton.Location = new Point(65, 101);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(68, 26);
            CloseButton.TabIndex = 5;
            CloseButton.Text = "Cancel";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // DeviceGpuRadioButton
            // 
            DeviceGpuRadioButton.AutoSize = true;
            DeviceGpuRadioButton.Checked = true;
            DeviceGpuRadioButton.ForeColor = Color.FromArgb(220, 230, 240);
            DeviceGpuRadioButton.Location = new Point(7, 41);
            DeviceGpuRadioButton.Name = "DeviceGpuRadioButton";
            DeviceGpuRadioButton.Size = new Size(91, 19);
            DeviceGpuRadioButton.TabIndex = 1;
            DeviceGpuRadioButton.TabStop = true;
            DeviceGpuRadioButton.Text = "GPU (CUDA)";
            DeviceGpuRadioButton.UseVisualStyleBackColor = true;
            DeviceGpuRadioButton.CheckedChanged += DeviceGpuRadioButton_CheckedChanged;
            // 
            // PyEnvSetupMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 22, 24);
            ClientSize = new Size(203, 134);
            Controls.Add(DeviceGpuRadioButton);
            Controls.Add(CloseButton);
            Controls.Add(InstallButton);
            Controls.Add(DeviceCudaCombobox);
            Controls.Add(DeviceCudaLinkLabel);
            Controls.Add(DeviceCpuRadioButton);
            Controls.Add(DeviceOptionsLabel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "PyEnvSetupMenu";
            Text = "Scribe Setup";
            Load += SetupMenu_Load;
            MouseDown += SetupMenu_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DeviceOptionsLabel;
        private RadioButton DeviceCpuRadioButton;
        private LinkLabel DeviceCudaLinkLabel;
        private ComboBox DeviceCudaCombobox;
        private Button InstallButton;
        private Button CloseButton;
        private RadioButton DeviceGpuRadioButton;
    }
}