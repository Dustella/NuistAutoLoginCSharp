using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuistAutoLogin.Views
{
    public partial class LoadingIP : Form
    {
        private MainWindow _window;
        public LoadingIP(MainWindow window)
        {
            _window = window;
            // destroy this form after 3 seconds
            InitializeComponent();
            Task.Delay(3000).ContinueWith(t =>
            {
                // show a dialog says: "IP loaded"
                this.Close();
                MessageBox.Show(@"IP loaded");
                // show main window
                // close current window
                _window.Show();
                
            });
        }
    }
}
