using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuistAutoLogin.Modules
{
    internal class States
    {
        States()
        {
            // test if there is file in path %appdata%\inuist.ini
            // if not, create one
            var ConfigExists = System.IO.File.Exists(
                System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "inuist.ini")
                  );
            if (ConfigExists)
            {
                //var ini = new IniFile(
                //                       System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                //                                          "inuist.ini")
                //                                          );
                //// read ini file and read properties `username` and `password`
                //var username = ini.Read("username", "account");
                //var password = ini.Read("password", "account");
            }

        }
    }
}
