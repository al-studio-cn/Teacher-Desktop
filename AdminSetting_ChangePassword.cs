using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using TDesktop.Properties;
using Microsoft.Win32;

namespace TDesktop
{
    public partial class AdminSetting_ChangePassword : UIForm
    {
        public AdminSetting_ChangePassword()
        {
            InitializeComponent();
        }

        private void AdminVerify_button_Click(object sender, EventArgs e)
        {
            var a = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop", true);
            a.GetValue("AdminPassword");
            if (AdminSetting_ChangePassword_Input.Text != a.GetValue("AdminPassword").ToString())
            {
                AdminSetting_ChangePassword_Label.ForeColor = Color.Green;
                AdminSetting_ChangePassword_Label.Text = "密码已更改";
                a.SetValue("AdminPassword", AdminSetting_ChangePassword_Input.Text);
                this.Close();
            }
            else
            {
                AdminSetting_ChangePassword_Label.ForeColor = Color.Red;
                AdminSetting_ChangePassword_Label.Text = "新密码不能与旧密码一致";
            }
        }

        private void AdminVerify_Load(object sender, EventArgs e)
        {

        }
    }
}
