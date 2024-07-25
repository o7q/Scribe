using System;
using System.IO;
using System.Text;

namespace Scribe.Data.Config
{
    public static class ConfigManager
    {
        public static void WriteConfig(ConfigBase config)
        {
            var sb = new StringBuilder();
            foreach (var field in typeof(ConfigBase).GetFields())
            {
                object value = field.GetValue(config) ?? "";
                if (value != null)
                {
                    sb.Append(field.Name + "=" + value.ToString());
                }
                sb.Append('\n');
            }
            sb.Length--;
            File.WriteAllText("Scribe\\config\\config.cfg", sb.ToString());
        }

        public static ConfigBase ReadConfig()
        {
            ConfigBase config = new ConfigBase();

            string configFile = File.ReadAllText("Scribe\\config\\config.cfg");
            string[] configSetting = configFile.Split('\n');

            for (int i = 0; i < configSetting.Length; i++)
            {
                string[] configSettingPair = configSetting[i].Split('=', 2, StringSplitOptions.None);

                switch (configSettingPair[0])
                {
                    case "SELECTION_DIRECTORIES": config.SELECTION_DIRECTORIES = configSettingPair[1]; break;
                    case "SELECTION_DIRECTORIES_FILETYPE": config.SELECTION_DIRECTORIES_FILETYPE = configSettingPair[1]; break;
                    case "SELECTION_SUBDIRECTORIES_ENABLE": config.SELECTION_SUBDIRECTORIES_ENABLE = bool.Parse(configSettingPair[1]); break;
                    case "SELECTION_SELECTED_INDEX": config.SELECTION_SELECTED_INDEX = int.Parse(configSettingPair[1]); break;

                    case "PROCESS_AUTO_UPDATE_ENABLE": config.PROCESS_AUTO_UPDATE_ENABLE = bool.Parse(configSettingPair[1]); break;
                    case "PROCESS_START_WITH_WINDOWS_ENABLE": config.PROCESS_START_WITH_WINDOWS_ENABLE = bool.Parse(configSettingPair[1]); break;
                    case "PROCESS_DEBUG_ENABLE": config.PROCESS_DEBUG_ENABLE = bool.Parse(configSettingPair[1]); break;
                    case "PROCESS_CUDA_ENABLE": config.PROCESS_CUDA_ENABLE = bool.Parse(configSettingPair[1]); break;
                    case "PROCESS_LANGUAGE": config.PROCESS_LANGUAGE = configSettingPair[1]; break;
                    case "PROCESS_MODEL": config.PROCESS_MODEL = configSettingPair[1]; break;
                    case "PROCESS_BUFFER_SIZE": config.PROCESS_BUFFER_SIZE = int.Parse(configSettingPair[1]); break;

                    case "SEARCH_PHRASE": config.SEARCH_PHRASE = configSettingPair[1]; break;
                    case "SEARCH_FILE": config.SEARCH_FILE = configSettingPair[1]; break;
                    case "SEARCH_AUTO_UPDATE_ENABLE": config.SEARCH_AUTO_UPDATE_ENABLE = bool.Parse(configSettingPair[1]); break;
                    case "SEARCH_CASE_SENSITIVE_ENABLE": config.SEARCH_CASE_SENSITIVE_ENABLE = bool.Parse(configSettingPair[1]); break;
                }
            }

            return config;
        }
    }
}