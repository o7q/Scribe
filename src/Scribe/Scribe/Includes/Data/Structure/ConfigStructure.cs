namespace Scribe.Data.Structure
{
    public static class ConfigStructure
    {
        public struct ConfigBase
        {
            public string SELECTION_DIRECTORIES;
            public string SELECTION_DIRECTORIES_FILETYPE;
            public bool SELECTION_ENABLE_SUBDIRECTORIES;
            public int SELECTION_SELECTED_INDEX;

            public bool PROCESS_AUTO_UPDATE;
            public bool PROCESS_START_WITH_WINDOWS;
            public bool PROCESS_DISPLAY_OUTPUT;
            public bool PROCESS_DISPLAY_OUTPUT_PAUSE;
            public bool PROCESS_ENABLE_CUDA;
            public string PROCESS_MODEL;

            public string SEARCH_PHRASE;
            public string SEARCH_FILE;
            public bool SEARCH_ENABLE_AUTO_UPDATE;
            public bool SEARCH_ENABLE_CASE_SENSITIVITY;
            public int SEARCH_SELECTED_INDEX;
        }
    }
}