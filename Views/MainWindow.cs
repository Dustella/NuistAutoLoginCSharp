using NuistAutoLogin.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuistAutoLogin
{
    public partial class MainWindow : Form
    {
        private Api _api;
        private States _state;
        public MainWindow(Api api, States state)
        {
            InitializeComponent();
            this._api = api;
            _state = state;
            if (state.ConfigExists())
            {
                var user = state.User;
                UsernameInput.Text = user.username;
                PasswordInput.Text = user.password;
                //CarrierInput.Text = user.carrier;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UsernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            var user = new UserRecord
            {
                username = UsernameInput.Text,
                password = PasswordInput.Text,
                carrier = "中国电信"
            };
            _state.User = user;
            if (Remember.Checked)
            {
                _state.SaveConfig();
            }
        }
    }
}
