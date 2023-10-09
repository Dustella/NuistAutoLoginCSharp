using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuistAutoLogin.Modules
{
    public class States
    { 
        private readonly Logger _logger;
        public States(Logger logger)
        {
            ReadConfig();
            _logger = logger;
        }
        public UserRecord user { get; set; }
        public bool ConfigExists()
            => System.IO.File.Exists(_configPath);

        private readonly string _configPath = System.IO.Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.ApplicationData
                ),
                "inuist.ini"
            );

        private void ReadConfig()
        {
            if (!ConfigExists())
            {
                Logger.Log("Config not exists");
                return;
            }

            var content = System.IO.File.ReadAllText(_configPath);

            var lines = content.Split('\n');
            var username = lines[0].Split('=')[1];
            var password = lines[1].Split('=')[1];
            var carrier = lines[2].Split('=')[1];
            user = new UserRecord { username = username, password = password, carrier = carrier };
            Logger.Log($"Read config: {user.username} {user.password} {user.carrier}");
        }
        public void SaveConfig()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"username={user.username}");
            builder.AppendLine($"password={user.password}");
            builder.AppendLine($"carrier={user.carrier}");
            System.IO.File.WriteAllText(_configPath, builder.ToString());
            Logger.Log($"Save config: {user.username} {user.password} {user.carrier}");
        }

        public void DeleteConfig()
        {
            System.IO.File.Delete(_configPath);
            Logger.Log("Delete config");
        }
    }
}
