using System.IO;
using System.Text;
using System.Windows.Forms;

using Scribe.Data.Config;
using static Scribe.Tools.Files;
using static Scribe.Tools.Shell;
using static Scribe.Tools.Subtitle;

namespace Scribe.Media
{
    public class MediaProcessor
    {
        private readonly string[] mediaList;
        private readonly int index = 0;
        private readonly int bufferSize = 0;
        private ConfigBase config;

        public MediaProcessor(ref string[] mediaList, int index, int bufferSize, ref ConfigBase config)
        {
            this.mediaList = mediaList;
            this.index = index;
            this.bufferSize = bufferSize;
            this.config = config;
        }

        public void Start()
        {
            CleanFiles("Scribe\\storage\\_temp");

            int mediaCount = mediaList.Length;

            bool isDebug = config.PROCESS_DEBUG_ENABLE;
            bool isCuda = config.PROCESS_CUDA_ENABLE;
            string model = config.PROCESS_MODEL;
            string language = config.PROCESS_LANGUAGE;

            StringBuilder wavSb = new StringBuilder();
            StringBuilder srtSb = new StringBuilder();
            string[] srtFiles = new string[bufferSize];
            string[] wavFiles = new string[bufferSize];
            string[] mediaQueueNames = new string[bufferSize];
            string[] mediaQueueMediaPaths = new string[bufferSize];

            for (int i = 0; i < bufferSize; i++)
            {
                int chunkIndex = index + i;

                string mediaQueueNameInitial = Path.GetFileName(mediaList[chunkIndex]);
                string mediaQueueName = GenerateFilename("Scribe\\storage\\_temp\\", mediaQueueNameInitial, ".wav");
                string mediaQueuePath = mediaList[chunkIndex];

                if (!File.Exists(mediaQueuePath))
                {
                    continue;
                }

                string ffmpegProcessCommand =
                    $"/c title [{index}/{mediaCount} - BufferSize: {bufferSize}] & " +
                    $"ffmpeg -loglevel verbose -y -i \"{mediaQueuePath}\" \"Scribe\\storage\\_temp\\{mediaQueueName}.wav\"" +
                    (isDebug ? " & pause" : "");

                StartNoOverheadProcess(ffmpegProcessCommand, isDebug);

                wavSb.Append($"\"Scribe\\storage\\_temp\\{mediaQueueName}.wav\" ");
                srtSb.Append($"\"Scribe\\storage\\_temp\\{mediaQueueName}.srt\" ");
                wavFiles[i] = $"Scribe\\storage\\_temp\\{mediaQueueName}.wav";
                srtFiles[i] = $"Scribe\\storage\\_temp\\{mediaQueueName}.srt";
                mediaQueueNames[i] = mediaQueueName;
                mediaQueueMediaPaths[i] = mediaQueuePath;
            }

            wavSb.Length--;
            srtSb.Length--;

            string wavFilesPack = wavSb.ToString();
            string srtFilesPack = srtSb.ToString();

            string whisperProcessCommand =
                $"/c title [{index}/{mediaCount} - BufferSize: {bufferSize}] & " +
                $"Scribe\\engine\\python\\Scripts\\activate & " +
                $"stable-ts {wavFilesPack} --device {(isCuda ? "cuda" : "cpu")} --model {model} --language {language} --word_level false --verbose {(isDebug ? "2" : "0")} --overwrite -o {srtFilesPack}" +
                (isDebug ? " & pause" : "");

            if (isDebug)
            {
                MessageBox.Show($"Whisper Command Length: {whisperProcessCommand.Length}/8191");
            }

            StartNoOverheadProcess(whisperProcessCommand, isDebug);

            for (int i = 0; i < bufferSize; i++)
            {
                string storeFile;
                if (File.Exists(wavFiles[i]) && File.Exists(srtFiles[i]))
                {
                    storeFile = $"{mediaQueueMediaPaths[i]}\n{FormatSubRip(File.ReadAllText(srtFiles[i]))}";
                }
                else
                {
                    storeFile = $"{mediaQueueMediaPaths[i]}\n";
                }

                string mediaQueueName = GenerateFilename("Scribe\\storage\\", mediaQueueNames[i], ".scstore");
                File.WriteAllText($"Scribe\\storage\\{mediaQueueName}.scstore", storeFile);
            }
        }

        private string GenerateFilename(string path, string initialFilename, string filetype)
        {
            string newFilename = initialFilename;

            int nameIndex = 1;
            // ensure files with the same name are not overwritten
            while (File.Exists($"{path}{newFilename}{filetype}"))
            {
                newFilename = $"{initialFilename} {nameIndex}";
                nameIndex++;
            }

            return newFilename;
        }
    }
}