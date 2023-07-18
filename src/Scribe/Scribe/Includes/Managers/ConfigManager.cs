using System.IO;
using System.Text;
using static Scribe.Data.Structure.ConfigStructure;

namespace Scribe.Managers
{
    public static class ConfigManager
    {
        public static void WriteConfig(ConfigBase config)
        {
            var sb = new StringBuilder();
            foreach (var field in typeof(ConfigBase).GetFields())
            {
                object value = field.GetValue(config);
                if (value != null)
                    sb.Append(field.Name + "¶" + value.ToString());
                sb.Append("\n");
            }
            sb.Length--;
            File.WriteAllText("Scribe\\config\\config.sc", sb.ToString());
        }

        public static ConfigBase ReadConfig()
        {
            ConfigBase config = new ConfigBase();

            string configFile = File.ReadAllText("Scribe\\config\\config.sc");
            string[] configSetting = configFile.Split('\n');

            for (int i = 0; i < configSetting.Length; i++)
            {
                string[] configSettingPair = configSetting[i].Split('¶');

                switch (configSettingPair[0])
                {
                    case "SELECTION_DIRECTORIES": config.SELECTION_DIRECTORIES = configSettingPair[1]; break;
                    case "SELECTION_DIRECTORIES_FILETYPE": config.SELECTION_DIRECTORIES_FILETYPE = configSettingPair[1]; break;
                    case "SELECTION_ENABLE_SUBDIRECTORIES": config.SELECTION_ENABLE_SUBDIRECTORIES = bool.Parse(configSettingPair[1]); break;
                    case "SELECTION_SELECTED_INDEX": config.SELECTION_SELECTED_INDEX = int.Parse(configSettingPair[1]); break;

                    case "PROCESS_AUTO_UPDATE": config.PROCESS_AUTO_UPDATE = bool.Parse(configSettingPair[1]); break;
                    case "PROCESS_START_WITH_WINDOWS": config.PROCESS_START_WITH_WINDOWS = bool.Parse(configSettingPair[1]); break;
                    case "PROCESS_DISPLAY_OUTPUT": config.PROCESS_DISPLAY_OUTPUT = bool.Parse(configSettingPair[1]); break;
                    case "PROCESS_DISPLAY_OUTPUT_PAUSE": config.PROCESS_DISPLAY_OUTPUT_PAUSE = bool.Parse(configSettingPair[1]); break;
                    case "PROCESS_ENABLE_CUDA": config.PROCESS_ENABLE_CUDA = bool.Parse(configSettingPair[1]); break;
                    case "PROCESS_MODEL": config.PROCESS_MODEL = configSettingPair[1]; break;

                    case "SEARCH_PHRASE": config.SEARCH_PHRASE = configSettingPair[1]; break;
                    case "SEARCH_FILE": config.SEARCH_FILE = configSettingPair[1]; break;
                    case "SEARCH_ENABLE_AUTO_UPDATE": config.SEARCH_ENABLE_AUTO_UPDATE = bool.Parse(configSettingPair[1]); break;
                    case "SEARCH_ENABLE_CASE_SENSITIVITY": config.SEARCH_ENABLE_CASE_SENSITIVITY = bool.Parse(configSettingPair[1]); break;
                    case "SEARCH_SELECTED_INDEX": config.SEARCH_SELECTED_INDEX = int.Parse(configSettingPair[1]); break;
                }
            }

            return config;
        }
    }
}