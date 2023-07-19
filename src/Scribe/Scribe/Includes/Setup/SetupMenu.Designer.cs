namespace Scribe.Setup
{
    partial class SetupMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupMenu));
            this.DeviceCpuRadioButton = new System.Windows.Forms.RadioButton();
            this.DeviceGpuRadioButton = new System.Windows.Forms.RadioButton();
            this.DeviceLabel = new System.Windows.Forms.Label();
            this.DeviceCudaCombobox = new System.Windows.Forms.ComboBox();
            this.InstallButton = new System.Windows.Forms.Button();
            this.DeviceCudaLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeviceCpuRadioButton
            // 
            this.DeviceCpuRadioButton.AutoSize = true;
            this.DeviceCpuRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceCpuRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.DeviceCpuRadioButton.Location = new System.Drawing.Point(10, 25);
            this.DeviceCpuRadioButton.Name = "DeviceCpuRadioButton";
            this.DeviceCpuRadioButton.Size = new System.Drawing.Size(53, 20);
            this.DeviceCpuRadioButton.TabIndex = 1;
            this.DeviceCpuRadioButton.TabStop = true;
            this.DeviceCpuRadioButton.Text = "CPU";
            this.DeviceCpuRadioButton.UseVisualStyleBackColor = true;
            this.DeviceCpuRadioButton.CheckedChanged += new System.EventHandler(this.DeviceCpuRadioButton_CheckedChanged);
            // 
            // DeviceGpuRadioButton
            // 
            this.DeviceGpuRadioButton.AutoSize = true;
            this.DeviceGpuRadioButton.Checked = true;
            this.DeviceGpuRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceGpuRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.DeviceGpuRadioButton.Location = new System.Drawing.Point(10, 42);
            this.DeviceGpuRadioButton.Name = "DeviceGpuRadioButton";
            this.DeviceGpuRadioButton.Size = new System.Drawing.Size(103, 20);
            this.DeviceGpuRadioButton.TabIndex = 2;
            this.DeviceGpuRadioButton.TabStop = true;
            this.DeviceGpuRadioButton.Text = "GPU (CUDA)";
            this.DeviceGpuRadioButton.UseVisualStyleBackColor = true;
            this.DeviceGpuRadioButton.CheckedChanged += new System.EventHandler(this.DeviceGpuRadioButton_CheckedChanged);
            // 
            // DeviceLabel
            // 
            this.DeviceLabel.AutoSize = true;
            this.DeviceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.DeviceLabel.Location = new System.Drawing.Point(7, 7);
            this.DeviceLabel.Name = "DeviceLabel";
            this.DeviceLabel.Size = new System.Drawing.Size(109, 18);
            this.DeviceLabel.TabIndex = 0;
            this.DeviceLabel.Text = "Device Options";
            this.DeviceLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DeviceLabel_MouseDown);
            // 
            // DeviceCudaCombobox
            // 
            this.DeviceCudaCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DeviceCudaCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceCudaCombobox.ForeColor = System.Drawing.Color.Gainsboro;
            this.DeviceCudaCombobox.FormattingEnabled = true;
            this.DeviceCudaCombobox.Items.AddRange(new object[] {
            "CUDA 11.8",
            "CUDA 11.7"});
            this.DeviceCudaCombobox.Location = new System.Drawing.Point(30, 63);
            this.DeviceCudaCombobox.Name = "DeviceCudaCombobox";
            this.DeviceCudaCombobox.Size = new System.Drawing.Size(90, 24);
            this.DeviceCudaCombobox.TabIndex = 3;
            this.DeviceCudaCombobox.Text = "CUDA 11.8";
            // 
            // InstallButton
            // 
            this.InstallButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(135)))), ((int)(((byte)(120)))));
            this.InstallButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(180)))), ((int)(((byte)(165)))));
            this.InstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallButton.ForeColor = System.Drawing.Color.Honeydew;
            this.InstallButton.Location = new System.Drawing.Point(11, 107);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(96, 37);
            this.InstallButton.TabIndex = 5;
            this.InstallButton.Text = "Install";
            this.InstallButton.UseVisualStyleBackColor = false;
            this.InstallButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // DeviceCudaLinkLabel
            // 
            this.DeviceCudaLinkLabel.AutoSize = true;
            this.DeviceCudaLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.DeviceCudaLinkLabel.Location = new System.Drawing.Point(26, 87);
            this.DeviceCudaLinkLabel.Name = "DeviceCudaLinkLabel";
            this.DeviceCudaLinkLabel.Size = new System.Drawing.Size(168, 13);
            this.DeviceCudaLinkLabel.TabIndex = 4;
            this.DeviceCudaLinkLabel.TabStop = true;
            this.DeviceCudaLinkLabel.Text = "How can I find my CUDA version?";
            this.DeviceCudaLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.DeviceCudaLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeviceCudaLinkLabel_LinkClicked);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.CloseButton.Location = new System.Drawing.Point(179, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(24, 24);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SetupMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(203, 157);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DeviceCudaLinkLabel);
            this.Controls.Add(this.InstallButton);
            this.Controls.Add(this.DeviceCudaCombobox);
            this.Controls.Add(this.DeviceLabel);
            this.Controls.Add(this.DeviceGpuRadioButton);
            this.Controls.Add(this.DeviceCpuRadioButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetupMenu";
            this.Text = "Scribe Setup";
            this.Load += new System.EventHandler(this.SetupMenu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SetupMenu_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton DeviceCpuRadioButton;
        private System.Windows.Forms.RadioButton DeviceGpuRadioButton;
        private System.Windows.Forms.Label DeviceLabel;
        private System.Windows.Forms.ComboBox DeviceCudaCombobox;
        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.LinkLabel DeviceCudaLinkLabel;
        private System.Windows.Forms.Button CloseButton;
    }
}