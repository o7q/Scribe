using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;

using File = System.IO.File;
using MethodInvoker = System.Windows.Forms.MethodInvoker;

using IWshRuntimeLibrary;

using Scribe.Data.Config;
using Scribe.Media;
using static Scribe.Global;
using static Scribe.Data.Config.ConfigManager;
using static Scribe.Tools.Forms;
using static Scribe.Tools.Files;
using static Scribe.Tools.Strings;

namespace Scribe
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        ConfigBase config = new ConfigBase();

        private readonly System.Timers.Timer mediaRefreshTimer = new System.Timers.Timer();
        private bool isRunning = false;
        private bool willAbort = false;

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("Scribe\\config");
            Directory.CreateDirectory("Scribe\\storage");
            Directory.CreateDirectory("Scribe\\logs");

            // read configuration from file if it exists
            if (File.Exists("Scribe\\config\\config.cfg"))
            {
                config = ReadConfig();
            }

            if (File.Exists("Scribe\\engine\\python\\.scribe_is_gpu"))
            {
                ProcessCudaCheckBox.Enabled = true;
            }

            if (config.SELECTION_DIRECTORIES != null)
            {
                string[] folders = config.SELECTION_DIRECTORIES.Split('|');
                for (int i = 0; i < folders.Length; i++)
                {
                    string directory = folders[i];

                    if (!String.IsNullOrEmpty(directory))
                    {
                        SelectionListBox.Items.Add(folders[i]);
                    }
                }
            }

            SelectionFiletypesTextBox.Text = config.SELECTION_DIRECTORIES_FILETYPE;
            SelectionSubdirectoriesCheckBox.Checked = config.SELECTION_SUBDIRECTORIES_ENABLE;
            if (SelectionListBox.Items.Count > 0)
            {
                SelectionListBox.SelectedIndex = config.SELECTION_SELECTED_INDEX;
            }

            ProcessAutoUpdateCheckBox.Checked = config.PROCESS_AUTO_UPDATE_ENABLE;
            ProcessStartWithWindowsCheckBox.Checked = config.PROCESS_START_WITH_WINDOWS_ENABLE;
            ProcessDebugCheckBox.Checked = config.PROCESS_DEBUG_ENABLE;
            ProcessCudaCheckBox.Checked = config.PROCESS_CUDA_ENABLE;
            ProcessLanguageComboBox.Text = config.PROCESS_LANGUAGE;
            ProcessModelComboBox.Text = config.PROCESS_MODEL;
            ProcessMediaBufferTextBox.Text = config.PROCESS_BUFFER_SIZE.ToString();
            SelectionLabel.Text = "";

            SearchPhraseTextBox.Text = config.SEARCH_PHRASE;
            SearchPhraseFileTextBox.Text = config.SEARCH_FILE;
            SearchAutoUpdateCheckBox.Checked = config.SEARCH_AUTO_UPDATE_ENABLE;
            SearchCaseSensitiveCheckBox.Checked = config.SEARCH_CASE_SENSITIVE_ENABLE;

            if (!File.Exists("Scribe\\config\\config.cfg"))
            {
                if (File.Exists("Scribe\\engine\\python\\.scribe_is_gpu"))
                {
                    ProcessCudaCheckBox.Checked = true;
                }

                SelectionFiletypesTextBox.Text = "mp4,mp3";
                SelectionSubdirectoriesCheckBox.Checked = true;
                ProcessLanguageComboBox.Text = "English";
                ProcessModelComboBox.Text = "small";
                ProcessMediaBufferTextBox.Text = "20";
                SearchAutoUpdateCheckBox.Checked = true;
            }

            WriteConfig(config);

            VersionLabel.Text = "Scribe " + VERSION;

            // configure and start mediaRefreshTimer
            mediaRefreshTimer.Elapsed += new ElapsedEventHandler(MediaRefresh);
            mediaRefreshTimer.Interval = 60 * 1000;
            mediaRefreshTimer.Enabled = true;

            CustomRenderer renderer = new CustomRenderer();
            MainMenuContextMenuStrip.Renderer = renderer;

            #region loadTooltips

            // bind tooltips
            string[] tooltipMap = [
                "VersionLabel", "Running Scribe " + VERSION,
                "TitlebarPictureBox", "Running Scribe " + VERSION,

                "MinimizeButton", "Minimize",
                "CloseButton", "Close",

                "SelectionAddFolderButton", "Add a watch folder",
                "SelectionRemoveFolderButton", "Remove the selected watch folder",
                "SelectionFiletypesTextBox", "Filetypes to scan for",
                "SelectionSubdirectoriesCheckBox", "Enable the scanning of subdirectories",

                "ProcessAutoUpdateCheckBox", "Enable/Disable the automatic scanning/processing of watch folders",
                "ProcessUpdateButton", "Manually scan/process watch folders",
                "ProcessDebugCheckBox", "Enable debug/verbose mode, this will display all intermediate processing steps",
                "ProcessCudaCheckBox", "Enable the usage of supported NVIDIA CUDA GPUs",
                "ProcessLanguageComboBox", "Language for the whisper algorithm",
                "ProcessModelComboBox", "The model for the whisper algorithm",
                "ProcessMediaBufferTextBox", "The amount of media files to buffer before finalizing",
                "ProcessAbortButton", "Aborts the current process",
                "ProcessCleanButton", "Clean storage files that no longer have a corresponding media file, it also cleans temporary files",

                "SearchPhraseTextBox", "Phrase to search for",
                "SearchButton", "Search",
                "SearchAutoUpdateCheckBox", "Enable auto update",
                "SearchCaseSensitiveCheckBox", "Enable case sensitivity",

                "SearchResultsOpenMediaButton", "Open the selected media",
                "SearchResultsBrowseMediaButton", "Browse to the selected media in Windows Explorer"
            ];

            // load tooltips
            for (int i = 0; i < tooltipMap.Length; i += 2)
            {
                MainToolTip.SetToolTip(Controls.Find(tooltipMap[i], true)[0], tooltipMap[i + 1]);
            }

            // configure tooltip draw
            MainToolTip.AutoPopDelay = 10000;
            MainToolTip.InitialDelay = 500;
            MainToolTip.ReshowDelay = 100;
            MainToolTip.OwnerDraw = true;
            MainToolTip.BackColor = Color.FromArgb(255, 20, 22, 24);
            MainToolTip.ForeColor = Color.FromArgb(255, 220, 230, 240);
            #endregion
        }

        private void MainToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void MediaRefresh(object? source, ElapsedEventArgs e)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (config.PROCESS_AUTO_UPDATE_ENABLE)
            {
                ProcessMedia(true);
            }
        }

        private void ProcessUpdateButton_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                willAbort = false;

                ProcessProgressLabel.Text = "Initializing...";
                ProcessProgressLabel.ForeColor = Color.FromArgb(255, 140, 140, 140);
            }

            Task.Run(() => ProcessMedia(false));
        }

        private void ProcessAbortButton_Click(object sender, EventArgs e)
        {
            AbortProcess();
        }

        private void AbortProcess()
        {
            ProcessAutoUpdateCheckBox.Checked = false;
            willAbort = true;

            if (isRunning)
            {
                ProcessProgressLabel.Text = "Aborting... (finalizing media buffer)";
            }
        }

        private void ProcessCleanButton_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                DialogResult abortPrompt = MessageBox.Show("A process is currently running.\n\nYou must abort it now before cleaning.\nDo you want to continue?", "", MessageBoxButtons.YesNo);
                if (abortPrompt == DialogResult.Yes)
                {
                    AbortProcess();
                }
                return;
            }

            DialogResult cleanPrompt = MessageBox.Show("Are you sure you want to clean all files?\n\nThis will delete all storage data that does not have a corresponding media file.\nIt will also clean temporary files.", "", MessageBoxButtons.YesNo);
            if (cleanPrompt == DialogResult.No)
            {
                return;
            }

            string[] storageFiles = Directory.GetFiles("Scribe\\storage", "*.scstore");
            int storageClean = 0;

            for (int i = 0; i < storageFiles.Length; i++)
            {
                string storeFile = File.ReadAllText(storageFiles[i]);
                string[] mediaPath = storeFile.Split('\n', 2, StringSplitOptions.None);

                if (!File.Exists(mediaPath[0]) || mediaPath.Length != 2)
                {
                    File.Delete(storageFiles[i]);
                    storageClean++;
                }
            }

            int tempClean = CleanFiles("Scribe\\storage\\_temp");
            int unknownClean = CleanFiles("Scribe\\storage");
            MessageBox.Show(
                $"{storageClean} storage file{Pluralize(storageClean)} {PluralizeTense(storageClean)} been deleted.\n" +
                $"{tempClean} temporary file{Pluralize(tempClean)} {PluralizeTense(tempClean)} been deleted.\n" +
                $"{unknownClean} unknown file{Pluralize(unknownClean)} {PluralizeTense(unknownClean)} been deleted.\n");
        }

        private void ProcessMedia(bool wasAutoStart)
        {
            // if auto start isnt enabled, and `ProcessMedia` was called using an auto start, abort immediately
            if (!config.PROCESS_AUTO_UPDATE_ENABLE && wasAutoStart)
            {
                return;
            }

            // if there are no selection directories, or the process was the set to abort, or it is already running, abort immediately
            if (String.IsNullOrEmpty(config.SELECTION_DIRECTORIES) || willAbort || isRunning)
            {
                return;
            }

            mediaRefreshTimer.Enabled = false;

            Directory.CreateDirectory("Scribe\\storage\\_temp");

            string[] watchDirectories = config.SELECTION_DIRECTORIES.Split('|');
            string[] fileTypes = config.SELECTION_DIRECTORIES_FILETYPE.Split(',');

            List<string> watchListMedia = new List<string>();
            for (int i = 0; i < watchDirectories.Length; i++)
            {
                for (int j = 0; j < fileTypes.Length; j++)
                {
                    string[] watchDirectoryFiles = Directory.GetFiles(
                        watchDirectories[i],
                        $"*.{fileTypes[j]}",
                        config.SELECTION_SUBDIRECTORIES_ENABLE ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly
                    );
                    watchListMedia.AddRange(watchDirectoryFiles);
                }
            }

            List<string> storeFiles = new List<string>();
            foreach (string storeFile in Directory.GetFiles("Scribe\\storage"))
            {
                storeFiles.Add(File.ReadAllText(storeFile).Split('\n', 2, StringSplitOptions.None)[0]);
            }

            string[] mediaList = watchListMedia.Except(storeFiles).ToArray();
            int mediaCount = mediaList.Length;

            try
            {
                Invoke((MethodInvoker)delegate
                {
                    ProcessProgressLabel.Text = "[0/0  |  0.00%  |  00:00:00]";
                    ProcessProgressLabel.ForeColor = Color.FromArgb(255, 75, 245, 105);
                });
            }
            catch { }

            // abort if no media was found
            if (mediaCount == 0)
            {
                mediaRefreshTimer.Enabled = true;
                return;
            }

            try
            {
                Invoke((MethodInvoker)delegate
                {
                    ProcessProgressBarPanel.Width = 0;
                    string progressText = $"[0/{mediaCount}  |  0.00%  |  00:00:00]";
                    ProcessProgressLabel.Text = progressText;
                    ProcessProgressLabel.ForeColor = Color.FromArgb(255, 245, 75, 75);
                });
            }
            catch { }

            string log = "";

            int index = 0;
            float totalSeconds = 0;

            while (index < mediaCount)
            {
                isRunning = true;

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                if (willAbort)
                {
                    willAbort = false;

                    try
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            ProcessProgressLabel.Text = "Aborted.";
                        });
                    }
                    catch { }

                    break;
                }

                int bufferSize = config.PROCESS_BUFFER_SIZE;
                int indexDifference = mediaCount - index;

                // dynamically change the size of `bufferSize`, this is to ensure the buffer does not overflow past the mediaCount
                if (indexDifference < bufferSize)
                {
                    bufferSize -= bufferSize - indexDifference;
                }

                MediaProcessor mp = new MediaProcessor(ref mediaList, index, bufferSize, ref config);
                mp.Start();

                stopwatch.Stop();

                totalSeconds += (float)(stopwatch.Elapsed.TotalMilliseconds / 1000);

                float averageSeconds = (bufferSize * totalSeconds) / (index + bufferSize);
                float remainingSeconds = (averageSeconds * (mediaCount - index - bufferSize)) / bufferSize;

                int hours = (int)(remainingSeconds / 3600);
                int minutes = (int)((remainingSeconds % 3600) / 60);
                int seconds = (int)(remainingSeconds % 60);
                string time = $"{hours:D2}:{minutes:D2}:{seconds:D2}";

                string progressText = $"[{index + bufferSize}/{mediaCount}  |  {(((index + bufferSize) / (float)mediaCount) * 100).ToString("0.00")}%  |  {time}]";

                DateTime currentDateTime = DateTime.Now;
                string formattedDateTime = currentDateTime.ToString("M/d/yyyy - h:mm tt");

                log += "(" + formattedDateTime + ") " + progressText + "\n";

                try
                {
                    Invoke((MethodInvoker)delegate
                    {
                        // initial -> red: 245, 75, 75
                        // final -> green: 75, 245, 105
                        ProcessProgressBarPanel.Width = (int)(272 * ((index + bufferSize) / (float)mediaCount));
                        ProcessProgressLabel.Text = progressText;
                        int r = (int)(245 - (170 * ((index + bufferSize) / (float)mediaCount)));
                        int g = (int)(75 + (170 * ((index + bufferSize) / (float)mediaCount)));
                        int b = (int)(75 + (30 * ((index + bufferSize) / (float)mediaCount)));
                        Color progressColor = Color.FromArgb(255, r, g, b);
                        ProcessProgressLabel.ForeColor = progressColor;
                        ProcessProgressBarPanel.BackColor = progressColor;
                    });
                }
                catch { }

                index += bufferSize;
            }

            isRunning = false;

            int actualDays = (int)totalSeconds / 86400;
            int actualHours = ((int)totalSeconds % 86400) / 3600;
            int actualMinutes = ((int)totalSeconds % 3600) / 60;
            int actualSeconds = (int)totalSeconds % 60;

            log += $"\nTOTAL TIME: {actualDays:D2}:{actualHours:D2}:{actualMinutes:D2}:{actualSeconds:D2}";

            CleanFiles("Scribe\\storage\\_temp");

            Directory.CreateDirectory("Scribe\\logs");
            File.WriteAllText($"Scribe\\logs\\{DateTime.Now.ToString("M-d-yyyy_HH-mm-ss")}.log", log);

            mediaRefreshTimer.Enabled = true;
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
                    string folderPath = Path.GetDirectoryName(selectFolderDialog.FileName) ?? "null";

                    foreach (string item in SelectionListBox.Items)
                    {
                        if (item == folderPath)
                        {
                            return;
                        }
                    }

                    SelectionListBox.Items.Add(folderPath);

                    UpdateWatchFolderConfig();
                }
            }
        }

        private void SelectionRemoveFolderButton_Click(object sender, EventArgs e)
        {
            willAbort = true;

            if (SelectionListBox.SelectedItem != null)
            {
                SelectionListBox.Items.Remove(SelectionListBox.SelectedItem);
            }

            if (SelectionListBox.Items.Count > 0)
            {
                SelectionListBox.SelectedIndex = 0;
            }

            UpdateWatchFolderConfig();
        }

        private void SelectionFiletypesTextBox_TextChanged(object sender, EventArgs e)
        {
            config.SELECTION_DIRECTORIES_FILETYPE = SelectionFiletypesTextBox.Text;
        }

        private void SelectionSubdirectoriesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            config.SELECTION_SUBDIRECTORIES_ENABLE = SelectionSubdirectoriesCheckBox.Checked;
        }

        private void SelectionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectionListBox.SelectedIndex != -1)
            {
                SelectionLabel.Text = Path.GetFileName(SelectionListBox.SelectedItem?.ToString() ?? "");
            }
            else
            {
                SelectionLabel.Text = "";
            }

            config.SELECTION_SELECTED_INDEX = SelectionListBox.SelectedIndex;
        }

        private void UpdateWatchFolderConfig()
        {
            if (SelectionListBox.Items.Count == 0)
            {
                config.SELECTION_DIRECTORIES = "";
                return;
            }

            // load folders into string
            StringBuilder sb = new StringBuilder();
            foreach (string item in SelectionListBox.Items)
            {
                sb.Append(item).Append('|');
            }

            sb.Length--;

            config.SELECTION_DIRECTORIES = sb.ToString();
        }

        private void SearchPhraseTextBox_TextChanged(object sender, EventArgs e)
        {
            config.SEARCH_PHRASE = SearchPhraseTextBox.Text;

            if (config.SEARCH_AUTO_UPDATE_ENABLE)
            {
                UpdateSearch();
            }
        }

        private void SearchPhraseFileTextBox_TextChanged(object sender, EventArgs e)
        {
            config.SEARCH_FILE = SearchPhraseFileTextBox.Text;

            if (config.SEARCH_AUTO_UPDATE_ENABLE)
            {
                UpdateSearch();
            }
        }

        private void SearchAutoUpdateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            config.SEARCH_AUTO_UPDATE_ENABLE = SearchAutoUpdateCheckBox.Checked;

            if (SearchAutoUpdateCheckBox.Checked)
            {
                UpdateSearch();
            }
        }

        private void SearchCaseSensitiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            config.SEARCH_CASE_SENSITIVE_ENABLE = SearchCaseSensitiveCheckBox.Checked;

            if (SearchAutoUpdateCheckBox.Checked)
            {
                UpdateSearch();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            UpdateSearch();
        }

        private void UpdateSearch()
        {
            if (SearchPhraseTextBox.Text == "")
            {
                SearchPhraseCountLabel.Text = "0 phrases found";
                SearchFileCountLabel.Text = "0 files found";
                SearchCurrentCountLabel.Text = "0 phrases found in selected file";

                SearchResultsListBox.Items.Clear();
                return;
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            SelectedFileTextBox.Text = "";
            SearchResultsListBox.Items.Clear();

            int phrase_count = 0;
            int file_count = 0;

            int count_index = 0;
            int count_index_break = 1000;

            string[] storeList = Directory.GetFiles("Scribe\\storage", "*.scstore");

            string searchPhrase = SearchPhraseTextBox.Text;
            string searchFile = SearchPhraseFileTextBox.Text;
            bool caseSensitive = config.SEARCH_CASE_SENSITIVE_ENABLE;

            List<string> items = new List<string>();

            for (int i = 0; i < storeList.Length; i++)
            {
                string[] storeFile = File.ReadAllText(storeList[i]).Split('\n', 2, StringSplitOptions.None);

                string fileName = Path.GetFileNameWithoutExtension(storeList[i]);

                int substringCount = StringContainsSubstring(storeFile[1], searchPhrase, caseSensitive);
                if (substringCount > 0)
                {
                    if (searchFile == "")
                    {
                        items.Add(fileName);
                        file_count++;

                        phrase_count += substringCount;
                        count_index++;

                        if (count_index == count_index_break)
                        {
                            UpdateSearchLabels(phrase_count, file_count);
                            count_index = 0;
                        }
                    }
                    else
                    {
                        int fileSubstringCount = StringContainsSubstring(fileName, searchFile, config.SEARCH_CASE_SENSITIVE_ENABLE);
                        if (fileSubstringCount > 0)
                        {
                            items.Add(fileName);
                            file_count++;

                            phrase_count += fileSubstringCount;
                            count_index++;

                            if (count_index == count_index_break)
                            {
                                UpdateSearchLabels(phrase_count, file_count);
                                count_index = 0;
                            }
                        }
                    }
                }
            }

            UpdateSearchLabels(phrase_count, file_count);

            SearchResultsListBox.Items.AddRange(items.ToArray());

            if (SearchResultsListBox.SelectedItems.Count == 0)
            {
                SearchCurrentCountLabel.Text = "0 phrases found in selected file";
            }

            stopwatch.Stop();
            
            SearchSecondsLabel.Text = $"in {(stopwatch.Elapsed.TotalMilliseconds / 1000).ToString("F3")} seconds";
            SearchSecondsLabel.Location = new Point(238 - (SearchSecondsLabel.Width - 88), SearchSecondsLabel.Location.Y);
        }

        private void UpdateSearchLabels(int phrase_count, int file_count)
        {
            SearchPhraseCountLabel.Text = $"{phrase_count} phrase{Pluralize(phrase_count)} found";
            SearchPhraseCountLabel.Refresh();

            SearchFileCountLabel.Text = $"{file_count} file{Pluralize(file_count)} found";
            SearchFileCountLabel.Refresh();
        }

        private void SearchResultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchResultsListBox.SelectedIndex == -1)
            {
                return;
            }

            string[] storeFile = File.ReadAllText($"Scribe\\storage\\{SearchResultsListBox.SelectedItem}.scstore").Split('\n', 2, StringSplitOptions.None);
            SelectedFileTextBox.Text = storeFile[1];

            string searchText = SearchPhraseTextBox.Text;
            Color highlightColor = Color.FromArgb(255, 255, 255, 100);
            int count = HighlightPhrase(SelectedFileTextBox, searchText, highlightColor, config.SEARCH_CASE_SENSITIVE_ENABLE);

            SearchCurrentCountLabel.Text = $"{count} phrase{Pluralize(count)} found in selected file";
        }

        private void SearchResultsListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                File.Delete($"Scribe\\storage\\{SearchResultsListBox.SelectedItem}.scstore");

                if (SearchResultsListBox.SelectedItem != null)
                {
                    SearchResultsListBox.Items.Remove(SearchResultsListBox.SelectedItem);
                }

                SearchResultsListBox.SelectedIndex = 0;
            }
        }

        private void SearchResultsOpenMediaButton_Click(object sender, EventArgs e)
        {
            OpenMediaLocation(false);
        }

        private void SearchResultsBrowseMediaButton_Click(object sender, EventArgs e)
        {
            OpenMediaLocation(true);
        }

        private void OpenMediaLocation(bool onlySelect)
        {
            if (SearchResultsListBox.SelectedIndex == -1)
            {
                return;
            }
            string[] storeFile = File.ReadAllText($"Scribe\\storage\\{SearchResultsListBox.SelectedItem}.scstore").Split('\n', 2, StringSplitOptions.None);
            try
            {
                if (onlySelect)
                {
                    Process.Start("explorer", "/select, " + storeFile[0]);
                }
                else
                {
                    Process.Start("explorer", storeFile[0]);
                }
            }
            catch { }
        }

        private void ProcessAutoUpdateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ProcessAutoUpdateCheckBox.Checked && !isRunning)
            {
                willAbort = false;
                mediaRefreshTimer.Enabled = true;
            }

            if (ProcessAutoUpdateCheckBox.Checked)
            {
                ProcessAutoUpdateCheckBox.ForeColor = Color.FromArgb(255, 200, 245, 220);
            }
            else
            {
                ProcessAutoUpdateCheckBox.ForeColor = Color.FromArgb(255, 220, 220, 220);
            }

            ProcessUpdateButton.Enabled = !ProcessAutoUpdateCheckBox.Checked;

            config.PROCESS_AUTO_UPDATE_ENABLE = ProcessAutoUpdateCheckBox.Checked;
        }

        private void ProcessStartWithWindowsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            config.PROCESS_START_WITH_WINDOWS_ENABLE = ProcessStartWithWindowsCheckBox.Checked;

            if (config.PROCESS_START_WITH_WINDOWS_ENABLE)
            {
                string exe = Process.GetCurrentProcess().MainModule?.FileName ?? "";
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

        private void ProcessCudaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            config.PROCESS_CUDA_ENABLE = ProcessCudaCheckBox.Checked;
        }

        private void ProcessModelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            config.PROCESS_MODEL = ProcessModelComboBox.Text;
        }

        private void ProcessLanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            config.PROCESS_LANGUAGE = ProcessLanguageComboBox.Text;
        }

        private void ProcessMediaBufferTextBox_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(ProcessMediaBufferTextBox.Text, out int parsedBufferSize);
            config.PROCESS_BUFFER_SIZE = parsedBufferSize > 0 ? parsedBufferSize : 1;
        }

        private void ProcessDebugCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            config.PROCESS_DEBUG_ENABLE = ProcessDebugCheckBox.Checked;
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
                config.PROCESS_AUTO_UPDATE_ENABLE = true;
            }
            else
            {
                EnableToolStripMenuItem.Text = "Enable";
                config.PROCESS_AUTO_UPDATE_ENABLE = false;
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
            EnableToolStripMenuItem.Text = config.PROCESS_AUTO_UPDATE_ENABLE ? "Disable" : "Enable";
        }

        private void ShowForm()
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            MainMenuNotifyIcon.Visible = false;

            ProcessAutoUpdateCheckBox.Checked = config.PROCESS_AUTO_UPDATE_ENABLE;
        }

        private void SelectionListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawListBox(SelectionListBox, e, Color.FromArgb(255, 120, 120, 135));
        }

        private void SearchResultsListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawListBox(SearchResultsListBox, e, Color.FromArgb(255, 120, 135, 120));
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