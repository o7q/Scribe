using System.Drawing;
using System.Windows.Forms;

namespace Scribe
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            TitlebarPanel = new Panel();
            MinimizeButton = new Button();
            CloseButton = new Button();
            SelectionPanel = new Panel();
            SelectionFiletypesLabel = new Label();
            SelectionSubdirectoriesCheckBox = new CheckBox();
            SelectionFiletypesTextBox = new TextBox();
            SelectionRemoveFolderButton = new Button();
            SelectionAddFolderButton = new Button();
            SelectionListBox = new ListBox();
            ProcessPanel = new Panel();
            ProcessProgressBarPanel = new Panel();
            ProcessProgressLabel = new Label();
            ProcessMediaBufferTextBox = new TextBox();
            ProcessMediaBufferLabel = new Label();
            ProcessLanguageLabel = new Label();
            ProcessModelLabel = new Label();
            ProcessLanguageComboBox = new ComboBox();
            ProcessModelComboBox = new ComboBox();
            ProcessDebugCheckBox = new CheckBox();
            ProcessCleanButton = new Button();
            ProcessAbortButton = new Button();
            ProcessUpdateButton = new Button();
            ProcessCudaCheckBox = new CheckBox();
            ProcessAutoUpdateCheckBox = new CheckBox();
            ProcessStartWithWindowsCheckBox = new CheckBox();
            SearchResultsListBox = new ListBox();
            SelectedFileTextBox = new RichTextBox();
            SearchPanel = new Panel();
            SearchSecondsLabel = new Label();
            SearchAutoUpdateCheckBox = new CheckBox();
            SearchCaseSensitiveCheckBox = new CheckBox();
            SearchFileCountLabel = new Label();
            SearchPhraseCountLabel = new Label();
            SearchButton = new Button();
            SearchPhraseFileTextBox = new TextBox();
            SearchPhraseTextBox = new TextBox();
            SearchPhraseFileLabel = new Label();
            SearchPhraseLabel = new Label();
            SearchResultsPanel = new Panel();
            SearchResultsBrowseMediaButton = new Button();
            SearchResultsOpenMediaButton = new Button();
            TitlebarPictureBox = new PictureBox();
            VersionLabel = new Label();
            SelectedFilePanel = new Panel();
            SearchCurrentCountLabel = new Label();
            SelectionLabel = new Label();
            MainToolTip = new ToolTip(components);
            MainMenuNotifyIcon = new NotifyIcon(components);
            MainMenuContextMenuStrip = new ContextMenuStrip(components);
            ShowToolStripMenuItem = new ToolStripMenuItem();
            EnableToolStripMenuItem = new ToolStripMenuItem();
            AbortToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            SelectionPanel.SuspendLayout();
            ProcessPanel.SuspendLayout();
            SearchPanel.SuspendLayout();
            SearchResultsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TitlebarPictureBox).BeginInit();
            SelectedFilePanel.SuspendLayout();
            MainMenuContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // TitlebarPanel
            // 
            TitlebarPanel.Location = new Point(0, 0);
            TitlebarPanel.Name = "TitlebarPanel";
            TitlebarPanel.Size = new Size(1200, 28);
            TitlebarPanel.TabIndex = 0;
            TitlebarPanel.MouseDown += TitlebarPanel_MouseDown;
            // 
            // MinimizeButton
            // 
            MinimizeButton.BackColor = Color.FromArgb(5, 6, 7);
            MinimizeButton.FlatAppearance.BorderColor = Color.FromArgb(5, 6, 7);
            MinimizeButton.FlatStyle = FlatStyle.Flat;
            MinimizeButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimizeButton.ForeColor = Color.FromArgb(120, 130, 140);
            MinimizeButton.Location = new Point(1144, 0);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(28, 28);
            MinimizeButton.TabIndex = 0;
            MinimizeButton.Text = "—";
            MinimizeButton.UseVisualStyleBackColor = false;
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(5, 6, 7);
            CloseButton.FlatAppearance.BorderColor = Color.FromArgb(5, 6, 7);
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CloseButton.ForeColor = Color.FromArgb(120, 130, 140);
            CloseButton.Location = new Point(1172, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(28, 28);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "❌";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // SelectionPanel
            // 
            SelectionPanel.BackColor = Color.FromArgb(20, 22, 24);
            SelectionPanel.BorderStyle = BorderStyle.FixedSingle;
            SelectionPanel.Controls.Add(SelectionFiletypesLabel);
            SelectionPanel.Controls.Add(SelectionSubdirectoriesCheckBox);
            SelectionPanel.Controls.Add(SelectionFiletypesTextBox);
            SelectionPanel.Controls.Add(SelectionRemoveFolderButton);
            SelectionPanel.Controls.Add(SelectionAddFolderButton);
            SelectionPanel.Location = new Point(0, 28);
            SelectionPanel.Name = "SelectionPanel";
            SelectionPanel.Size = new Size(273, 41);
            SelectionPanel.TabIndex = 2;
            // 
            // SelectionFiletypesLabel
            // 
            SelectionFiletypesLabel.AutoSize = true;
            SelectionFiletypesLabel.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectionFiletypesLabel.ForeColor = Color.FromArgb(220, 230, 240);
            SelectionFiletypesLabel.Location = new Point(53, 13);
            SelectionFiletypesLabel.Name = "SelectionFiletypesLabel";
            SelectionFiletypesLabel.Size = new Size(46, 12);
            SelectionFiletypesLabel.TabIndex = 17;
            SelectionFiletypesLabel.Text = "Filetypes:";
            // 
            // SelectionSubdirectoriesCheckBox
            // 
            SelectionSubdirectoriesCheckBox.AutoSize = true;
            SelectionSubdirectoriesCheckBox.Font = new Font("Microsoft Sans Serif", 8.25F);
            SelectionSubdirectoriesCheckBox.ForeColor = Color.FromArgb(220, 230, 240);
            SelectionSubdirectoriesCheckBox.Location = new Point(148, 12);
            SelectionSubdirectoriesCheckBox.Name = "SelectionSubdirectoriesCheckBox";
            SelectionSubdirectoriesCheckBox.Size = new Size(121, 17);
            SelectionSubdirectoriesCheckBox.TabIndex = 5;
            SelectionSubdirectoriesCheckBox.Text = "Scan Subdirectories";
            SelectionSubdirectoriesCheckBox.UseVisualStyleBackColor = true;
            SelectionSubdirectoriesCheckBox.CheckedChanged += SelectionSubdirectoriesCheckBox_CheckedChanged;
            // 
            // SelectionFiletypesTextBox
            // 
            SelectionFiletypesTextBox.BackColor = Color.FromArgb(30, 32, 34);
            SelectionFiletypesTextBox.BorderStyle = BorderStyle.FixedSingle;
            SelectionFiletypesTextBox.Font = new Font("Microsoft Sans Serif", 8.25F);
            SelectionFiletypesTextBox.ForeColor = Color.FromArgb(200, 245, 220);
            SelectionFiletypesTextBox.Location = new Point(102, 10);
            SelectionFiletypesTextBox.Name = "SelectionFiletypesTextBox";
            SelectionFiletypesTextBox.Size = new Size(40, 20);
            SelectionFiletypesTextBox.TabIndex = 4;
            SelectionFiletypesTextBox.TextChanged += SelectionFiletypesTextBox_TextChanged;
            // 
            // SelectionRemoveFolderButton
            // 
            SelectionRemoveFolderButton.BackColor = Color.FromArgb(20, 22, 24);
            SelectionRemoveFolderButton.BackgroundImage = Properties.Resources.remove;
            SelectionRemoveFolderButton.BackgroundImageLayout = ImageLayout.Zoom;
            SelectionRemoveFolderButton.FlatStyle = FlatStyle.Flat;
            SelectionRemoveFolderButton.ForeColor = Color.FromArgb(20, 22, 24);
            SelectionRemoveFolderButton.Location = new Point(28, 8);
            SelectionRemoveFolderButton.Name = "SelectionRemoveFolderButton";
            SelectionRemoveFolderButton.Size = new Size(22, 22);
            SelectionRemoveFolderButton.TabIndex = 3;
            SelectionRemoveFolderButton.UseVisualStyleBackColor = false;
            SelectionRemoveFolderButton.Click += SelectionRemoveFolderButton_Click;
            // 
            // SelectionAddFolderButton
            // 
            SelectionAddFolderButton.BackColor = Color.FromArgb(20, 22, 24);
            SelectionAddFolderButton.BackgroundImage = Properties.Resources.add;
            SelectionAddFolderButton.BackgroundImageLayout = ImageLayout.Zoom;
            SelectionAddFolderButton.FlatStyle = FlatStyle.Flat;
            SelectionAddFolderButton.ForeColor = Color.FromArgb(20, 22, 24);
            SelectionAddFolderButton.Location = new Point(5, 8);
            SelectionAddFolderButton.Name = "SelectionAddFolderButton";
            SelectionAddFolderButton.Size = new Size(22, 22);
            SelectionAddFolderButton.TabIndex = 2;
            SelectionAddFolderButton.UseVisualStyleBackColor = false;
            SelectionAddFolderButton.Click += SelectionAddFolderButton_Click;
            // 
            // SelectionListBox
            // 
            SelectionListBox.BackColor = Color.FromArgb(10, 12, 14);
            SelectionListBox.BorderStyle = BorderStyle.None;
            SelectionListBox.DrawMode = DrawMode.OwnerDrawFixed;
            SelectionListBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectionListBox.ForeColor = Color.FromArgb(220, 230, 240);
            SelectionListBox.FormattingEnabled = true;
            SelectionListBox.Location = new Point(0, 69);
            SelectionListBox.Name = "SelectionListBox";
            SelectionListBox.Size = new Size(273, 448);
            SelectionListBox.TabIndex = 6;
            SelectionListBox.DrawItem += SelectionListBox_DrawItem;
            SelectionListBox.SelectedIndexChanged += SelectionListBox_SelectedIndexChanged;
            // 
            // ProcessPanel
            // 
            ProcessPanel.BackColor = Color.FromArgb(20, 22, 24);
            ProcessPanel.BorderStyle = BorderStyle.FixedSingle;
            ProcessPanel.Controls.Add(ProcessProgressBarPanel);
            ProcessPanel.Controls.Add(ProcessProgressLabel);
            ProcessPanel.Controls.Add(ProcessMediaBufferTextBox);
            ProcessPanel.Controls.Add(ProcessMediaBufferLabel);
            ProcessPanel.Controls.Add(ProcessLanguageLabel);
            ProcessPanel.Controls.Add(ProcessModelLabel);
            ProcessPanel.Controls.Add(ProcessLanguageComboBox);
            ProcessPanel.Controls.Add(ProcessModelComboBox);
            ProcessPanel.Controls.Add(ProcessDebugCheckBox);
            ProcessPanel.Controls.Add(ProcessCleanButton);
            ProcessPanel.Controls.Add(ProcessAbortButton);
            ProcessPanel.Controls.Add(ProcessUpdateButton);
            ProcessPanel.Controls.Add(ProcessCudaCheckBox);
            ProcessPanel.Controls.Add(ProcessAutoUpdateCheckBox);
            ProcessPanel.Controls.Add(ProcessStartWithWindowsCheckBox);
            ProcessPanel.Location = new Point(0, 517);
            ProcessPanel.Name = "ProcessPanel";
            ProcessPanel.Size = new Size(273, 79);
            ProcessPanel.TabIndex = 7;
            // 
            // ProcessProgressBarPanel
            // 
            ProcessProgressBarPanel.BackColor = Color.FromArgb(75, 245, 105);
            ProcessProgressBarPanel.Location = new Point(0, 73);
            ProcessProgressBarPanel.Name = "ProcessProgressBarPanel";
            ProcessProgressBarPanel.Size = new Size(272, 4);
            ProcessProgressBarPanel.TabIndex = 0;
            // 
            // ProcessProgressLabel
            // 
            ProcessProgressLabel.AutoSize = true;
            ProcessProgressLabel.Font = new Font("Microsoft Sans Serif", 6.75F);
            ProcessProgressLabel.ForeColor = Color.FromArgb(75, 245, 105);
            ProcessProgressLabel.Location = new Point(1, 58);
            ProcessProgressLabel.Name = "ProcessProgressLabel";
            ProcessProgressLabel.Size = new Size(106, 12);
            ProcessProgressLabel.TabIndex = 0;
            ProcessProgressLabel.Text = "[0/0  |  0.00%  |  00:00:00]";
            // 
            // ProcessMediaBufferTextBox
            // 
            ProcessMediaBufferTextBox.BackColor = Color.FromArgb(30, 32, 34);
            ProcessMediaBufferTextBox.BorderStyle = BorderStyle.None;
            ProcessMediaBufferTextBox.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProcessMediaBufferTextBox.ForeColor = Color.FromArgb(200, 245, 220);
            ProcessMediaBufferTextBox.Location = new Point(210, 59);
            ProcessMediaBufferTextBox.Name = "ProcessMediaBufferTextBox";
            ProcessMediaBufferTextBox.Size = new Size(11, 11);
            ProcessMediaBufferTextBox.TabIndex = 12;
            ProcessMediaBufferTextBox.TextChanged += ProcessMediaBufferTextBox_TextChanged;
            // 
            // ProcessMediaBufferLabel
            // 
            ProcessMediaBufferLabel.AutoSize = true;
            ProcessMediaBufferLabel.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProcessMediaBufferLabel.ForeColor = Color.FromArgb(220, 230, 240);
            ProcessMediaBufferLabel.Location = new Point(149, 59);
            ProcessMediaBufferLabel.Name = "ProcessMediaBufferLabel";
            ProcessMediaBufferLabel.Size = new Size(61, 12);
            ProcessMediaBufferLabel.TabIndex = 0;
            ProcessMediaBufferLabel.Text = "Media Buffer:";
            // 
            // ProcessLanguageLabel
            // 
            ProcessLanguageLabel.AutoSize = true;
            ProcessLanguageLabel.Font = new Font("Microsoft Sans Serif", 6.75F);
            ProcessLanguageLabel.ForeColor = Color.FromArgb(220, 230, 240);
            ProcessLanguageLabel.Location = new Point(193, 23);
            ProcessLanguageLabel.Name = "ProcessLanguageLabel";
            ProcessLanguageLabel.Size = new Size(48, 12);
            ProcessLanguageLabel.TabIndex = 0;
            ProcessLanguageLabel.Text = "Language:";
            // 
            // ProcessModelLabel
            // 
            ProcessModelLabel.AutoSize = true;
            ProcessModelLabel.Font = new Font("Microsoft Sans Serif", 6.75F);
            ProcessModelLabel.ForeColor = Color.FromArgb(220, 230, 240);
            ProcessModelLabel.Location = new Point(129, 23);
            ProcessModelLabel.Name = "ProcessModelLabel";
            ProcessModelLabel.Size = new Size(34, 12);
            ProcessModelLabel.TabIndex = 0;
            ProcessModelLabel.Text = "Model:";
            // 
            // ProcessLanguageComboBox
            // 
            ProcessLanguageComboBox.BackColor = Color.FromArgb(30, 32, 34);
            ProcessLanguageComboBox.FlatStyle = FlatStyle.Flat;
            ProcessLanguageComboBox.Font = new Font("Microsoft Sans Serif", 6.75F);
            ProcessLanguageComboBox.ForeColor = Color.FromArgb(200, 245, 220);
            ProcessLanguageComboBox.FormattingEnabled = true;
            ProcessLanguageComboBox.Items.AddRange(new object[] { "Afrikaans", "Albanian", "Amharic", "Arabic", "Armenian", "Assamese", "Azerbaijani", "Bashkir", "Basque", "Belarusian", "Bengali", "Bosnian", "Breton", "Bulgarian", "Burmese", "Cantonese", "Castilian", "Catalan", "Chinese", "Croatian", "Czech", "Danish", "Dutch", "English", "Estonian", "Faroese", "Finnish", "Flemish", "French", "Galician", "Georgian", "German", "Greek", "Gujarati", "Haitian", "Haitian Creole", "Hausa", "Hawaiian", "Hebrew", "Hindi", "Hungarian", "Icelandic", "Indonesian", "Italian", "Japanese", "Javanese", "Kannada", "Kazakh", "Khmer", "Korean", "Lao", "Latin", "Latvian", "Letzeburgesch", "Lingala", "Lithuanian", "Luxembourgish", "Macedonian", "Malagasy", "Malay", "Malayalam", "Maltese", "Mandarin", "Maori", "Marathi", "Moldavian", "Moldovan", "Mongolian", "Myanmar", "Nepali", "Norwegian", "Nynorsk", "Occitan", "Panjabi", "Pashto", "Persian", "Polish", "Portuguese", "Punjabi", "Pushto", "Romanian", "Russian", "Sanskrit", "Serbian", "Shona", "Sindhi", "Sinhala", "Sinhalese", "Slovak", "Slovenian", "Somali", "Spanish", "Sundanese", "Swahili", "Swedish", "Tagalog", "Tajik", "Tamil", "Tatar", "Telugu", "Thai", "Tibetan", "Turkish", "Turkmen", "Ukrainian", "Urdu", "Uzbek", "Valencian", "Vietnamese", "Welsh", "Yiddish", "Yoruba" });
            ProcessLanguageComboBox.Location = new Point(195, 37);
            ProcessLanguageComboBox.Name = "ProcessLanguageComboBox";
            ProcessLanguageComboBox.Size = new Size(74, 20);
            ProcessLanguageComboBox.TabIndex = 11;
            ProcessLanguageComboBox.SelectedIndexChanged += ProcessLanguageComboBox_SelectedIndexChanged;
            // 
            // ProcessModelComboBox
            // 
            ProcessModelComboBox.BackColor = Color.FromArgb(30, 32, 34);
            ProcessModelComboBox.FlatStyle = FlatStyle.Flat;
            ProcessModelComboBox.Font = new Font("Microsoft Sans Serif", 6.75F);
            ProcessModelComboBox.ForeColor = Color.FromArgb(200, 245, 220);
            ProcessModelComboBox.FormattingEnabled = true;
            ProcessModelComboBox.Items.AddRange(new object[] { "tiny", "tiny.en", "base", "base.en", "small", "small.en", "medium", "medium.en", "large", "large-v1", "large-v2", "large-v3" });
            ProcessModelComboBox.Location = new Point(132, 37);
            ProcessModelComboBox.Name = "ProcessModelComboBox";
            ProcessModelComboBox.Size = new Size(60, 20);
            ProcessModelComboBox.TabIndex = 10;
            ProcessModelComboBox.SelectedIndexChanged += ProcessModelComboBox_SelectedIndexChanged;
            // 
            // ProcessDebugCheckBox
            // 
            ProcessDebugCheckBox.AutoSize = true;
            ProcessDebugCheckBox.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProcessDebugCheckBox.ForeColor = Color.FromArgb(220, 230, 240);
            ProcessDebugCheckBox.Location = new Point(223, 58);
            ProcessDebugCheckBox.Name = "ProcessDebugCheckBox";
            ProcessDebugCheckBox.Size = new Size(51, 16);
            ProcessDebugCheckBox.TabIndex = 13;
            ProcessDebugCheckBox.Text = "Debug";
            ProcessDebugCheckBox.UseVisualStyleBackColor = true;
            ProcessDebugCheckBox.CheckedChanged += ProcessDebugCheckBox_CheckedChanged;
            // 
            // ProcessCleanButton
            // 
            ProcessCleanButton.BackColor = Color.FromArgb(150, 130, 130);
            ProcessCleanButton.FlatAppearance.BorderColor = Color.FromArgb(180, 165, 165);
            ProcessCleanButton.FlatStyle = FlatStyle.Flat;
            ProcessCleanButton.Font = new Font("Microsoft Sans Serif", 6.75F);
            ProcessCleanButton.ForeColor = Color.FromArgb(255, 240, 240);
            ProcessCleanButton.Location = new Point(89, 37);
            ProcessCleanButton.Name = "ProcessCleanButton";
            ProcessCleanButton.Size = new Size(40, 20);
            ProcessCleanButton.TabIndex = 16;
            ProcessCleanButton.Text = "Clean";
            ProcessCleanButton.UseVisualStyleBackColor = false;
            ProcessCleanButton.Click += ProcessCleanButton_Click;
            // 
            // ProcessAbortButton
            // 
            ProcessAbortButton.BackColor = Color.FromArgb(150, 150, 130);
            ProcessAbortButton.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 165);
            ProcessAbortButton.FlatStyle = FlatStyle.Flat;
            ProcessAbortButton.Font = new Font("Microsoft Sans Serif", 6.75F);
            ProcessAbortButton.ForeColor = Color.Ivory;
            ProcessAbortButton.Location = new Point(49, 37);
            ProcessAbortButton.Name = "ProcessAbortButton";
            ProcessAbortButton.Size = new Size(40, 20);
            ProcessAbortButton.TabIndex = 15;
            ProcessAbortButton.Text = "Abort";
            ProcessAbortButton.UseVisualStyleBackColor = false;
            ProcessAbortButton.Click += ProcessAbortButton_Click;
            // 
            // ProcessUpdateButton
            // 
            ProcessUpdateButton.BackColor = Color.FromArgb(130, 150, 130);
            ProcessUpdateButton.FlatAppearance.BorderColor = Color.FromArgb(165, 180, 165);
            ProcessUpdateButton.FlatStyle = FlatStyle.Flat;
            ProcessUpdateButton.Font = new Font("Microsoft Sans Serif", 6.75F);
            ProcessUpdateButton.ForeColor = Color.Honeydew;
            ProcessUpdateButton.Location = new Point(4, 37);
            ProcessUpdateButton.Name = "ProcessUpdateButton";
            ProcessUpdateButton.Size = new Size(45, 20);
            ProcessUpdateButton.TabIndex = 14;
            ProcessUpdateButton.Text = "Update";
            ProcessUpdateButton.UseVisualStyleBackColor = false;
            ProcessUpdateButton.Click += ProcessUpdateButton_Click;
            // 
            // ProcessCudaCheckBox
            // 
            ProcessCudaCheckBox.AutoSize = true;
            ProcessCudaCheckBox.Enabled = false;
            ProcessCudaCheckBox.Font = new Font("Microsoft Sans Serif", 8.25F);
            ProcessCudaCheckBox.ForeColor = Color.FromArgb(220, 230, 240);
            ProcessCudaCheckBox.Location = new Point(131, 3);
            ProcessCudaCheckBox.Name = "ProcessCudaCheckBox";
            ProcessCudaCheckBox.Size = new Size(110, 17);
            ProcessCudaCheckBox.TabIndex = 9;
            ProcessCudaCheckBox.Text = "Use GPU (CUDA)";
            ProcessCudaCheckBox.UseVisualStyleBackColor = true;
            ProcessCudaCheckBox.CheckedChanged += ProcessCudaCheckBox_CheckedChanged;
            // 
            // ProcessAutoUpdateCheckBox
            // 
            ProcessAutoUpdateCheckBox.AutoSize = true;
            ProcessAutoUpdateCheckBox.Font = new Font("Microsoft Sans Serif", 8.25F);
            ProcessAutoUpdateCheckBox.ForeColor = Color.FromArgb(220, 230, 240);
            ProcessAutoUpdateCheckBox.Location = new Point(4, 19);
            ProcessAutoUpdateCheckBox.Name = "ProcessAutoUpdateCheckBox";
            ProcessAutoUpdateCheckBox.Size = new Size(86, 17);
            ProcessAutoUpdateCheckBox.TabIndex = 8;
            ProcessAutoUpdateCheckBox.Text = "Auto Update";
            ProcessAutoUpdateCheckBox.UseVisualStyleBackColor = true;
            ProcessAutoUpdateCheckBox.CheckedChanged += ProcessAutoUpdateCheckBox_CheckedChanged;
            // 
            // ProcessStartWithWindowsCheckBox
            // 
            ProcessStartWithWindowsCheckBox.AutoSize = true;
            ProcessStartWithWindowsCheckBox.Font = new Font("Microsoft Sans Serif", 8.25F);
            ProcessStartWithWindowsCheckBox.ForeColor = Color.FromArgb(220, 230, 240);
            ProcessStartWithWindowsCheckBox.Location = new Point(4, 3);
            ProcessStartWithWindowsCheckBox.Name = "ProcessStartWithWindowsCheckBox";
            ProcessStartWithWindowsCheckBox.Size = new Size(120, 17);
            ProcessStartWithWindowsCheckBox.TabIndex = 7;
            ProcessStartWithWindowsCheckBox.Text = "Start With Windows";
            ProcessStartWithWindowsCheckBox.UseVisualStyleBackColor = true;
            ProcessStartWithWindowsCheckBox.CheckedChanged += ProcessStartWithWindowsCheckBox_CheckedChanged;
            // 
            // SearchResultsListBox
            // 
            SearchResultsListBox.BackColor = Color.FromArgb(10, 12, 14);
            SearchResultsListBox.BorderStyle = BorderStyle.None;
            SearchResultsListBox.DrawMode = DrawMode.OwnerDrawFixed;
            SearchResultsListBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchResultsListBox.ForeColor = Color.FromArgb(220, 230, 240);
            SearchResultsListBox.FormattingEnabled = true;
            SearchResultsListBox.Location = new Point(278, 109);
            SearchResultsListBox.Name = "SearchResultsListBox";
            SearchResultsListBox.Size = new Size(327, 448);
            SearchResultsListBox.TabIndex = 21;
            SearchResultsListBox.DrawItem += SearchResultsListBox_DrawItem;
            SearchResultsListBox.SelectedIndexChanged += SearchResultsListBox_SelectedIndexChanged;
            SearchResultsListBox.KeyDown += SearchResultsListBox_KeyDown;
            // 
            // SelectedFileTextBox
            // 
            SelectedFileTextBox.BackColor = Color.FromArgb(10, 12, 14);
            SelectedFileTextBox.BorderStyle = BorderStyle.None;
            SelectedFileTextBox.Font = new Font("Microsoft Sans Serif", 11.25F);
            SelectedFileTextBox.ForeColor = Color.White;
            SelectedFileTextBox.Location = new Point(610, 45);
            SelectedFileTextBox.Name = "SelectedFileTextBox";
            SelectedFileTextBox.ReadOnly = true;
            SelectedFileTextBox.Size = new Size(590, 550);
            SelectedFileTextBox.TabIndex = 24;
            SelectedFileTextBox.Text = "";
            // 
            // SearchPanel
            // 
            SearchPanel.BackColor = Color.FromArgb(20, 22, 24);
            SearchPanel.BorderStyle = BorderStyle.FixedSingle;
            SearchPanel.Controls.Add(SearchSecondsLabel);
            SearchPanel.Controls.Add(SearchAutoUpdateCheckBox);
            SearchPanel.Controls.Add(SearchCaseSensitiveCheckBox);
            SearchPanel.Controls.Add(SearchFileCountLabel);
            SearchPanel.Controls.Add(SearchPhraseCountLabel);
            SearchPanel.Controls.Add(SearchButton);
            SearchPanel.Controls.Add(SearchPhraseFileTextBox);
            SearchPanel.Controls.Add(SearchPhraseTextBox);
            SearchPanel.Controls.Add(SearchPhraseFileLabel);
            SearchPanel.Controls.Add(SearchPhraseLabel);
            SearchPanel.Location = new Point(278, 28);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(327, 81);
            SearchPanel.TabIndex = 17;
            // 
            // SearchSecondsLabel
            // 
            SearchSecondsLabel.AutoSize = true;
            SearchSecondsLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchSecondsLabel.ForeColor = Color.FromArgb(220, 230, 240);
            SearchSecondsLabel.Location = new Point(238, 64);
            SearchSecondsLabel.Name = "SearchSecondsLabel";
            SearchSecondsLabel.Size = new Size(88, 13);
            SearchSecondsLabel.TabIndex = 0;
            SearchSecondsLabel.Text = "in 0.000 seconds";
            // 
            // SearchAutoUpdateCheckBox
            // 
            SearchAutoUpdateCheckBox.AutoSize = true;
            SearchAutoUpdateCheckBox.Font = new Font("Microsoft Sans Serif", 8.25F);
            SearchAutoUpdateCheckBox.ForeColor = Color.FromArgb(220, 230, 240);
            SearchAutoUpdateCheckBox.Location = new Point(2, 63);
            SearchAutoUpdateCheckBox.Name = "SearchAutoUpdateCheckBox";
            SearchAutoUpdateCheckBox.Size = new Size(86, 17);
            SearchAutoUpdateCheckBox.TabIndex = 19;
            SearchAutoUpdateCheckBox.Text = "Auto Update";
            SearchAutoUpdateCheckBox.UseVisualStyleBackColor = true;
            SearchAutoUpdateCheckBox.CheckedChanged += SearchAutoUpdateCheckBox_CheckedChanged;
            // 
            // SearchCaseSensitiveCheckBox
            // 
            SearchCaseSensitiveCheckBox.AutoSize = true;
            SearchCaseSensitiveCheckBox.Font = new Font("Microsoft Sans Serif", 8.25F);
            SearchCaseSensitiveCheckBox.ForeColor = Color.FromArgb(220, 230, 240);
            SearchCaseSensitiveCheckBox.Location = new Point(90, 63);
            SearchCaseSensitiveCheckBox.Name = "SearchCaseSensitiveCheckBox";
            SearchCaseSensitiveCheckBox.Size = new Size(96, 17);
            SearchCaseSensitiveCheckBox.TabIndex = 20;
            SearchCaseSensitiveCheckBox.Text = "Case Sensitive";
            SearchCaseSensitiveCheckBox.UseVisualStyleBackColor = true;
            SearchCaseSensitiveCheckBox.CheckedChanged += SearchCaseSensitiveCheckBox_CheckedChanged;
            // 
            // SearchFileCountLabel
            // 
            SearchFileCountLabel.AutoSize = true;
            SearchFileCountLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            SearchFileCountLabel.ForeColor = Color.FromArgb(220, 230, 240);
            SearchFileCountLabel.Location = new Point(147, 48);
            SearchFileCountLabel.Name = "SearchFileCountLabel";
            SearchFileCountLabel.Size = new Size(77, 13);
            SearchFileCountLabel.TabIndex = 0;
            SearchFileCountLabel.Text = "0 files found";
            // 
            // SearchPhraseCountLabel
            // 
            SearchPhraseCountLabel.AutoSize = true;
            SearchPhraseCountLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            SearchPhraseCountLabel.ForeColor = Color.FromArgb(220, 230, 240);
            SearchPhraseCountLabel.Location = new Point(147, 34);
            SearchPhraseCountLabel.Name = "SearchPhraseCountLabel";
            SearchPhraseCountLabel.Size = new Size(98, 13);
            SearchPhraseCountLabel.TabIndex = 0;
            SearchPhraseCountLabel.Text = "0 phrases found";
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.FromArgb(130, 150, 130);
            SearchButton.FlatAppearance.BorderColor = Color.FromArgb(165, 180, 165);
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            SearchButton.ForeColor = Color.Honeydew;
            SearchButton.Location = new Point(3, 33);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(143, 29);
            SearchButton.TabIndex = 21;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchPhraseFileTextBox
            // 
            SearchPhraseFileTextBox.BackColor = Color.FromArgb(30, 32, 34);
            SearchPhraseFileTextBox.BorderStyle = BorderStyle.FixedSingle;
            SearchPhraseFileTextBox.Font = new Font("Microsoft Sans Serif", 8.25F);
            SearchPhraseFileTextBox.ForeColor = Color.FromArgb(200, 245, 220);
            SearchPhraseFileTextBox.Location = new Point(146, 13);
            SearchPhraseFileTextBox.Name = "SearchPhraseFileTextBox";
            SearchPhraseFileTextBox.Size = new Size(176, 20);
            SearchPhraseFileTextBox.TabIndex = 18;
            SearchPhraseFileTextBox.TextChanged += SearchPhraseFileTextBox_TextChanged;
            // 
            // SearchPhraseTextBox
            // 
            SearchPhraseTextBox.BackColor = Color.FromArgb(30, 32, 34);
            SearchPhraseTextBox.BorderStyle = BorderStyle.FixedSingle;
            SearchPhraseTextBox.Font = new Font("Microsoft Sans Serif", 8.25F);
            SearchPhraseTextBox.ForeColor = Color.FromArgb(200, 245, 220);
            SearchPhraseTextBox.Location = new Point(3, 13);
            SearchPhraseTextBox.Name = "SearchPhraseTextBox";
            SearchPhraseTextBox.Size = new Size(143, 20);
            SearchPhraseTextBox.TabIndex = 17;
            SearchPhraseTextBox.TextChanged += SearchPhraseTextBox_TextChanged;
            // 
            // SearchPhraseFileLabel
            // 
            SearchPhraseFileLabel.AutoSize = true;
            SearchPhraseFileLabel.Font = new Font("Microsoft Sans Serif", 6.75F);
            SearchPhraseFileLabel.ForeColor = Color.FromArgb(220, 230, 240);
            SearchPhraseFileLabel.Location = new Point(143, 1);
            SearchPhraseFileLabel.Name = "SearchPhraseFileLabel";
            SearchPhraseFileLabel.Size = new Size(82, 12);
            SearchPhraseFileLabel.TabIndex = 0;
            SearchPhraseFileLabel.Text = "File Search Phrase";
            // 
            // SearchPhraseLabel
            // 
            SearchPhraseLabel.AutoSize = true;
            SearchPhraseLabel.Font = new Font("Microsoft Sans Serif", 6.75F);
            SearchPhraseLabel.ForeColor = Color.FromArgb(220, 230, 240);
            SearchPhraseLabel.Location = new Point(1, 1);
            SearchPhraseLabel.Name = "SearchPhraseLabel";
            SearchPhraseLabel.Size = new Size(65, 12);
            SearchPhraseLabel.TabIndex = 0;
            SearchPhraseLabel.Text = "Search Phrase";
            // 
            // SearchResultsPanel
            // 
            SearchResultsPanel.BackColor = Color.FromArgb(20, 22, 24);
            SearchResultsPanel.BorderStyle = BorderStyle.FixedSingle;
            SearchResultsPanel.Controls.Add(SearchResultsBrowseMediaButton);
            SearchResultsPanel.Controls.Add(SearchResultsOpenMediaButton);
            SearchResultsPanel.Location = new Point(278, 559);
            SearchResultsPanel.Name = "SearchResultsPanel";
            SearchResultsPanel.Size = new Size(327, 36);
            SearchResultsPanel.TabIndex = 22;
            // 
            // SearchResultsBrowseMediaButton
            // 
            SearchResultsBrowseMediaButton.BackColor = Color.FromArgb(120, 120, 145);
            SearchResultsBrowseMediaButton.FlatAppearance.BorderColor = Color.FromArgb(165, 165, 180);
            SearchResultsBrowseMediaButton.FlatStyle = FlatStyle.Flat;
            SearchResultsBrowseMediaButton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            SearchResultsBrowseMediaButton.ForeColor = Color.FromArgb(220, 230, 255);
            SearchResultsBrowseMediaButton.Location = new Point(52, 5);
            SearchResultsBrowseMediaButton.Name = "SearchResultsBrowseMediaButton";
            SearchResultsBrowseMediaButton.Size = new Size(58, 23);
            SearchResultsBrowseMediaButton.TabIndex = 23;
            SearchResultsBrowseMediaButton.Text = "Browse";
            SearchResultsBrowseMediaButton.UseVisualStyleBackColor = false;
            SearchResultsBrowseMediaButton.Click += SearchResultsBrowseMediaButton_Click;
            // 
            // SearchResultsOpenMediaButton
            // 
            SearchResultsOpenMediaButton.BackColor = Color.FromArgb(120, 120, 145);
            SearchResultsOpenMediaButton.FlatAppearance.BorderColor = Color.FromArgb(165, 165, 180);
            SearchResultsOpenMediaButton.FlatStyle = FlatStyle.Flat;
            SearchResultsOpenMediaButton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            SearchResultsOpenMediaButton.ForeColor = Color.FromArgb(220, 230, 255);
            SearchResultsOpenMediaButton.Location = new Point(5, 5);
            SearchResultsOpenMediaButton.Name = "SearchResultsOpenMediaButton";
            SearchResultsOpenMediaButton.Size = new Size(47, 23);
            SearchResultsOpenMediaButton.TabIndex = 22;
            SearchResultsOpenMediaButton.Text = "Open";
            SearchResultsOpenMediaButton.UseVisualStyleBackColor = false;
            SearchResultsOpenMediaButton.Click += SearchResultsOpenMediaButton_Click;
            // 
            // TitlebarPictureBox
            // 
            TitlebarPictureBox.Image = Properties.Resources.logo;
            TitlebarPictureBox.Location = new Point(3, 3);
            TitlebarPictureBox.Name = "TitlebarPictureBox";
            TitlebarPictureBox.Size = new Size(22, 22);
            TitlebarPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            TitlebarPictureBox.TabIndex = 0;
            TitlebarPictureBox.TabStop = false;
            TitlebarPictureBox.MouseDown += TitlebarPictureBox_MouseDown;
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VersionLabel.ForeColor = Color.FromArgb(230, 230, 230);
            VersionLabel.Location = new Point(27, 8);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(83, 13);
            VersionLabel.TabIndex = 0;
            VersionLabel.Text = "Scribe v0.0.0";
            VersionLabel.MouseDown += VersionLabel_MouseDown;
            // 
            // SelectedFilePanel
            // 
            SelectedFilePanel.BackColor = Color.FromArgb(20, 22, 24);
            SelectedFilePanel.BorderStyle = BorderStyle.FixedSingle;
            SelectedFilePanel.Controls.Add(SearchCurrentCountLabel);
            SelectedFilePanel.Location = new Point(610, 28);
            SelectedFilePanel.Name = "SelectedFilePanel";
            SelectedFilePanel.Size = new Size(590, 17);
            SelectedFilePanel.TabIndex = 0;
            // 
            // SearchCurrentCountLabel
            // 
            SearchCurrentCountLabel.AutoSize = true;
            SearchCurrentCountLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            SearchCurrentCountLabel.ForeColor = Color.FromArgb(220, 230, 240);
            SearchCurrentCountLabel.Location = new Point(0, 1);
            SearchCurrentCountLabel.Name = "SearchCurrentCountLabel";
            SearchCurrentCountLabel.Size = new Size(185, 13);
            SearchCurrentCountLabel.TabIndex = 0;
            SearchCurrentCountLabel.Text = "0 phrases found in selected file";
            // 
            // SelectionLabel
            // 
            SelectionLabel.AutoSize = true;
            SelectionLabel.BackColor = Color.FromArgb(10, 12, 14);
            SelectionLabel.Font = new Font("Microsoft Sans Serif", 9.75F);
            SelectionLabel.ForeColor = Color.FromArgb(220, 230, 240);
            SelectionLabel.Location = new Point(1, 498);
            SelectionLabel.Name = "SelectionLabel";
            SelectionLabel.Size = new Size(63, 16);
            SelectionLabel.TabIndex = 0;
            SelectionLabel.Text = "Selection";
            // 
            // MainToolTip
            // 
            MainToolTip.Draw += MainToolTip_Draw;
            // 
            // MainMenuNotifyIcon
            // 
            MainMenuNotifyIcon.BalloonTipText = "Scribe";
            MainMenuNotifyIcon.BalloonTipTitle = "Scribe";
            MainMenuNotifyIcon.Icon = (Icon)resources.GetObject("MainMenuNotifyIcon.Icon");
            MainMenuNotifyIcon.Text = "Scribe";
            MainMenuNotifyIcon.Visible = true;
            MainMenuNotifyIcon.MouseClick += MainMenuNotifyIcon_MouseClick;
            // 
            // MainMenuContextMenuStrip
            // 
            MainMenuContextMenuStrip.BackColor = Color.FromArgb(10, 12, 14);
            MainMenuContextMenuStrip.Items.AddRange(new ToolStripItem[] { ShowToolStripMenuItem, EnableToolStripMenuItem, AbortToolStripMenuItem, ExitToolStripMenuItem });
            MainMenuContextMenuStrip.Name = "MainMenuContextMenuStrip";
            MainMenuContextMenuStrip.RenderMode = ToolStripRenderMode.Professional;
            MainMenuContextMenuStrip.ShowImageMargin = false;
            MainMenuContextMenuStrip.Size = new Size(85, 92);
            MainMenuContextMenuStrip.Opened += MainMenuContextMenuStrip_Opened;
            // 
            // ShowToolStripMenuItem
            // 
            ShowToolStripMenuItem.ForeColor = Color.White;
            ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
            ShowToolStripMenuItem.Size = new Size(84, 22);
            ShowToolStripMenuItem.Text = "Show";
            ShowToolStripMenuItem.Click += ShowToolStripMenuItem_Click;
            // 
            // EnableToolStripMenuItem
            // 
            EnableToolStripMenuItem.ForeColor = Color.White;
            EnableToolStripMenuItem.Name = "EnableToolStripMenuItem";
            EnableToolStripMenuItem.Size = new Size(84, 22);
            EnableToolStripMenuItem.Text = "Enable";
            EnableToolStripMenuItem.Click += EnableToolStripMenuItem_Click;
            // 
            // AbortToolStripMenuItem
            // 
            AbortToolStripMenuItem.ForeColor = Color.White;
            AbortToolStripMenuItem.Name = "AbortToolStripMenuItem";
            AbortToolStripMenuItem.Size = new Size(84, 22);
            AbortToolStripMenuItem.Text = "Abort";
            AbortToolStripMenuItem.Click += AbortToolStripMenuItem_Click;
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.ForeColor = Color.White;
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(84, 22);
            ExitToolStripMenuItem.Text = "Exit";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 6, 7);
            ClientSize = new Size(1200, 600);
            Controls.Add(SelectionLabel);
            Controls.Add(SelectedFilePanel);
            Controls.Add(VersionLabel);
            Controls.Add(TitlebarPictureBox);
            Controls.Add(SearchResultsPanel);
            Controls.Add(SearchPanel);
            Controls.Add(SelectedFileTextBox);
            Controls.Add(SearchResultsListBox);
            Controls.Add(ProcessPanel);
            Controls.Add(SelectionListBox);
            Controls.Add(SelectionPanel);
            Controls.Add(CloseButton);
            Controls.Add(MinimizeButton);
            Controls.Add(TitlebarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenu";
            Text = "Scribe";
            Load += MainMenu_Load;
            SelectionPanel.ResumeLayout(false);
            SelectionPanel.PerformLayout();
            ProcessPanel.ResumeLayout(false);
            ProcessPanel.PerformLayout();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            SearchResultsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TitlebarPictureBox).EndInit();
            SelectedFilePanel.ResumeLayout(false);
            SelectedFilePanel.PerformLayout();
            MainMenuContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TitlebarPanel;
        private Button MinimizeButton;
        private Button CloseButton;
        private Panel SelectionPanel;
        private ListBox SelectionListBox;
        private Panel ProcessPanel;
        private ListBox SearchResultsListBox;
        private RichTextBox SelectedFileTextBox;
        private Panel SearchPanel;
        private Panel SearchResultsPanel;
        private PictureBox TitlebarPictureBox;
        private Label VersionLabel;
        private Button SelectionAddFolderButton;
        private Button SelectionRemoveFolderButton;
        private TextBox SelectionFiletypesTextBox;
        private CheckBox SelectionSubdirectoriesCheckBox;
        private Label SearchPhraseLabel;
        private Label SearchPhraseFileLabel;
        private TextBox SearchPhraseTextBox;
        private TextBox SearchPhraseFileTextBox;
        private Button SearchButton;
        private Label SearchPhraseCountLabel;
        private Label SearchFileCountLabel;
        private CheckBox SearchAutoUpdateCheckBox;
        private CheckBox SearchCaseSensitiveCheckBox;
        private Button SearchResultsOpenMediaButton;
        private Button SearchResultsBrowseMediaButton;
        private Panel SelectedFilePanel;
        private Label SearchCurrentCountLabel;
        private Label SelectionLabel;
        private CheckBox ProcessStartWithWindowsCheckBox;
        private CheckBox ProcessAutoUpdateCheckBox;
        private CheckBox ProcessCudaCheckBox;
        private Button ProcessUpdateButton;
        private Button ProcessAbortButton;
        private Button ProcessCleanButton;
        private CheckBox ProcessDebugCheckBox;
        private ComboBox ProcessModelComboBox;
        private ComboBox ProcessLanguageComboBox;
        private Label ProcessModelLabel;
        private Label ProcessLanguageLabel;
        private Label ProcessMediaBufferLabel;
        private TextBox ProcessMediaBufferTextBox;
        private Label ProcessProgressLabel;
        private Panel ProcessProgressBarPanel;
        private ToolTip MainToolTip;
        private NotifyIcon MainMenuNotifyIcon;
        private ContextMenuStrip MainMenuContextMenuStrip;
        private ToolStripMenuItem ShowToolStripMenuItem;
        private ToolStripMenuItem EnableToolStripMenuItem;
        private ToolStripMenuItem AbortToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private Label SelectionFiletypesLabel;
        private Label SearchSecondsLabel;
    }
}
