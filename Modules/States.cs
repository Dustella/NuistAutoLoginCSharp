using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuistAutoLogin.Modules
{
    public class States
    { 
        public UserRecord User { get; set; }
        public bool ConfigExists()
            => System.IO.File.Exists(configPath);

        private string configPath = System.IO.Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.ApplicationData
                ),
                "inuist.ini"
            );

        private void ReadConfig()
        {
            if (!ConfigExists()) { return; }

            var content = System.IO.File.ReadAllText(configPath);

            var lines = content.Split('\n');
            var username = lines[0].Split('=')[1];
            var password = lines[1].Split('=')[1];
            var carrier = lines[2].Split('=')[1];
            User = new UserRecord { username = username, password = password, carrier = carrier };

        }
        public void SaveConfig()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"username={User.username}");
            stringBuilder.AppendLine($"password={User.password}");
            stringBuilder.AppendLine($"carrier={User.carrier}");
            System.IO.File.WriteAllText(configPath, stringBuilder.ToString());
        }

        public void DeleteConfig()
        {
            System.IO.File.Delete(configPath);
        }
        public States()
        {
            ReadConfig();
        }
    }
}
