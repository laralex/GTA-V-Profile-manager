using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Globalization;
using System.IO;

namespace GTAV_Profiles_manager
{
    static class MainClass
    {
        private static Config config;
        public const string DATETIME_FORMAT = "dd-MMM-yyyy HH:mm";

        public static string NowString()
        {
            return DateTime.Now.ToString(DATETIME_FORMAT, new CultureInfo("en-US"));
        }

        public static void SerializeConfigJson(string json_path)
        {
            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            System.IO.File.WriteAllText(json_path, json);
        }

        public static void ParseConfigJson(string json_path)
        {
            string json_string = System.IO.File.ReadAllText(@json_path);
            JObject parsed = JObject.Parse(json_string);
            config = parsed.ToObject<Config>();
        }


        public static bool LoadProfile(string new_profile)
        {
            // Update config object
            for (int i = 0; i < config.profiles.Count; ++i)
            {
                if (config.profiles[i].name == new_profile)
                {
                    config.profiles[i].last_enabled = MainClass.NowString();
                    new_profile = config.profiles[i].name;
                }
            }

            // Manipulate filesystem
            if (new_profile != "" && ValidateData())
            {
                // Удалить все текущие данные профиля из приложения

                var g_profiles_path = Path.Combine(config.options.path_to_rockstar, "GTA V", "Profiles");
                var s_profiles_path = Path.Combine(config.options.path_to_rockstar, "Social Club", "Profiles");

                var old_profile_path = Path.Combine(config.options.path_to_profiles, config.options.active_profile);
                var g_old_path = Path.Combine(old_profile_path, "GTA V");
                var s_old_path = Path.Combine(old_profile_path, "Social Club");

                ClearDirectory(g_old_path);
                ClearDirectory(s_old_path);

                // Переместить данные из игры в профиль из приложения (сохранение в профиль)
                CopyDirectoryContent(g_profiles_path, g_old_path);
                ClearDirectory(g_profiles_path);
                CopyDirectoryContent(s_profiles_path, s_old_path);
                ClearDirectory(s_profiles_path);

                // Переместить данные загружающегося профиля в игру (загрузка профиля)
                var new_profile_path = Path.Combine(config.options.path_to_profiles, new_profile);
                var g_new_path = Path.Combine(new_profile_path, "GTA V");
                var s_new_path = Path.Combine(new_profile_path, "Social Club");

                CopyDirectoryContent(g_new_path, g_profiles_path);
                CopyDirectoryContent(s_new_path, s_profiles_path);

                config.options.active_profile = new_profile;
                return true;
            }
            return false;
        }

        public static bool ValidateData()
        {
            var g_profiles_path = Path.Combine(config.options.path_to_rockstar, "GTA V", "Profiles");
            var s_profiles_path = Path.Combine(config.options.path_to_rockstar, "Social Club", "Profiles");
            string profiles_folder_path = config.options.path_to_profiles;

            var profiles_folder_content = Directory.EnumerateDirectories(profiles_folder_path);
            bool are_all_profiles_present = config.profiles.All(p => profiles_folder_content.Any(pf => pf.Substring(pf.LastIndexOf("\\") + 1) == p.name));
            bool are_all_profiles_have_subfolders = true;
            bool are_all_subfolders_have_savefiles = true;
            bool result = true;
            foreach (var f in profiles_folder_content)
            {
                var single_profile_folder = new List<string>(Directory.EnumerateDirectories(f));
                if (!single_profile_folder.Any(el => el.Substring(el.LastIndexOf("\\") + 1) == "GTA V") || !single_profile_folder.Any(el => el.Substring(el.LastIndexOf("\\") + 1) == "Social Club"))
                {
                    are_all_profiles_have_subfolders = false;
                }
                else
                {
                    /*var single_profile_folder_gta5 = new List<string>(Directory.EnumerateDirectories(f + "\\GTA V"));
                    var single_profile_folder_sc = new List<string>(Directory.EnumerateDirectories(f + "\\Social Club"));
                    if (single_profile_folder_gta5.Count == 0 || single_profile_folder_gta5.Count == 0)
                    {
                        are_all_subfolders_have_savefiles = false;
                    }*/
                }
            }
            try
            {
                var gta5_folder_content = Directory.EnumerateDirectories(g_profiles_path);
                var social_club_folder_content = Directory.EnumerateDirectories(s_profiles_path);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Rockstar folder is invalid");
                result = false;
            }

            if (!(are_all_profiles_present && are_all_profiles_have_subfolders && are_all_subfolders_have_savefiles))
            {
                MessageBox.Show("Profiles folder doesn't have all stated profiles");
                result = false;
            }
            return result;
        }

        public static void CopyDirectoryContent(string src_path, string dest_path)
        {
            foreach (string dir in System.IO.Directory.GetDirectories(src_path, "*", System.IO.SearchOption.AllDirectories))
            {
                System.IO.Directory.CreateDirectory(System.IO.Path.Combine(dest_path, dir.Substring(src_path.Length + 1)));
            }

            foreach (string file_name in System.IO.Directory.GetFiles(src_path, "*", System.IO.SearchOption.AllDirectories))
            {
                System.IO.File.Copy(file_name, System.IO.Path.Combine(dest_path, file_name.Substring(src_path.Length + 1)));
            }
        }

        public static void ClearDirectory(string path)
        {
            foreach (var d in Directory.EnumerateDirectories(path))
            {
                Directory.Delete(d, true);
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            ParseConfigJson(@"config.json");
            bool is_auto_mode = false;

            // Processing command-line arguments
            for (int i = 0; i < args.Length; ++i)
            {
                foreach(CmdArgument arg in config.cmd_arguments)
                {
                    if (args[i] == arg.command)
                    {
                        switch (arg.command)
                        {
                            case "-s":
                                // auto switch mode
                                is_auto_mode = true;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            // Starting app
            if (is_auto_mode)
            {
                int active_profile_index = config.profiles.FindIndex(el => el.name == config.options.active_profile);
                string new_profile_name = (active_profile_index + 1 == config.profiles.Count) ?
                        config.profiles[0].name : config.profiles[active_profile_index + 1].name;
                LoadProfile(new_profile_name);
                MessageBox.Show("Activated profile: " + new_profile_name);
                SerializeConfigJson(@"config.json");
            }
            else
            {
                // Work with form
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var main_form = new MainForm(config.profiles, config.options);
                Application.Run(main_form);
                SerializeConfigJson(@"config.json");
            }
        }
    }
}
