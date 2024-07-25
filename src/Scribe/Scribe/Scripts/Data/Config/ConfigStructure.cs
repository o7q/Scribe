namespace Scribe.Data.Config
{
    public struct ConfigBase
    {
        public string SELECTION_DIRECTORIES;
        public string SELECTION_DIRECTORIES_FILETYPE;
        public bool SELECTION_SUBDIRECTORIES_ENABLE;
        public int SELECTION_SELECTED_INDEX;

        public bool PROCESS_AUTO_UPDATE_ENABLE;
        public bool PROCESS_START_WITH_WINDOWS_ENABLE;
        public bool PROCESS_DEBUG_ENABLE;
        public bool PROCESS_CUDA_ENABLE;
        public string PROCESS_LANGUAGE;
        public string PROCESS_MODEL;
        public int PROCESS_BUFFER_SIZE;

        public string SEARCH_PHRASE;
        public string SEARCH_FILE;
        public bool SEARCH_AUTO_UPDATE_ENABLE;
        public bool SEARCH_CASE_SENSITIVE_ENABLE;
    }
}