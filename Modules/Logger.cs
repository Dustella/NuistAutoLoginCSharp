using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuistAutoLogin.Modules
{
    public class Logger
    {
        // log path is %appdata%/NuistAutoLogin/log/[date].log
        private const string LogPath = "%appdata%/NuistAutoLogin/log/";

        public Logger()
        {
            // check if LogPath exists
            // if not, create it
            var pathExists = System.IO.Directory.Exists(LogPath);
            if (!pathExists)
            {
                System.IO.Directory.CreateDirectory(LogPath);
            }
        }

        public static void Log(string message)
        {
            Console.WriteLine(message);
            // append message to log file
            // if file not exists, create it
            // var path = LogPath + DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            // var fileExists = System.IO.File.Exists(path);
            // if (!fileExists)
            // {
            //     System.IO.File.Create(path);
            // }
            // System.IO.File.AppendAllText(path, message);
        }
    }
}