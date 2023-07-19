using System;
using System.IO;
using System.Timers;
using System.Drawing;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using IWshRuntimeLibrary;
using File = System.IO.File;
using static Scribe.Data.Constants;
using static Scribe.Data.Structure.ConfigStructure;
using static Scribe.Tools.Forms;
using static Scribe.Tools.Files;
using static Scribe.Tools.Strings;
using static Scribe.Setup.Installer;
using static Scribe.Managers.ConfigManager;

namespace Scribe
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        ConfigBase config = new ConfigBase();

        readonly System.Timers.Timer mediaRefreshTimer = new System.Timers.Timer();
        bool isRunning = false;
        bool willAbort = false;

        private void MainMenu_Load(object sender, EventArgs e)
        {
            ConfigureFFmpegPath();

            Directory.CreateDirectory("Scribe\\config");
            Directory.CreateDirectory("Scribe\\storage\\_queue");

            // read configuration from file if it exists
            if (File.Exists("Scribe\\config\\config.sc"))
                config = ReadConfig();

            if (config.SELECTION_DIRECTORIES != null)
            {
                string[] folders = config.SELECTION_DIRECTORIES.Split('ʃ');
                for (int i = 0; i < folders.Length; i++)
                    SelectionListBox.Items.Add(folders[i]);
            }

            SelectionFileTypeTextBox.Text = config.SELECTION_DIRECTORIES_FILETYPE;
            SelectionEnableSubdirectoriesCheckBox.Checked = config.SELECTION_ENABLE_SUBDIRECTORIES;
            if (SelectionListBox.Items.Count > 0)
                SelectionListBox.SelectedIndex = config.SELECTION_SELECTED_INDEX;

            ProcessEnableAutoUpdateCheckBox.Checked = config.PROCESS_AUTO_UPDATE;
            ProcessEnableStartWithWindowsCheckBox.Checked = config.PROCESS_START_WITH_WINDOWS;
            ProcessEnableOutputCheckBox.Checked = config.PROCESS_DISPLAY_OUTPUT;
            ProcessEnableOutputPauseCheckBox.Checked = config.PROCESS_DISPLAY_OUTPUT_PAUSE;
            ProcessEnableCudaCheckBox.Checked = config.PROCESS_ENABLE_CUDA;
            ProcessModelComboBox.Text = config.PROCESS_MODEL;
            SelectionLabel.Text = "";

            SearchPhraseTextBox.Text = config.SEARCH_PHRASE;
            SearchFileTextBox.Text = config.SEARCH_FILE;
            SearchEnableAutoUpdateSearchCheckBox.Checked = config.SEARCH_ENABLE_AUTO_UPDATE;
            SearchEnableCaseSensitiveCheckBox.Checked = config.SEARCH_ENABLE_CASE_SENSITIVITY;
            if (SearchFilesListBox.Items.Count > 0)
                SearchFilesListBox.SelectedIndex = config.SEARCH_SELECTED_INDEX;

            if (!File.Exists("Scribe\\config\\_base"))
            {
                SelectionFileTypeTextBox.Text = "mp4,mp3";
                SelectionEnableSubdirectoriesCheckBox.Checked = true;
                ProcessEnableCudaCheckBox.Checked = true;
                ProcessModelComboBox.Text = "small";
                SearchEnableAutoUpdateSearchCheckBox.Checked = true;

                File.WriteAllText("Scribe\\config\\_base", "");
            }

            WriteConfig(config);
            CleanFolder("Scribe\\storage");

            TitlebarLabel.Text = "Scribe " + VERSION;

            // configure and start mediaRefreshTimer
            mediaRefreshTimer.Elapsed += new ElapsedEventHandler(MediaRefresh);
            UpdateMediaRefreshTimer(60);

            CustomRenderer renderer = new CustomRenderer();
            MainMenuContextMenuStrip.Renderer = renderer;

            #region loadTooltips
            // bind tooltips
            string[] tooltipMap = {
                "TitlebarLabel", "Running Scribe " + VERSION,
                "TitlebarPictureBox", "Running Scribe " + VERSION,

                "MinimizeButton", "Minimize",
                "CloseButton", "Close",

                "SelectionAddFolderButton", "Add a watch folder",
                "SelectionRemoveFolderButton", "Remove the selected watch folder",
                "SelectionFileTypeTextBox", "File types to scan for",
                "SelectionEnableSubdirectoriesCheckBox", "Enable the scanning of subdirectories",

                "ProcessEnableAutoUpdateCheckBox", "Enable/Disable the automatic scanning/processing of watch folders",
                "ProcessUpdateButton", "Manually scan/process watch folders",
                "ProcessEnableOutputCheckBox", "Display the console while processing",
                "ProcessEnableOutputPauseCheckBox", "Insert a pause command",
                "ProcessEnableCudaCheckBox", "Enable the usage of supported NVIDIA CUDA GPUs",
                "ProcessModelComboBox", "The model for the whisper algorithm",
                "ProcessAbortButton", "Aborts the current process",
                "ProcessCleanStorageButton", "Clean storage files that no longer have a corresponding media file, it also cleans temporary files",
                "ProcessProgressBar", "[0/0  |  0.00%  |  00:00:00]",
                "ProcessProgressLabel", "[0/0  |  0.00%  |  00:00:00]",

                "SearchPhraseTextBox", "Phrase to search for",
                "SearchButton", "Search",
                "SearchEnableAutoUpdateSearchCheckBox", "Enable auto update",
                "SearchEnableCaseSensitiveCheckBox", "Enable case sensitivity",

                "ResultsOpenMediaButton", "Open the selected media",
                "ResultsBrowseMediaButton", "Browse to the selected media in Windows Explorer"
            };

            // load tooltips
            for (int i = 0; i < tooltipMap.Length; i += 2)
                MainToolTip.SetToolTip(Controls.Find(tooltipMap[i], true)[0], tooltipMap[i + 1]);

            // configure tooltip draw
            MainToolTip.AutoPopDelay = 10000;
            MainToolTip.InitialDelay = 500;
            MainToolTip.ReshowDelay = 100;
            MainToolTip.OwnerDraw = true;
            MainToolTip.BackColor = Color.FromArgb(255, 20, 20, 20);
            MainToolTip.ForeColor = Color.FromArgb(255, 220, 220, 220);
            #endregion
        }

        private void MainToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void MediaRefresh(object source, ElapsedEventArgs e)
        {
            if (config.PROCESS_AUTO_UPDATE)
                ProcessMedia();
        }

        private void UpdateMediaRefreshTimer(int time)
        {
            mediaRefreshTimer.Enabled = false;
            mediaRefreshTimer.Interval = time * 1000;
            mediaRefreshTimer.Enabled = true;
        }

        private void ProcessMedia()
        {
            mediaRefreshTimer.Enabled = false;

            if (config.SELECTION_DIRECTORIES == null || willAbort || isRunning)
            {
                mediaRefreshTimer.Enabled = true;
                return;
            }

            Directory.CreateDirectory("Scribe\\storage\\_queue");

            string[] watchDirectories = config.SELECTION_DIRECTORIES.Split('ʃ');
            string[] fileTypes = config.SELECTION_DIRECTORIES_FILETYPE.Split(',');

            List<string> mediaList = new List<string>();
            for (int i = 0; i < watchDirectories.Length; i++)
                for (int j = 0; j < fileTypes.Length; j++)
                    mediaList.AddRange(Directory.GetFiles(watchDirectories[i], "*." + fileTypes[j], config.SELECTION_ENABLE_SUBDIRECTORIES ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));

            foreach (string file in mediaList)
            {
                if (File.Exists("Scribe\\storage\\" + Path.GetFileName(file) + ".scstore"))
                    continue;
                File.WriteAllText("Scribe\\storage\\_queue\\" + Path.GetFileName(file) + ".scqueue", file);
            }

            string[] mediaQueue = Directory.GetFiles("Scribe\\storage\\_queue");

            if (mediaQueue.Length == 0)
            {
                mediaRefreshTimer.Enabled = true;
                return;
            }

            try
            {
                Invoke((MethodInvoker)delegate
                {
                    ProcessProgressBar.Value = 0;
                    ProcessProgressBar.Maximum = mediaQueue.Length;
                    string progressText = "[0/" + mediaQueue.Length + "  |  0.00%  |  00:00:00]";
                    ProcessProgressLabel.Text = progressText;
                    MainToolTip.SetToolTip(ProcessProgressLabel, progressText);
                    MainToolTip.SetToolTip(ProcessProgressBar, progressText);
                    ProcessProgressLabel.ForeColor = Color.FromArgb(255, 245, 75, 75);
                });
            }
            catch { }

            string log = "";
            int totalSeconds = 0;

            for (int i = 0; i < mediaQueue.Length; i++)
            {
                if (willAbort)
                {
                    willAbort = false;
                    return;
                }

                string mediaQueueName = Path.GetFileNameWithoutExtension(mediaQueue[i]);
                string mediaQueueMediaPath = File.ReadAllText(mediaQueue[i]);

                if (!File.Exists(mediaQueueMediaPath) || !File.Exists(mediaQueue[i]))
                    continue;

                isRunning = true;

                try
                {
                    Invoke((MethodInvoker)delegate
                    {
                        string preProgressText = ProcessProgressLabel.Text + "  :  " + mediaQueueName;
                        ProcessProgressLabel.Text = preProgressText;
                        MainToolTip.SetToolTip(ProcessProgressLabel, preProgressText);
                        MainToolTip.SetToolTip(ProcessProgressBar, preProgressText);
                    });
                }
                catch { }

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                string processCommand = "/c title [" + (i + 1) + "/" + mediaQueue.Length + "] & " +
                                        "Scribe\\engine\\redist\\ffmpeg\\ffmpeg\\bin\\ffmpeg.exe -loglevel verbose -y -i \"" + mediaQueueMediaPath + "\" -vn -c:a libmp3lame -b:a 128K \"Scribe\\storage\\" + mediaQueueName + ".mp3\" & " +
                                        "(Scribe\\engine\\base\\Scripts\\whisper.exe \"Scribe\\storage\\" + mediaQueueName + ".mp3\" --device " + (config.PROCESS_ENABLE_CUDA ? "cuda" : "cpu") + " --model " + config.PROCESS_MODEL + " --language en --output_format txt --output_dir \"Scribe\\storage\") > \"Scribe\\storage\\" + mediaQueueName + ".sctemp\" & " +
                                        "del \"Scribe\\storage\\" + mediaQueueName + ".mp3\" /f & " +
                                        "del \"Scribe\\storage\\" + mediaQueueName + ".txt\" /f" +
                                        (config.PROCESS_DISPLAY_OUTPUT_PAUSE ? " & pause" : "");

                ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", processCommand);
                processInfo.CreateNoWindow = !config.PROCESS_DISPLAY_OUTPUT;
                processInfo.UseShellExecute = false;

                Process process = new Process();
                process.StartInfo = processInfo;
                process.Start();
                process.WaitForExit();

                // write store file
                string storeFile = mediaQueueMediaPath + "ʃ\n" + File.ReadAllText("Scribe\\storage\\" + mediaQueueName + ".sctemp");
                File.WriteAllText("Scribe\\storage\\" + mediaQueueName + ".scstore", storeFile);

                // delete temporary files
                File.Delete(mediaQueue[i]);
                File.Delete("Scribe\\storage\\" + mediaQueueName + ".sctemp");

                stopwatch.Stop();

                totalSeconds += stopwatch.Elapsed.Seconds;

                int total = (totalSeconds / (i + 1)) * (mediaQueue.Length - (i + 1));

                int hours = total / 3600;
                int minutes = (total % 3600) / 60;
                int seconds = total % 60;
                string time = $"{hours:D2}:{minutes:D2}:{seconds:D2}";

                string progressText = "[" + (i + 1) + "/" + mediaQueue.Length + "  |  " + (((float)(i + 1) / mediaQueue.Length) * 100).ToString("0.00") + "%  |  " + time + "]";

                DateTime currentDateTime = DateTime.Now;
                string formattedDateTime = currentDateTime.ToString("M/d/yyyy - h:mm tt");

                log += "(" + formattedDateTime + ") " + progressText + "  :  " + mediaQueueName + "\n";

                try
                {
                    Invoke((MethodInvoker)delegate
                    {
                        ProcessProgressBar.Value = i + 1;
                        ProcessProgressLabel.Text = progressText;
                        MainToolTip.SetToolTip(ProcessProgressLabel, progressText);
                        MainToolTip.SetToolTip(ProcessProgressBar, progressText);
                        int r = (int)(245 - (170 * ((float)(i + 1) / mediaQueue.Length)));
                        int g = (int)(75 + (170 * ((float)(i + 1) / mediaQueue.Length)));
                        int b = (int)(75 + (30 * ((float)(i + 1) / mediaQueue.Length)));
                        ProcessProgressLabel.ForeColor = Color.FromArgb(255, r, g, b);
                    });
                }
                catch { }

                isRunning = false;
            }

            int actualDays = totalSeconds / 86400;
            int actualHours = (totalSeconds % 86400) / 3600;
            int actualMinutes = (totalSeconds % 3600) / 60;
            int actualSeconds = totalSeconds % 60;

            log += $"\nTOTAL TIME: {actualDays:D2}:{actualHours:D2}:{actualMinutes:D2}:{actualSeconds:D2}";

            File.WriteAllText("Scribe\\latest.log", log);
        }

        private void UpdateSearch()
        {
            if (SearchPhraseTextBox.Text == "")
            {
                SearchTotalCountLabel.Text = "Total: 0";
                SearchFilesCountLabel.Text = "Files: 0";
                SearchCurrentCountLabel.Text = "Current: 0";

                SearchFilesListBox.Items.Clear();
                return;
            }

            SelectedFileTextBox.Text = "";
            SearchFilesListBox.Items.Clear();

            int phrase_count = 0;
            int file_count = 0;

            int count_index = 0;
            int count_index_break = 100;

            string[] storeList = Directory.GetFiles("Scribe\\storage", "*.scstore");

            for (int i = 0; i < storeList.Length; i++)
            {
                string[] storeFile;
                try
                {
                    storeFile = File.ReadAllText(storeList[i]).Split('ʃ');
                }
                catch { return; }

                var result_phraseSearch = StringContainsSubstring(storeFile[1], SearchPhraseTextBox.Text, config.SEARCH_ENABLE_CASE_SENSITIVITY);
                if (result_phraseSearch.Item1)
                {
                    if (SearchFileTextBox.Text == "")
                    {
                        SearchFilesListBox.Items.Add(Path.GetFileNameWithoutExtension(storeList[i]));
                        file_count++;

                        phrase_count += result_phraseSearch.Item2;
                        count_index++;

                        if (count_index == count_index_break)
                        {
                            SearchTotalCountLabel.Text = "Total: " + phrase_count.ToString();
                            SearchTotalCountLabel.Refresh();

                            SearchFilesCountLabel.Text = "Files: " + file_count.ToString();
                            SearchFilesCountLabel.Refresh();

                            count_index = 0;
                        }

                    }
                    else
                    {
                        var result_fileSearch = StringContainsSubstring(Path.GetFileNameWithoutExtension(storeList[i]), SearchFileTextBox.Text, config.SEARCH_ENABLE_CASE_SENSITIVITY);
                        if (result_fileSearch.Item1)
                        {
                            SearchFilesListBox.Items.Add(Path.GetFileNameWithoutExtension(storeList[i]));
                            file_count++;

                            phrase_count += result_phraseSearch.Item2;
                            count_index++;

                            if (count_index == count_index_break)
                            {
                                SearchTotalCountLabel.Text = "Total: " + phrase_count.ToString();
                                SearchTotalCountLabel.Refresh();

                                SearchFilesCountLabel.Text = "Files: " + file_count.ToString();
                                SearchFilesCountLabel.Refresh();

                                count_index = 0;
                            }
                        }
                    }
                }
            }

            SearchTotalCountLabel.Text = "Total: " + phrase_count.ToString();
            SearchFilesCountLabel.Text = "Files: " + file_count.ToString();

            if (SearchFilesListBox.SelectedItems.Count == 0)
                SearchCurrentCountLabel.Text = "Current: 0";
        }

        private void SelectionAddFolderButton_Click(object sender, EventArgs e)
        {
            // open folder dialog to select a folder
            using (OpenFileDialog selectFolderDialog = new OpenFileDialog())
            {
                selectFolderDialog.Multiselect = false;
                selectFolderDialog.CheckFileExists = false;
                selectFolderDialog.CheckPathExists = true;
                selectFolderDialog.FileName = "Select a folder";
                selectFolderDialog.Filter = "Directories|Folders";
                DialogResult result = selectFolderDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string folderPath = Path.GetDirectoryName(selectFolderDialog.FileName);

                    foreach (string item in SelectionListBox.Items)
                        if (item == folderPath)
                            return;

                    SelectionListBox.Items.Add(folderPath);

                    UpdateWatchFolderConfig();
                }
            }
        }

        private void UpdateWatchFolderConfig()
        {
            if (SelectionListBox.Items.Count == 0)
            {
                config.SELECTION_DIRECTORIES = null;
                return;
            }

            // load folders into string
            string folders = "";
            foreach (string item in SelectionListBox.Items)
                folders += item + 'ʃ';

            // remove last character and save to config memory
            config.SELECTION_DIRECTORIES = folders.Substring(0, folders.Length - 1);
        }

        private void SelectionRemoveFolderButton_Click(object sender, EventArgs e)
        {
            willAbort = true;

            SelectionListBox.Items.Remove(SelectionListBox.SelectedItem);
            if (SelectionListBox.Items.Count > 0)
                SelectionListBox.SelectedIndex = 0;

            UpdateWatchFolderConfig();

            CleanFolder("Scribe\\storage\\_queue");
        }

        private void FileSearchTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            config.SELECTION_DIRECTORIES_FILETYPE = SelectionFileTypeTextBox.Text;
        }

        private void SelectionFileTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            config.SELECTION_DIRECTORIES_FILETYPE = SelectionFileTypeTextBox.Text;
        }

        private void SelectionEnableSubdirectoriesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            config.SELECTION_ENABLE_SUBDIRECTORIES = SelectionEnableSubdirectoriesCheckBox.Checked;
        }

        private void SelectionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectionListBox.SelectedIndex != -1)
                SelectionLabel.Text = Path.GetFileName(SelectionListBox.SelectedItem.ToString());
            else
                SelectionLabel.Text = "";

            config.SELECTION_SELECTED_INDEX = SelectionListBox.SelectedIndex;
        }

        private void ProcessEnableAutoUpdateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ProcessEnableAutoUpdateCheckBox.Checked && !isRunning)
            {
                willAbort = false;
                mediaRefreshTimer.Enabled = true;
            }

            if (ProcessEnableAutoUpdateCheckBox.Checked)
                ProcessEnableAutoUpdateCheckBox.ForeColor = Color.FromArgb(255, 200, 255, 200);
            else
                ProcessEnableAutoUpdateCheckBox.ForeColor = Color.FromArgb(255, 220, 220, 220);

            ProcessUpdateButton.Visible = !ProcessEnableAutoUpdateCheckBox.Checked;

            config.PROCESS_AUTO_UPDATE = ProcessEnableAutoUpdateCheckBox.Checked;
        }

        private void ProcessUpdateButton_Click(object sender, EventArgs e)
        {
            if (!isRunning)
                willAbort = false;

            Task.Run(() => ProcessMedia());
        }

        private void ProcessEnableStartWithWindowsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            config.PROCESS_START_WITH_WINDOWS = ProcessEnableStartWithWindowsCheckBox.Checked;

            if (config.PROCESS_START_WITH_WINDOWS)
            {
                string exe = Assembly.GetEntryAssembly().Location;
                string output = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\Scribe.lnk";

                // create a new shortcut object
                WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(output);

                // set the target path for the shortcut
                shortcut.TargetPath = exe;
                shortcut.WorkingDirectory = Path.GetDirectoryName(exe);

                // save the shortcut
                shortcut.Save();
            }
            else
            {
                string shortcut = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\Scribe.lnk";
                File.Delete(shortcut);
            }
        }

        private void ProcessEnableOutputCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ProcessEnableOutputPauseCheckBox.Checked = ProcessEnableOutputCheckBox.Checked;
            ProcessEnableOutputPauseCheckBox.Visible = ProcessEnableOutputCheckBox.Checked;
            config.PROCESS_DISPLAY_OUTPUT = ProcessEnableOutputCheckBox.Checked;
        }

        private void ProcessEnableOutputPauseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            config.PROCESS_DISPLAY_OUTPUT_PAUSE = ProcessEnableOutputPauseCheckBox.Checked;
        }

        private void ProcessEnableCudaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            config.PROCESS_ENABLE_CUDA = ProcessEnableCudaCheckBox.Checked;
        }

        private void ProcessModelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            config.PROCESS_MODEL = ProcessModelComboBox.Text;
        }

        private void ProcessCleanStorageButton_Click(object sender, EventArgs e)
        {
            ProcessEnableAutoUpdateCheckBox.Checked = false;
            willAbort = true;

            DialogResult prompt = MessageBox.Show("Are you sure?\n\nThis will delete all storage data that does not have a corresponding media file.\nIt will also clean temporary files.", "", MessageBoxButtons.YesNo);
            if (prompt == DialogResult.No)
                return;

            string[] storeFiles = Directory.GetFiles("Scribe\\storage", "*.scstore");
            int count = 0;

            for (int i = 0; i < storeFiles.Length; i++)
            {
                string storeFile = File.ReadAllText(storeFiles[i]);
                string[] mediaPath = storeFile.Split('ʃ');

                if (!File.Exists(mediaPath[0]) || mediaPath.Length != 2)
                {
                    File.Delete(storeFiles[i]);
                    count++;
                }
            }

            int clean_count = CleanFolder("Scribe\\storage\\_queue");
            MessageBox.Show(count + " file(s) has/have been deleted.\n" + clean_count + " temporary file(s) has/have been deleted.");
        }

        private void ProcessAbortButton_Click(object sender, EventArgs e)
        {
            ProcessEnableAutoUpdateCheckBox.Checked = false;
            willAbort = true;
        }

        private void SearchPhraseTextBox_TextChanged(object sender, EventArgs e)
        {
            config.SEARCH_PHRASE = SearchPhraseTextBox.Text;

            if (config.SEARCH_ENABLE_AUTO_UPDATE)
                UpdateSearch();
        }

        private void SearchFileTextBox_TextChanged(object sender, EventArgs e)
        {
            config.SEARCH_FILE = SearchFileTextBox.Text;

            if (config.SEARCH_ENABLE_AUTO_UPDATE)
                UpdateSearch();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            UpdateSearch();
        }

        private void ResultsOpenMediaButton_Click(object sender, EventArgs e)
        {
            OpenMediaLocation(false);
        }

        private void ResultsBrowseMediaButton_Click(object sender, EventArgs e)
        {
            OpenMediaLocation(true);
        }

        private void OpenMediaLocation(bool select)
        {
            if (SearchFilesListBox.SelectedIndex == -1)
                return;
            string[] storeFile = File.ReadAllText("Scribe\\storage\\" + SearchFilesListBox.SelectedItem + ".scstore").Split('ʃ');
            try
            {
                if (select)
                    Process.Start("explorer.exe", "/select, " + storeFile[0]);
                else
                    Process.Start(storeFile[0]);
            }
            catch { }
        }

        private void SearchEnableAutoUpdateSearchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            config.SEARCH_ENABLE_AUTO_UPDATE = SearchEnableAutoUpdateSearchCheckBox.Checked;

            if (SearchEnableAutoUpdateSearchCheckBox.Checked)
                UpdateSearch();
        }

        private void SearchEnableCaseSensitiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            config.SEARCH_ENABLE_CASE_SENSITIVITY = SearchEnableCaseSensitiveCheckBox.Checked;

            if (SearchEnableAutoUpdateSearchCheckBox.Checked)
                UpdateSearch();
        }

        private void SearchFilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchFilesListBox.SelectedIndex == -1)
                return;

            string[] storeFile = File.ReadAllText("Scribe\\storage\\" + SearchFilesListBox.SelectedItem + ".scstore").Split('ʃ');
            SelectedFileTextBox.Text = storeFile[1];

            string searchText = SearchPhraseTextBox.Text;
            Color highlightColor = Color.FromArgb(255, 255, 255, 100);
            int count = HighlightPhrase(SelectedFileTextBox, searchText, highlightColor, config.SEARCH_ENABLE_CASE_SENSITIVITY);

            SearchCurrentCountLabel.Text = "Current: " + count.ToString();

            config.SEARCH_SELECTED_INDEX = SearchFilesListBox.SelectedIndex;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            WriteConfig(config);
            Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            MainMenuNotifyIcon.Visible = true;
        }

        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void EnableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EnableToolStripMenuItem.Text == "Enable")
            {
                EnableToolStripMenuItem.Text = "Disable";
                config.PROCESS_AUTO_UPDATE = true;
            }
            else
            {
                EnableToolStripMenuItem.Text = "Enable";
                config.PROCESS_AUTO_UPDATE = false;
            }
        }

        private void AbortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            willAbort = true;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainMenuContextMenuStrip_Opened(object sender, EventArgs e)
        {
            EnableToolStripMenuItem.Text = config.PROCESS_AUTO_UPDATE ? "Disable" : "Enable";
        }

        private void ShowForm()
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            MainMenuNotifyIcon.Visible = false;

            ProcessEnableAutoUpdateCheckBox.Checked = config.PROCESS_AUTO_UPDATE;
        }

        private void SelectionListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawListBox(SelectionListBox, e, Color.FromArgb(255, 120, 120, 135));
        }

        private void SearchFilesListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawListBox(SearchFilesListBox, e, Color.FromArgb(255, 120, 135, 120));
        }

        private void TitlebarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(Handle, e);
        }

        private void TitlebarPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(Handle, e);
        }

        private void VersionLabel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(Handle, e);
        }

        private void MainMenuNotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MainMenuContextMenuStrip.Show(Cursor.Position);
                return;
            }

            ShowForm();
        }
    }
}