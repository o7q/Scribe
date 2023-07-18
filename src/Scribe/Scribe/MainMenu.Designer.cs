namespace Scribe
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchPhraseTextBox = new System.Windows.Forms.TextBox();
            this.SelectedFileTextBox = new System.Windows.Forms.RichTextBox();
            this.SearchCurrentCountLabel = new System.Windows.Forms.Label();
            this.ProcessProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProcessProgressLabel = new System.Windows.Forms.Label();
            this.ProcessAbortButton = new System.Windows.Forms.Button();
            this.TitlebarPanel = new System.Windows.Forms.Panel();
            this.TitlebarLabel = new System.Windows.Forms.Label();
            this.TitlebarPictureBox = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SelectionListBox = new System.Windows.Forms.ListBox();
            this.SearchFilesListBox = new System.Windows.Forms.ListBox();
            this.SearchTotalCountLabel = new System.Windows.Forms.Label();
            this.ResultsOpenMediaButton = new System.Windows.Forms.Button();
            this.ProcessEnableAutoUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.ProcessEnableCudaCheckBox = new System.Windows.Forms.CheckBox();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.SearchFileTextBox = new System.Windows.Forms.TextBox();
            this.SearchEnableAutoUpdateSearchCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchFileLabel = new System.Windows.Forms.Label();
            this.SearchPhraseLabel = new System.Windows.Forms.Label();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchEnableCaseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.SelectionPanel = new System.Windows.Forms.Panel();
            this.SelectionEnableSubdirectoriesCheckBox = new System.Windows.Forms.CheckBox();
            this.SelectionFileTypeTextBox = new System.Windows.Forms.TextBox();
            this.SelectionRemoveFolderButton = new System.Windows.Forms.Button();
            this.SelectionAddFolderButton = new System.Windows.Forms.Button();
            this.ProcessPanel = new System.Windows.Forms.Panel();
            this.ProcessEnableStartWithWindowsCheckBox = new System.Windows.Forms.CheckBox();
            this.ProcessUpdateButton = new System.Windows.Forms.Button();
            this.ProcessEnableOutputPauseCheckBox = new System.Windows.Forms.CheckBox();
            this.ProcessEnableOutputCheckBox = new System.Windows.Forms.CheckBox();
            this.ProcessModelLabel = new System.Windows.Forms.Label();
            this.ProcessModelComboBox = new System.Windows.Forms.ComboBox();
            this.ProcessCleanStorageButton = new System.Windows.Forms.Button();
            this.MainMenuContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AbortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ResultsPanel = new System.Windows.Forms.Panel();
            this.ResultsBrowseMediaButton = new System.Windows.Forms.Button();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchFilesCountLabel = new System.Windows.Forms.Label();
            this.TitlebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlebarPictureBox)).BeginInit();
            this.SearchPanel.SuspendLayout();
            this.SelectionPanel.SuspendLayout();
            this.ProcessPanel.SuspendLayout();
            this.MainMenuContextMenuStrip.SuspendLayout();
            this.ResultsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(135)))), ((int)(((byte)(120)))));
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(180)))), ((int)(((byte)(165)))));
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.Honeydew;
            this.SearchButton.Location = new System.Drawing.Point(6, 33);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(143, 29);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchPhraseTextBox
            // 
            this.SearchPhraseTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.SearchPhraseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPhraseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPhraseTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.SearchPhraseTextBox.Location = new System.Drawing.Point(6, 13);
            this.SearchPhraseTextBox.Name = "SearchPhraseTextBox";
            this.SearchPhraseTextBox.Size = new System.Drawing.Size(143, 20);
            this.SearchPhraseTextBox.TabIndex = 0;
            this.SearchPhraseTextBox.TextChanged += new System.EventHandler(this.SearchPhraseTextBox_TextChanged);
            // 
            // SelectedFileTextBox
            // 
            this.SelectedFileTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.SelectedFileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectedFileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFileTextBox.ForeColor = System.Drawing.Color.White;
            this.SelectedFileTextBox.Location = new System.Drawing.Point(610, 45);
            this.SelectedFileTextBox.Name = "SelectedFileTextBox";
            this.SelectedFileTextBox.ReadOnly = true;
            this.SelectedFileTextBox.Size = new System.Drawing.Size(590, 550);
            this.SelectedFileTextBox.TabIndex = 2;
            this.SelectedFileTextBox.Text = "";
            // 
            // SearchCurrentCountLabel
            // 
            this.SearchCurrentCountLabel.AutoSize = true;
            this.SearchCurrentCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCurrentCountLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.SearchCurrentCountLabel.Location = new System.Drawing.Point(0, 1);
            this.SearchCurrentCountLabel.Name = "SearchCurrentCountLabel";
            this.SearchCurrentCountLabel.Size = new System.Drawing.Size(63, 13);
            this.SearchCurrentCountLabel.TabIndex = 0;
            this.SearchCurrentCountLabel.Text = "Current: 0";
            // 
            // ProcessProgressBar
            // 
            this.ProcessProgressBar.Location = new System.Drawing.Point(4, 80);
            this.ProcessProgressBar.Maximum = 1;
            this.ProcessProgressBar.Name = "ProcessProgressBar";
            this.ProcessProgressBar.Size = new System.Drawing.Size(210, 20);
            this.ProcessProgressBar.TabIndex = 0;
            // 
            // ProcessProgressLabel
            // 
            this.ProcessProgressLabel.AutoSize = true;
            this.ProcessProgressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.ProcessProgressLabel.Location = new System.Drawing.Point(0, 100);
            this.ProcessProgressLabel.Name = "ProcessProgressLabel";
            this.ProcessProgressLabel.Size = new System.Drawing.Size(129, 13);
            this.ProcessProgressLabel.TabIndex = 0;
            this.ProcessProgressLabel.Text = "[0/0  |  0.00%  |  00:00:00]";
            // 
            // ProcessAbortButton
            // 
            this.ProcessAbortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.ProcessAbortButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(230)))));
            this.ProcessAbortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessAbortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessAbortButton.ForeColor = System.Drawing.Color.Ivory;
            this.ProcessAbortButton.Location = new System.Drawing.Point(214, 80);
            this.ProcessAbortButton.Name = "ProcessAbortButton";
            this.ProcessAbortButton.Size = new System.Drawing.Size(40, 20);
            this.ProcessAbortButton.TabIndex = 7;
            this.ProcessAbortButton.Text = "Abort";
            this.ProcessAbortButton.UseVisualStyleBackColor = false;
            this.ProcessAbortButton.Click += new System.EventHandler(this.ProcessAbortButton_Click);
            // 
            // TitlebarPanel
            // 
            this.TitlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TitlebarPanel.Controls.Add(this.TitlebarLabel);
            this.TitlebarPanel.Controls.Add(this.TitlebarPictureBox);
            this.TitlebarPanel.Controls.Add(this.MinimizeButton);
            this.TitlebarPanel.Controls.Add(this.CloseButton);
            this.TitlebarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitlebarPanel.Name = "TitlebarPanel";
            this.TitlebarPanel.Size = new System.Drawing.Size(1200, 28);
            this.TitlebarPanel.TabIndex = 0;
            this.TitlebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlebarPanel_MouseDown);
            // 
            // TitlebarLabel
            // 
            this.TitlebarLabel.AutoSize = true;
            this.TitlebarLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TitlebarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitlebarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TitlebarLabel.Location = new System.Drawing.Point(27, 8);
            this.TitlebarLabel.Name = "TitlebarLabel";
            this.TitlebarLabel.Size = new System.Drawing.Size(83, 13);
            this.TitlebarLabel.TabIndex = 0;
            this.TitlebarLabel.Text = "Scribe v0.0.0";
            this.TitlebarLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VersionLabel_MouseDown);
            // 
            // TitlebarPictureBox
            // 
            this.TitlebarPictureBox.Image = global::Scribe.Properties.Resources.logo;
            this.TitlebarPictureBox.Location = new System.Drawing.Point(3, 3);
            this.TitlebarPictureBox.Name = "TitlebarPictureBox";
            this.TitlebarPictureBox.Size = new System.Drawing.Size(22, 22);
            this.TitlebarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitlebarPictureBox.TabIndex = 0;
            this.TitlebarPictureBox.TabStop = false;
            this.TitlebarPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlebarPictureBox_MouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MinimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.MinimizeButton.Location = new System.Drawing.Point(1144, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(28, 28);
            this.MinimizeButton.TabIndex = 0;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.CloseButton.Location = new System.Drawing.Point(1172, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 28);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "❌";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SelectionListBox
            // 
            this.SelectionListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.SelectionListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectionListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SelectionListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionListBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.SelectionListBox.FormattingEnabled = true;
            this.SelectionListBox.ItemHeight = 18;
            this.SelectionListBox.Location = new System.Drawing.Point(0, 64);
            this.SelectionListBox.Name = "SelectionListBox";
            this.SelectionListBox.Size = new System.Drawing.Size(300, 414);
            this.SelectionListBox.TabIndex = 0;
            this.SelectionListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.SelectionListBox_DrawItem);
            this.SelectionListBox.SelectedIndexChanged += new System.EventHandler(this.SelectionListBox_SelectedIndexChanged);
            // 
            // SearchFilesListBox
            // 
            this.SearchFilesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.SearchFilesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchFilesListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SearchFilesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFilesListBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.SearchFilesListBox.FormattingEnabled = true;
            this.SearchFilesListBox.ItemHeight = 18;
            this.SearchFilesListBox.Location = new System.Drawing.Point(305, 109);
            this.SearchFilesListBox.Name = "SearchFilesListBox";
            this.SearchFilesListBox.Size = new System.Drawing.Size(300, 450);
            this.SearchFilesListBox.TabIndex = 1;
            this.SearchFilesListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.SearchFilesListBox_DrawItem);
            this.SearchFilesListBox.SelectedIndexChanged += new System.EventHandler(this.SearchFilesListBox_SelectedIndexChanged);
            // 
            // SearchTotalCountLabel
            // 
            this.SearchTotalCountLabel.AutoSize = true;
            this.SearchTotalCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTotalCountLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.SearchTotalCountLabel.Location = new System.Drawing.Point(149, 34);
            this.SearchTotalCountLabel.Name = "SearchTotalCountLabel";
            this.SearchTotalCountLabel.Size = new System.Drawing.Size(51, 13);
            this.SearchTotalCountLabel.TabIndex = 0;
            this.SearchTotalCountLabel.Text = "Total: 0";
            // 
            // ResultsOpenMediaButton
            // 
            this.ResultsOpenMediaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.ResultsOpenMediaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(180)))));
            this.ResultsOpenMediaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultsOpenMediaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsOpenMediaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ResultsOpenMediaButton.Location = new System.Drawing.Point(5, 5);
            this.ResultsOpenMediaButton.Name = "ResultsOpenMediaButton";
            this.ResultsOpenMediaButton.Size = new System.Drawing.Size(47, 23);
            this.ResultsOpenMediaButton.TabIndex = 1;
            this.ResultsOpenMediaButton.Text = "Open";
            this.ResultsOpenMediaButton.UseVisualStyleBackColor = false;
            this.ResultsOpenMediaButton.Click += new System.EventHandler(this.ResultsOpenMediaButton_Click);
            // 
            // ProcessEnableAutoUpdateCheckBox
            // 
            this.ProcessEnableAutoUpdateCheckBox.AutoSize = true;
            this.ProcessEnableAutoUpdateCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessEnableAutoUpdateCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProcessEnableAutoUpdateCheckBox.Location = new System.Drawing.Point(4, 3);
            this.ProcessEnableAutoUpdateCheckBox.Name = "ProcessEnableAutoUpdateCheckBox";
            this.ProcessEnableAutoUpdateCheckBox.Size = new System.Drawing.Size(97, 17);
            this.ProcessEnableAutoUpdateCheckBox.TabIndex = 0;
            this.ProcessEnableAutoUpdateCheckBox.Text = "Auto Update";
            this.ProcessEnableAutoUpdateCheckBox.UseVisualStyleBackColor = true;
            this.ProcessEnableAutoUpdateCheckBox.CheckedChanged += new System.EventHandler(this.ProcessEnableAutoUpdateCheckBox_CheckedChanged);
            // 
            // ProcessEnableCudaCheckBox
            // 
            this.ProcessEnableCudaCheckBox.AutoSize = true;
            this.ProcessEnableCudaCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProcessEnableCudaCheckBox.Location = new System.Drawing.Point(4, 60);
            this.ProcessEnableCudaCheckBox.Name = "ProcessEnableCudaCheckBox";
            this.ProcessEnableCudaCheckBox.Size = new System.Drawing.Size(110, 17);
            this.ProcessEnableCudaCheckBox.TabIndex = 5;
            this.ProcessEnableCudaCheckBox.Text = "Use GPU (CUDA)";
            this.ProcessEnableCudaCheckBox.UseVisualStyleBackColor = true;
            this.ProcessEnableCudaCheckBox.CheckedChanged += new System.EventHandler(this.ProcessEnableCudaCheckBox_CheckedChanged);
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.AutoSize = true;
            this.SelectionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.SelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.SelectionLabel.Location = new System.Drawing.Point(1, 458);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(63, 16);
            this.SelectionLabel.TabIndex = 0;
            this.SelectionLabel.Text = "Selection";
            // 
            // SearchFileTextBox
            // 
            this.SearchFileTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.SearchFileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchFileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFileTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.SearchFileTextBox.Location = new System.Drawing.Point(149, 13);
            this.SearchFileTextBox.Name = "SearchFileTextBox";
            this.SearchFileTextBox.Size = new System.Drawing.Size(143, 20);
            this.SearchFileTextBox.TabIndex = 1;
            this.SearchFileTextBox.TextChanged += new System.EventHandler(this.SearchFileTextBox_TextChanged);
            // 
            // SearchEnableAutoUpdateSearchCheckBox
            // 
            this.SearchEnableAutoUpdateSearchCheckBox.AutoSize = true;
            this.SearchEnableAutoUpdateSearchCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.SearchEnableAutoUpdateSearchCheckBox.Location = new System.Drawing.Point(6, 63);
            this.SearchEnableAutoUpdateSearchCheckBox.Name = "SearchEnableAutoUpdateSearchCheckBox";
            this.SearchEnableAutoUpdateSearchCheckBox.Size = new System.Drawing.Size(86, 17);
            this.SearchEnableAutoUpdateSearchCheckBox.TabIndex = 3;
            this.SearchEnableAutoUpdateSearchCheckBox.Text = "Auto Update";
            this.SearchEnableAutoUpdateSearchCheckBox.UseVisualStyleBackColor = true;
            this.SearchEnableAutoUpdateSearchCheckBox.CheckedChanged += new System.EventHandler(this.SearchEnableAutoUpdateSearchCheckBox_CheckedChanged);
            // 
            // SearchFileLabel
            // 
            this.SearchFileLabel.AutoSize = true;
            this.SearchFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFileLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.SearchFileLabel.Location = new System.Drawing.Point(146, 1);
            this.SearchFileLabel.Name = "SearchFileLabel";
            this.SearchFileLabel.Size = new System.Drawing.Size(51, 12);
            this.SearchFileLabel.TabIndex = 0;
            this.SearchFileLabel.Text = "File Search";
            // 
            // SearchPhraseLabel
            // 
            this.SearchPhraseLabel.AutoSize = true;
            this.SearchPhraseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPhraseLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.SearchPhraseLabel.Location = new System.Drawing.Point(3, 1);
            this.SearchPhraseLabel.Name = "SearchPhraseLabel";
            this.SearchPhraseLabel.Size = new System.Drawing.Size(65, 12);
            this.SearchPhraseLabel.TabIndex = 0;
            this.SearchPhraseLabel.Text = "Phrase Search";
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPanel.Controls.Add(this.SearchFilesCountLabel);
            this.SearchPanel.Controls.Add(this.SearchEnableCaseSensitiveCheckBox);
            this.SearchPanel.Controls.Add(this.SearchPhraseTextBox);
            this.SearchPanel.Controls.Add(this.SearchPhraseLabel);
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Controls.Add(this.SearchFileLabel);
            this.SearchPanel.Controls.Add(this.SearchEnableAutoUpdateSearchCheckBox);
            this.SearchPanel.Controls.Add(this.SearchTotalCountLabel);
            this.SearchPanel.Controls.Add(this.SearchFileTextBox);
            this.SearchPanel.Location = new System.Drawing.Point(305, 28);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(300, 81);
            this.SearchPanel.TabIndex = 0;
            // 
            // SearchEnableCaseSensitiveCheckBox
            // 
            this.SearchEnableCaseSensitiveCheckBox.AutoSize = true;
            this.SearchEnableCaseSensitiveCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.SearchEnableCaseSensitiveCheckBox.Location = new System.Drawing.Point(94, 63);
            this.SearchEnableCaseSensitiveCheckBox.Name = "SearchEnableCaseSensitiveCheckBox";
            this.SearchEnableCaseSensitiveCheckBox.Size = new System.Drawing.Size(96, 17);
            this.SearchEnableCaseSensitiveCheckBox.TabIndex = 4;
            this.SearchEnableCaseSensitiveCheckBox.Text = "Case Sensitive";
            this.SearchEnableCaseSensitiveCheckBox.UseVisualStyleBackColor = true;
            this.SearchEnableCaseSensitiveCheckBox.CheckedChanged += new System.EventHandler(this.SearchEnableCaseSensitiveCheckBox_CheckedChanged);
            // 
            // SelectionPanel
            // 
            this.SelectionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SelectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectionPanel.Controls.Add(this.SelectionEnableSubdirectoriesCheckBox);
            this.SelectionPanel.Controls.Add(this.SelectionFileTypeTextBox);
            this.SelectionPanel.Controls.Add(this.SelectionRemoveFolderButton);
            this.SelectionPanel.Controls.Add(this.SelectionAddFolderButton);
            this.SelectionPanel.Location = new System.Drawing.Point(0, 28);
            this.SelectionPanel.Name = "SelectionPanel";
            this.SelectionPanel.Size = new System.Drawing.Size(300, 36);
            this.SelectionPanel.TabIndex = 0;
            // 
            // SelectionEnableSubdirectoriesCheckBox
            // 
            this.SelectionEnableSubdirectoriesCheckBox.AutoSize = true;
            this.SelectionEnableSubdirectoriesCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.SelectionEnableSubdirectoriesCheckBox.Location = new System.Drawing.Point(128, 8);
            this.SelectionEnableSubdirectoriesCheckBox.Name = "SelectionEnableSubdirectoriesCheckBox";
            this.SelectionEnableSubdirectoriesCheckBox.Size = new System.Drawing.Size(93, 17);
            this.SelectionEnableSubdirectoriesCheckBox.TabIndex = 3;
            this.SelectionEnableSubdirectoriesCheckBox.Text = "Subdirectories";
            this.SelectionEnableSubdirectoriesCheckBox.UseVisualStyleBackColor = true;
            this.SelectionEnableSubdirectoriesCheckBox.CheckedChanged += new System.EventHandler(this.SelectionEnableSubdirectoriesCheckBox_CheckedChanged);
            // 
            // SelectionFileTypeTextBox
            // 
            this.SelectionFileTypeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.SelectionFileTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectionFileTypeTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.SelectionFileTypeTextBox.Location = new System.Drawing.Point(55, 6);
            this.SelectionFileTypeTextBox.Name = "SelectionFileTypeTextBox";
            this.SelectionFileTypeTextBox.Size = new System.Drawing.Size(70, 20);
            this.SelectionFileTypeTextBox.TabIndex = 2;
            this.SelectionFileTypeTextBox.TextChanged += new System.EventHandler(this.SelectionFileTypeTextBox_TextChanged);
            // 
            // SelectionRemoveFolderButton
            // 
            this.SelectionRemoveFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SelectionRemoveFolderButton.BackgroundImage = global::Scribe.Properties.Resources.remove;
            this.SelectionRemoveFolderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SelectionRemoveFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectionRemoveFolderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SelectionRemoveFolderButton.Location = new System.Drawing.Point(28, 5);
            this.SelectionRemoveFolderButton.Name = "SelectionRemoveFolderButton";
            this.SelectionRemoveFolderButton.Size = new System.Drawing.Size(22, 22);
            this.SelectionRemoveFolderButton.TabIndex = 1;
            this.SelectionRemoveFolderButton.UseVisualStyleBackColor = false;
            this.SelectionRemoveFolderButton.Click += new System.EventHandler(this.SelectionRemoveFolderButton_Click);
            // 
            // SelectionAddFolderButton
            // 
            this.SelectionAddFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SelectionAddFolderButton.BackgroundImage = global::Scribe.Properties.Resources.add;
            this.SelectionAddFolderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SelectionAddFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectionAddFolderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SelectionAddFolderButton.Location = new System.Drawing.Point(5, 5);
            this.SelectionAddFolderButton.Name = "SelectionAddFolderButton";
            this.SelectionAddFolderButton.Size = new System.Drawing.Size(22, 22);
            this.SelectionAddFolderButton.TabIndex = 0;
            this.SelectionAddFolderButton.UseVisualStyleBackColor = false;
            this.SelectionAddFolderButton.Click += new System.EventHandler(this.SelectionAddFolderButton_Click);
            // 
            // ProcessPanel
            // 
            this.ProcessPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ProcessPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProcessPanel.Controls.Add(this.ProcessEnableStartWithWindowsCheckBox);
            this.ProcessPanel.Controls.Add(this.ProcessUpdateButton);
            this.ProcessPanel.Controls.Add(this.ProcessEnableOutputPauseCheckBox);
            this.ProcessPanel.Controls.Add(this.ProcessEnableOutputCheckBox);
            this.ProcessPanel.Controls.Add(this.ProcessModelLabel);
            this.ProcessPanel.Controls.Add(this.ProcessModelComboBox);
            this.ProcessPanel.Controls.Add(this.ProcessCleanStorageButton);
            this.ProcessPanel.Controls.Add(this.ProcessProgressBar);
            this.ProcessPanel.Controls.Add(this.ProcessProgressLabel);
            this.ProcessPanel.Controls.Add(this.ProcessAbortButton);
            this.ProcessPanel.Controls.Add(this.ProcessEnableCudaCheckBox);
            this.ProcessPanel.Controls.Add(this.ProcessEnableAutoUpdateCheckBox);
            this.ProcessPanel.Location = new System.Drawing.Point(0, 478);
            this.ProcessPanel.Name = "ProcessPanel";
            this.ProcessPanel.Size = new System.Drawing.Size(300, 117);
            this.ProcessPanel.TabIndex = 0;
            // 
            // ProcessEnableStartWithWindowsCheckBox
            // 
            this.ProcessEnableStartWithWindowsCheckBox.AutoSize = true;
            this.ProcessEnableStartWithWindowsCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProcessEnableStartWithWindowsCheckBox.Location = new System.Drawing.Point(4, 22);
            this.ProcessEnableStartWithWindowsCheckBox.Name = "ProcessEnableStartWithWindowsCheckBox";
            this.ProcessEnableStartWithWindowsCheckBox.Size = new System.Drawing.Size(120, 17);
            this.ProcessEnableStartWithWindowsCheckBox.TabIndex = 2;
            this.ProcessEnableStartWithWindowsCheckBox.Text = "Start With Windows";
            this.ProcessEnableStartWithWindowsCheckBox.UseVisualStyleBackColor = true;
            this.ProcessEnableStartWithWindowsCheckBox.CheckedChanged += new System.EventHandler(this.ProcessEnableStartWithWindowsCheckBox_CheckedChanged);
            // 
            // ProcessUpdateButton
            // 
            this.ProcessUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.ProcessUpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(250)))), ((int)(((byte)(230)))));
            this.ProcessUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.ProcessUpdateButton.ForeColor = System.Drawing.Color.Honeydew;
            this.ProcessUpdateButton.Location = new System.Drawing.Point(98, 1);
            this.ProcessUpdateButton.Name = "ProcessUpdateButton";
            this.ProcessUpdateButton.Size = new System.Drawing.Size(45, 20);
            this.ProcessUpdateButton.TabIndex = 1;
            this.ProcessUpdateButton.Text = "Update";
            this.ProcessUpdateButton.UseVisualStyleBackColor = false;
            this.ProcessUpdateButton.Click += new System.EventHandler(this.ProcessUpdateButton_Click);
            // 
            // ProcessEnableOutputPauseCheckBox
            // 
            this.ProcessEnableOutputPauseCheckBox.AutoSize = true;
            this.ProcessEnableOutputPauseCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProcessEnableOutputPauseCheckBox.Location = new System.Drawing.Point(98, 41);
            this.ProcessEnableOutputPauseCheckBox.Name = "ProcessEnableOutputPauseCheckBox";
            this.ProcessEnableOutputPauseCheckBox.Size = new System.Drawing.Size(56, 17);
            this.ProcessEnableOutputPauseCheckBox.TabIndex = 4;
            this.ProcessEnableOutputPauseCheckBox.Text = "Pause";
            this.ProcessEnableOutputPauseCheckBox.UseVisualStyleBackColor = true;
            this.ProcessEnableOutputPauseCheckBox.Visible = false;
            this.ProcessEnableOutputPauseCheckBox.CheckedChanged += new System.EventHandler(this.ProcessEnableOutputPauseCheckBox_CheckedChanged);
            // 
            // ProcessEnableOutputCheckBox
            // 
            this.ProcessEnableOutputCheckBox.AutoSize = true;
            this.ProcessEnableOutputCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProcessEnableOutputCheckBox.Location = new System.Drawing.Point(4, 41);
            this.ProcessEnableOutputCheckBox.Name = "ProcessEnableOutputCheckBox";
            this.ProcessEnableOutputCheckBox.Size = new System.Drawing.Size(95, 17);
            this.ProcessEnableOutputCheckBox.TabIndex = 3;
            this.ProcessEnableOutputCheckBox.Text = "Display Output";
            this.ProcessEnableOutputCheckBox.UseVisualStyleBackColor = true;
            this.ProcessEnableOutputCheckBox.CheckedChanged += new System.EventHandler(this.ProcessEnableOutputCheckBox_CheckedChanged);
            // 
            // ProcessModelLabel
            // 
            this.ProcessModelLabel.AutoSize = true;
            this.ProcessModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.ProcessModelLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProcessModelLabel.Location = new System.Drawing.Point(110, 62);
            this.ProcessModelLabel.Name = "ProcessModelLabel";
            this.ProcessModelLabel.Size = new System.Drawing.Size(34, 12);
            this.ProcessModelLabel.TabIndex = 0;
            this.ProcessModelLabel.Text = "Model:";
            // 
            // ProcessModelComboBox
            // 
            this.ProcessModelComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ProcessModelComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessModelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessModelComboBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProcessModelComboBox.FormattingEnabled = true;
            this.ProcessModelComboBox.Items.AddRange(new object[] {
            "tiny",
            "base",
            "small",
            "medium",
            "large"});
            this.ProcessModelComboBox.Location = new System.Drawing.Point(146, 58);
            this.ProcessModelComboBox.Name = "ProcessModelComboBox";
            this.ProcessModelComboBox.Size = new System.Drawing.Size(68, 20);
            this.ProcessModelComboBox.TabIndex = 6;
            this.ProcessModelComboBox.SelectedIndexChanged += new System.EventHandler(this.ProcessModelComboBox_SelectedIndexChanged);
            // 
            // ProcessCleanStorageButton
            // 
            this.ProcessCleanStorageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ProcessCleanStorageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ProcessCleanStorageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessCleanStorageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessCleanStorageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ProcessCleanStorageButton.Location = new System.Drawing.Point(254, 80);
            this.ProcessCleanStorageButton.Name = "ProcessCleanStorageButton";
            this.ProcessCleanStorageButton.Size = new System.Drawing.Size(40, 20);
            this.ProcessCleanStorageButton.TabIndex = 8;
            this.ProcessCleanStorageButton.Text = "Clean";
            this.ProcessCleanStorageButton.UseVisualStyleBackColor = false;
            this.ProcessCleanStorageButton.Click += new System.EventHandler(this.ProcessCleanStorageButton_Click);
            // 
            // MainMenuContextMenuStrip
            // 
            this.MainMenuContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.MainMenuContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowToolStripMenuItem,
            this.EnableToolStripMenuItem,
            this.AbortToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MainMenuContextMenuStrip.Name = "MainMenuContextMenuStrip";
            this.MainMenuContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenuContextMenuStrip.ShowImageMargin = false;
            this.MainMenuContextMenuStrip.Size = new System.Drawing.Size(85, 92);
            this.MainMenuContextMenuStrip.Opened += new System.EventHandler(this.MainMenuContextMenuStrip_Opened);
            // 
            // ShowToolStripMenuItem
            // 
            this.ShowToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
            this.ShowToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.ShowToolStripMenuItem.Text = "Show";
            this.ShowToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // EnableToolStripMenuItem
            // 
            this.EnableToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.EnableToolStripMenuItem.Name = "EnableToolStripMenuItem";
            this.EnableToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.EnableToolStripMenuItem.Text = "Enable";
            this.EnableToolStripMenuItem.Click += new System.EventHandler(this.EnableToolStripMenuItem_Click);
            // 
            // AbortToolStripMenuItem
            // 
            this.AbortToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.AbortToolStripMenuItem.Name = "AbortToolStripMenuItem";
            this.AbortToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.AbortToolStripMenuItem.Text = "Abort";
            this.AbortToolStripMenuItem.Click += new System.EventHandler(this.AbortToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MainMenuNotifyIcon
            // 
            this.MainMenuNotifyIcon.BalloonTipText = "Scribe";
            this.MainMenuNotifyIcon.BalloonTipTitle = "Scribe";
            this.MainMenuNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MainMenuNotifyIcon.Icon")));
            this.MainMenuNotifyIcon.Text = "Scribe";
            this.MainMenuNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainMenuNotifyIcon_MouseClick);
            // 
            // ResultsPanel
            // 
            this.ResultsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ResultsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultsPanel.Controls.Add(this.ResultsBrowseMediaButton);
            this.ResultsPanel.Controls.Add(this.ResultsOpenMediaButton);
            this.ResultsPanel.Location = new System.Drawing.Point(305, 559);
            this.ResultsPanel.Name = "ResultsPanel";
            this.ResultsPanel.Size = new System.Drawing.Size(300, 36);
            this.ResultsPanel.TabIndex = 0;
            // 
            // ResultsBrowseMediaButton
            // 
            this.ResultsBrowseMediaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.ResultsBrowseMediaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(180)))));
            this.ResultsBrowseMediaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultsBrowseMediaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsBrowseMediaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ResultsBrowseMediaButton.Location = new System.Drawing.Point(52, 5);
            this.ResultsBrowseMediaButton.Name = "ResultsBrowseMediaButton";
            this.ResultsBrowseMediaButton.Size = new System.Drawing.Size(58, 23);
            this.ResultsBrowseMediaButton.TabIndex = 2;
            this.ResultsBrowseMediaButton.Text = "Browse";
            this.ResultsBrowseMediaButton.UseVisualStyleBackColor = false;
            this.ResultsBrowseMediaButton.Click += new System.EventHandler(this.ResultsBrowseMediaButton_Click);
            // 
            // MainToolTip
            // 
            this.MainToolTip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.MainToolTip_Draw);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SearchCurrentCountLabel);
            this.panel1.Location = new System.Drawing.Point(610, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 17);
            this.panel1.TabIndex = 3;
            // 
            // SearchFilesCountLabel
            // 
            this.SearchFilesCountLabel.AutoSize = true;
            this.SearchFilesCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFilesCountLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.SearchFilesCountLabel.Location = new System.Drawing.Point(149, 48);
            this.SearchFilesCountLabel.Name = "SearchFilesCountLabel";
            this.SearchFilesCountLabel.Size = new System.Drawing.Size(48, 13);
            this.SearchFilesCountLabel.TabIndex = 5;
            this.SearchFilesCountLabel.Text = "Files: 0";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ResultsPanel);
            this.Controls.Add(this.ProcessPanel);
            this.Controls.Add(this.SelectionPanel);
            this.Controls.Add(this.SelectionLabel);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.SearchFilesListBox);
            this.Controls.Add(this.SelectionListBox);
            this.Controls.Add(this.TitlebarPanel);
            this.Controls.Add(this.SelectedFileTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Scribe";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.TitlebarPanel.ResumeLayout(false);
            this.TitlebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlebarPictureBox)).EndInit();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.SelectionPanel.ResumeLayout(false);
            this.SelectionPanel.PerformLayout();
            this.ProcessPanel.ResumeLayout(false);
            this.ProcessPanel.PerformLayout();
            this.MainMenuContextMenuStrip.ResumeLayout(false);
            this.ResultsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SelectionAddFolderButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchPhraseTextBox;
        private System.Windows.Forms.RichTextBox SelectedFileTextBox;
        private System.Windows.Forms.Label SearchCurrentCountLabel;
        private System.Windows.Forms.ProgressBar ProcessProgressBar;
        private System.Windows.Forms.Label ProcessProgressLabel;
        private System.Windows.Forms.Button ProcessAbortButton;
        private System.Windows.Forms.Panel TitlebarPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ListBox SelectionListBox;
        private System.Windows.Forms.ListBox SearchFilesListBox;
        private System.Windows.Forms.Label SearchTotalCountLabel;
        private System.Windows.Forms.Button ResultsOpenMediaButton;
        private System.Windows.Forms.CheckBox ProcessEnableAutoUpdateCheckBox;
        private System.Windows.Forms.CheckBox ProcessEnableCudaCheckBox;
        private System.Windows.Forms.Button SelectionRemoveFolderButton;
        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.TextBox SearchFileTextBox;
        private System.Windows.Forms.CheckBox SearchEnableAutoUpdateSearchCheckBox;
        private System.Windows.Forms.Label SearchFileLabel;
        private System.Windows.Forms.Label SearchPhraseLabel;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Panel SelectionPanel;
        private System.Windows.Forms.Panel ProcessPanel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.CheckBox SearchEnableCaseSensitiveCheckBox;
        private System.Windows.Forms.Button ProcessCleanStorageButton;
        private System.Windows.Forms.Label TitlebarLabel;
        private System.Windows.Forms.TextBox SelectionFileTypeTextBox;
        private System.Windows.Forms.PictureBox TitlebarPictureBox;
        private System.Windows.Forms.CheckBox SelectionEnableSubdirectoriesCheckBox;
        private System.Windows.Forms.ContextMenuStrip MainMenuContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AbortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon MainMenuNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem EnableToolStripMenuItem;
        private System.Windows.Forms.ComboBox ProcessModelComboBox;
        private System.Windows.Forms.Label ProcessModelLabel;
        private System.Windows.Forms.Panel ResultsPanel;
        private System.Windows.Forms.Button ResultsBrowseMediaButton;
        private System.Windows.Forms.ToolTip MainToolTip;
        private System.Windows.Forms.CheckBox ProcessEnableOutputCheckBox;
        private System.Windows.Forms.CheckBox ProcessEnableOutputPauseCheckBox;
        private System.Windows.Forms.Button ProcessUpdateButton;
        private System.Windows.Forms.CheckBox ProcessEnableStartWithWindowsCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SearchFilesCountLabel;
    }
}

