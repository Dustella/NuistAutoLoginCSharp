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
            _api = api;
            _state = state;

            InitializeComponent();

            if (state.ConfigExists())
            {
                var user = state.user;
                Remember.Checked = true;
                UsernameInput.Text = user.username;
                PasswordInput.Text = user.password;
                CarrierChoose.SelectedIndex = CarrierChoose.Items.IndexOf(user.carrier);
            }
            prepareEnv();
        }

        private async void prepareEnv()
        {
            var ip = await _api.GetIp();
            IPLabel.Text = $"IP: {ip}";
            CarrierChoose.Items.AddRange(new string[] { "校园网", "中国移动", "中国电信", "中国联通" });
            // default carrier is 中国电信
            CarrierChoose.SelectedIndex = 2;
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

        private async void login()
        {
            var result = await _api.DoLogin();
            Logger.Log($"Login result: {result}");
            switch (result)
            {
                case Result.Success:
                    MessageBox.Show("登录成功");
                    break;
                case Result.WrongPassword:
                    MessageBox.Show("密码错误");
                    break;
                case Result.WrongUsername:
                    MessageBox.Show("用户名错误");
                    break;
                case Result.IncompleteAccount:
                    MessageBox.Show("账号不完整");
                    break;
                case Result.InternelError:
                    MessageBox.Show("内部错误");
                    break;
            }
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            var user = new UserRecord
            {
                username = UsernameInput.Text,
                password = PasswordInput.Text,
                carrier = CarrierChoose.SelectedItem.ToString()
            };
          
            _state.user = user;
            if (Remember.Checked)
            {
                _state.SaveConfig();
            }
            else
            {
                _state.DeleteConfig();
            }

            login();
        }
    }
}
