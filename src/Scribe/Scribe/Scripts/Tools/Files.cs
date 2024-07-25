using System;
using System.IO;
using System.Net.Http;

namespace Scribe.Tools
{
    public static class Files
    {
        public static int CleanFiles(string folder)
        {
            string fileExtensionToKeep = ".scstore";
            int count = 0;

            foreach (string filePath in Directory.GetFiles(folder))
            {
                string extension = Path.GetExtension(filePath);

                // check if the current file is not the specified file type
                if (extension != fileExtensionToKeep)
                {
                    // delete the file
                    try
                    {
                        File.Delete(filePath);
                        count++;
                    }
                    catch { }
                }
            }

            return count;
        }

        public static void DownloadFile(string url, string outputPath)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(url).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();

                using (var fs = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                {
                    response.Content.CopyToAsync(fs).GetAwaiter().GetResult();
                }
            }
        }

        public static bool DoesFileExistInPath(string fileName)
        {
            var values = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);
            foreach (var path in (values ?? "").Split(Path.PathSeparator))
            {
                var fullPath = Path.Combine(path, fileName);
                if (File.Exists(fullPath))
                {
                    return true;
                }
            }
            return false;
        }
    }
}