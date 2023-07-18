using System.IO;

namespace Scribe.Tools
{
    public static class Files
    {
        public static int CleanFolder(string folder)
        {
            string fileExtensionToKeep = ".scstore";
            int count = 0;

            foreach (string filePath in Directory.GetFiles(folder))
            {
                string extension = Path.GetExtension(filePath);

                // Check if the current file is not the specified file type
                if (extension != fileExtensionToKeep)
                {
                    // Delete the file
                    try
                    {
                        File.Delete(filePath);
                        count++;
                    } catch { }
                }
            }

            return count;
        }
    }
}