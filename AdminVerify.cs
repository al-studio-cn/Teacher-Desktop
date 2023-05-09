using Microsoft.Win32;
using Sunny.UI;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace TDesktop
{
    public partial class AdminVerify : UIForm
    {
        public string FontFilePath = @".\Resources\HarmonyOS_Sans.ttf";
        public AdminVerify()
        {
            InitializeComponent();
        }

        private void AdminVerify_button_Click(object sender, EventArgs e)
        {
            var a = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop", true);
            a.GetValue("AdminPassword");
            if (AdminVerify_Input.Text == a.GetValue("AdminPassword").ToString())
            {
                AdminVerify_Label.ForeColor = Color.Green;
                AdminVerify_Label.Text = "密码正确";
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                AdminVerify_Label.ForeColor = Color.Red;
                AdminVerify_Label.Text = "密码错误";
                AdminVerify_Input.Text = "";
            }
        }

        private void AdminVerify_Load(object sender, EventArgs e)
        {
            if (File.Exists(FontFilePath))
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile(FontFilePath);
                Font TitleFont = new Font(pfc.Families[0].Name, 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                Font Font = new Font(pfc.Families[0].Name, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));

                this.TitleFont = TitleFont;
                AdminVerify_Label.Font = Font;
                AdminVerify_Input.Font = Font;
                AdminVerify_button.Font = Font;
            }

            var a = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop", true);
            a.GetValue("AdminPassword");
            if (a == null)
            {
                MessageBox.Show("⚠请设置管理员密码");
            }
        }

        private void AdminVerify_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
