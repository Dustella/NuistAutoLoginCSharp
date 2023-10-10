using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NuistAutoLogin.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuistAutoLogin
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = Host.CreateDefaultBuilder();

            var host = builder.ConfigureServices((context, services) =>
            {
                services.AddSingleton<Api>();
                services.AddSingleton<States>();
                services.AddSingleton<Logger>();
                services.AddTransient<MainWindow>();
                
            })
            .Build().Services
            .GetRequiredService<MainWindow>();

            Application.Run(host);

        }


    }
}
