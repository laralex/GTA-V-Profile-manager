using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace GTAV_Profiles_manager
{
    public class Profile
    {
        private string _name;
        private string _created, _last_enabled;
        public Profile(string name, string created, string last_enabled)
        {
            this.name = name;
            this.created = created;
            this.last_enabled = last_enabled;
        }
        public string name
        {
            get => _name;
            set { _name = value; if (value == null) throw new Exception("Profile name is null"); }
        }
        public string created
        {
            get => _created;
            set { _created = value; if (value != "") DateTime.ParseExact(value, MainClass.DATETIME_FORMAT, new CultureInfo("en-US")); }
        }
        public string last_enabled {
            get => _last_enabled;
            set { _last_enabled = value; if (value != "") DateTime.ParseExact(value, MainClass.DATETIME_FORMAT, new CultureInfo("en-US"));  }
        }
    }
    public class Options
    {
        public string path_to_rockstar, path_to_profiles, active_profile;
    }
    public class CmdArgument
    {
        public string command, description;
    }

    public class Config
    {
        public List<Profile> profiles { get; set; }
        public Options options { get; set; }
        public List<CmdArgument> cmd_arguments { get; set; }
        public Config(List<Profile> profiles, Options options, List<CmdArgument> cmd_arguments)
        {
            this.profiles = profiles;
            this.options = options;
            this.cmd_arguments = cmd_arguments;
        }
    }
}
