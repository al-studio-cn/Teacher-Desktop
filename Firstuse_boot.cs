using Microsoft.Win32;
using Sunny.UI;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using TDesktop.Properties;

namespace TDesktop
{
    public partial class Firstuse_boot : UIForm
    {
        public string FontFilePath = @".\Resources\HarmonyOS_Sans.ttf";
        public Firstuse_boot()
        {
            InitializeComponent();
        }

        private void Firstuse_boot_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(FontFilePath);
            Font Title = new Font(pfc.Families[0].Name, 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.TitleFont = Title;
            FistUse_Start();
        }

        private void FisrtUse_Panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FistUse_Start()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(FontFilePath);
            Font font = new Font(pfc.Families[0].Name, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            UIButton FisrtUse_Btn_StartUse = new UIButton
            {
                Size = new Size(300, 50),//Button大小
                Location = new Point(this.Width - 600, this.Height - 150),
                Name = "FisrtUse_Btn_StartUse",
                Font = font,
                Text = "开始使用",
            };
            FisrtUse_Btn_StartUse.Click += new EventHandler(FistUse_Start_BtnEvent);//注册点击事件
            this.FisrtUse_Panel.Controls.Add(FisrtUse_Btn_StartUse);

            PictureBox FisrtUse_PictureBox_StartUse = new PictureBox
            {

                Size = new Size(250, 250),
                Location = new Point(this.Width - 575, this.Height - 450),
                Name = "FisrtUse_PictureBox_StartUse",
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Resources.TDesktop1
            };
            this.FisrtUse_Panel.Controls.Add(FisrtUse_PictureBox_StartUse);
        }

        private void FistUse_Start_BtnEvent(Object sender, EventArgs e)
        {
            if (sender is UIButton)
            {
                UIButton FisrtUse_Btn_StartUse = sender as UIButton;
                if (FisrtUse_Btn_StartUse.Name == "FisrtUse_Btn_StartUse")
                {
                    this.FisrtUse_Panel.Controls.Remove(FisrtUse_Btn_StartUse);
                    FistUse_Install();
                }
            }
        }

        private void FistUse_Install()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(FontFilePath);
            Font font = new Font(pfc.Families[0].Name, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            // 创建注册表 假进度条
            this.Text = "创建注册表";
            UIProcessBar FisrtUse_ProcessBar_Install = new UIProcessBar
            {
                Size = new Size(300, 50),//Button大小
                Location = new Point(this.Width - 600, this.Height - 150),
                Name = "FisrtUse_ProcessBar_Install",
                Maximum = 100,
                Font = font,
                Value = 0
            };

            Thread t = new Thread(new ThreadStart(() =>
           {
               for (int i = 0; i <= 100; i++)
               {
                   if (i == 100)
                   {
                       try
                       {
                            // 检查过程条是否存在，并且是否已经被销毁
                            if (FisrtUse_ProcessBar_Install != null && !FisrtUse_ProcessBar_Install.IsDisposed)
                           {
                                // 将任务委托给UI线程执行
                                FisrtUse_ProcessBar_Install.Invoke(new Action(() =>
                               {
                                   this.FisrtUse_Panel.Controls.Remove(FisrtUse_ProcessBar_Install);

                                   Registry.LocalMachine.CreateSubKey(@"SOFTWARE\TeacherDesktop");  //创建注册表
                                   Registry.LocalMachine.CreateSubKey(@"SOFTWARE\TeacherDesktop\exe");  //创建注册表
                                   Registry.LocalMachine.CreateSubKey(@"SOFTWARE\TeacherDesktop\url");  //创建注册表
                                   Registry.LocalMachine.CreateSubKey(@"SOFTWARE\TeacherDesktop\file");  //创建注册表
                                   var a = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop", true);
                                   //初始化Key
                                   a.SetValue("App", "");
                                   a.SetValue("AdminPassword", "");
                                   a.SetValue("BgType", "Bing");
                                   a.SetValue("FlieUrl", "");
                                   a.SetValue("PowerBoot", false);
                                   AdminPassword_Config();
                               }));
                           }
                       }
                       catch (ObjectDisposedException)
                       {
                           MessageBox.Show("FisrtUse_ProcessBar_Install Error");
                       }
                       return;
                   }
                   FisrtUse_ProcessBar_Install.Invoke((MethodInvoker)delegate
                   {
                       FisrtUse_ProcessBar_Install.Value = i;
                   });
                   Thread.Sleep(100);
               }
           }));
            t.Start();
            this.FisrtUse_Panel.Controls.Add(FisrtUse_ProcessBar_Install);
        }

        private void AdminPassword_Config()
        {
            this.Text = "管理员密码";
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(FontFilePath);
            Font font = new Font(pfc.Families[0].Name, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            UITextBox FisrtUse_TextBox_AdminPassword_Config = new UITextBox
            {
                Size = new Size(300, 50),//Button大小
                Tag = "AdminPassword_Config",
                Location = new Point(this.Width - 660, this.Height - 150),
                Name = "FisrtUse_TextBox_AdminPassword_Config",
                Font = font,
                TextAlignment = (ContentAlignment)HorizontalAlignment.Center,
                PasswordChar = '*'
            };
            this.FisrtUse_Panel.Controls.Add(FisrtUse_TextBox_AdminPassword_Config);

            UIButton FisrtUse_Btn_AdminPassword_Config = new UIButton
            {
                Size = new Size(100, 50),//Button大小
                Location = new Point(this.Width - 350, this.Height - 150),
                Name = "FisrtUse_Btn_AdminPassword_Config",
                Font = font,
                Text = "设置",
            };
            FisrtUse_Btn_AdminPassword_Config.Click += new EventHandler(FisrtUse_TextBox_AdminPassword_Config_BtnEvent);
            this.FisrtUse_Panel.Controls.Add(FisrtUse_Btn_AdminPassword_Config);
        }

        private void FisrtUse_TextBox_AdminPassword_Config_BtnEvent(Object sender, EventArgs e)
        {
            if (sender is UIButton)
            {
                UIButton FisrtUse_Btn_AdminPassword_Config = sender as UIButton;
                if (FisrtUse_Btn_AdminPassword_Config.Name == "FisrtUse_Btn_AdminPassword_Config")
                {
                    var FisrtUse_TextBox_AdminPassword_Config = (UITextBox)this.FisrtUse_Panel.Controls["FisrtUse_TextBox_AdminPassword_Config"];
                    if (FisrtUse_TextBox_AdminPassword_Config != null)
                    {
                        var FisrtUse_TextBox_AdminPassword_Config_Value = FisrtUse_TextBox_AdminPassword_Config.Text.ToString();
                        if (FisrtUse_TextBox_AdminPassword_Config_Value != "")
                        {
                            var a = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop", true);
                            a.SetValue("AdminPassword", FisrtUse_TextBox_AdminPassword_Config_Value);

                            this.FisrtUse_Panel.Controls.Remove(FisrtUse_TextBox_AdminPassword_Config);
                            this.FisrtUse_Panel.Controls.Remove(FisrtUse_Btn_AdminPassword_Config);
                            StartApp();
                        }
                        else
                        {
                            MessageBox.Show("密码不得为空");
                        }
                    }
                    else
                    {
                        MessageBox.Show("FisrtUse_Btn_AdminPassword_Config Error");
                    }
                }
            }
        }

        private void StartApp()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(FontFilePath);
            Font font = new Font(pfc.Families[0].Name, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));

            UIButton FisrtUse_Btn_RStartApp = new UIButton
            {
                Size = new Size(300, 50),//Button大小
                Location = new Point(this.Width - 600, this.Height - 150),
                Name = "FisrtUse_Btn_RStartApp",
                Font = font,
                FillColor = Color.White,
                FillColor2 = Color.White,
                ForeColor = Color.Black,
                Text = "安装完成",
            };
            FisrtUse_Btn_RStartApp.Click += new EventHandler(FisrtUse_Btn_RStartApp_BtnEvent);//注册点击事件
            this.FisrtUse_Panel.Controls.Add(FisrtUse_Btn_RStartApp);
        }

        private void FisrtUse_Btn_StartApp_BtnEvent(Object sender, EventArgs e)
        {
            if (sender is UIButton)
            {
                UIButton FisrtUse_Btn_StartApp = sender as UIButton;
                if (FisrtUse_Btn_StartApp.Name == "FisrtUse_Btn_StartApp")
                {
                    MainFrom a = new MainFrom();
                    a.Show();
                    this.Close();
                }
            }
        }

        private void FisrtUse_Btn_RStartApp_BtnEvent(Object sender, EventArgs e)
        {
            if (sender is UIButton)
            {
                UIButton FisrtUse_Btn_RStartApp = sender as UIButton;
                if (FisrtUse_Btn_RStartApp.Name == "FisrtUse_Btn_RStartApp")
                {
                    Registry.LocalMachine.CreateSubKey(@"SOFTWARE\TeacherDesktop"); 
                    var a = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop", true);
                    a.SetValue("App", "1");
                    Application.Exit();
                }
            }
        }
    }
}
