using Microsoft.Win32;
using Sunny.UI;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using TDesktop.Properties;

namespace TDesktop
{
    public partial class AdminSetting : UIForm
    {
        public string FontFilePath = @".\Resources\HarmonyOS_Sans.ttf";

        public AdminSetting()
        {
            InitializeComponent();
        }

        private void AdminSetting_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop", true);
            string BgType = key.GetValue("BgType").ToString();
            bool PowerBoot = bool.Parse(key.GetValue("PowerBoot").ToString());
            if (PowerBoot==true)
            {
                TabPage_MainSettings_PowerBoot.Checked = true;
            }
            else
            {
                TabPage_MainSettings_PowerBoot.Checked = false;
            }
            if (BgType == "Bing")
            {
                FileBg.Checked = false;
                BingBg.Checked = true;
            }
            if (BgType == "File")
            {
                BingBg.Checked = false;
                FileBg.Checked = true;
            }
            AppList_Exe_Add();
            AppList_Url_Add();
            AppList_File_Add();
        }

        private void TabPage_About_Gitee_Link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gitee.com/al-studio/Teacher-Desktop");
        }

        private void TabPage_About_Github_Link_Click_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/yalwolf/Teacher-Desktop");
        }

        private void TabPage_MainSettings_PowerBoot_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey App = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop", true);
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (TabPage_MainSettings_PowerBoot.Checked)
            {
                App.SetValue("PowerBoot",true);
                key.SetValue("TDeskTop", Application.ExecutablePath.ToString());
            }
            else
            {
                App.SetValue("PowerBoot", false);
                key.DeleteValue("TDeskTop");
            }
        }

        private void UploadBgImg_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop", true);
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "图片文件|*.bmp;*.jpg;*.png;*.jfif;*.wabp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            if (File.Exists(openFileDialog1.FileName))
            {
                    key.SetValue("FlieUrl", openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void FileBg_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop", true);
            if (FileBg.Checked)
            {
                key.SetValue("BgType", "File");
                BingBg.Checked = false;
                UploadBgImg.Enabled = true;
            }
            else
            {
                UploadBgImg.Enabled = false;
            }
        }

        private void BingBg_CheckedChanged(object sender, EventArgs e)
        {
            if (BingBg.Checked)
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop", true);
                key.SetValue("BgType", "Bing");
                FileBg.Checked = false;
                UploadBgImg.Enabled = false;
            }
            else
            {
                UploadBgImg.Enabled = true;
            }
        }

        private void AppList_File_Add()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(FontFilePath);
            Font font = new Font(pfc.Families[0].Name, 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop\file\", true);
            string[] subKeyNames = key.GetSubKeyNames();
            var subKeyNumBer = key.GetSubKeyNames().Length;

            if (subKeyNumBer <= 0)
            {
                Font Texta = new Font(pfc.Families[0].Name, 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                UILabel Text = new UILabel
                {
                    Size = this.AppList_Admin_File_Panel.Size,
                    Location = new Point(0, 0),
                    Font = Texta,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Name = "AppList_Label_Text",
                    Text = "暂无File模块"
                };
                this.AppList_Admin_File_Panel.Controls.Add(Text);

            }
            else
            {
                foreach (string subKeyName in subKeyNames)
                {
                    int i = 0;
                    while (i < subKeyNumBer)
                    {
                        RegistryKey App = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop\file\" + subKeyNames[i], true);
                        bool Admin = bool.Parse(App.GetValue("Admin").ToString());
                        string Name = App.GetValue("Name").ToString();

                        Console.WriteLine(Name);
                        Panel App_AdminPanel = new Panel
                        {
                            Size = new Size(200, 30),
                            Location = new Point(this.Width - 880, this.Height - 550 + 50 * i),
                            BackColor = Color.Transparent,
                            Font = font,
                            Name = "AppList_Panell_" + Name
                        };
                        this.AppList_Admin_File_Panel.Controls.Add(App_AdminPanel);

                        UILabel AppnName = new UILabel
                        {
                            Size = new Size(100, 30),
                            Location = new Point(0, 0),
                            Font = font,
                            Name = "AppList_Label_" + Name,
                            Text = Name
                        };

                        AppnName.MouseDown += new MouseEventHandler(AppLIst_Add_MouseDown);

                        UISwitch AppSwitch = new UISwitch
                        {
                            Size = new Size(80, 30),
                            Location = new Point(100, 0),
                            Name = "AppList_Switch_" + Name,
                            ActiveText = "启用",
                            InActiveText = "禁用",
                            Active = Admin
                        };
                        AppSwitch.ActiveChanged += new EventHandler(AppLIst_Add_This_AdminSwitch_ActiveChanged);

                        App_AdminPanel.Controls.Add(AppnName);
                        App_AdminPanel.Controls.Add(AppSwitch);

                        void AppLIst_Add_This_AdminSwitch_ActiveChanged(object sender, EventArgs e)
                        {
                            if (AppSwitch.Active)
                            {
                                App.SetValue("Admin", true);
                            }
                            else
                            {
                                App.SetValue("Admin", false);
                            }
                        }

                        void AppLIst_Add_MouseDown(object sender, MouseEventArgs e)
                        {
                            if (e.Button == MouseButtons.Right)
                            {
                                File_ContextMenuStrip.Show(AppnName, e.Location);
                                File_ContextMenuStrip.ItemClicked += new ToolStripItemClickedEventHandler(ContextMenuStrip_ItemClicked);
                            }
                        }

                        void ContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
                        {
                            if (e.ClickedItem == FileDel) // 删除事件检测
                            {
                                try
                                {
                                    //删除选中的模块
                                    Registry.LocalMachine.DeleteSubKey(@"SOFTWARE\TeacherDesktop\File\" + Name, true);
                                    this.AppList_Admin_File_Panel.Controls.Clear();
                                    AppList_File_Add();
                                }
                                catch (InvalidOperationException)
                                {
                                    MessageBox.Show("删除失败，请重试");
                                }
                            }
                        }
                        i++;
                    }
                }
            }
            key.Close();
        }

        private void AppList_Url_Add()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(FontFilePath);
            Font font = new Font(pfc.Families[0].Name, 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop\url\",true);
            string[] subKeyNames = key.GetSubKeyNames();
            var subKeyNumBer = key.GetSubKeyNames().Length;

            if(subKeyNumBer <= 0)
            {
                Font Texta = new Font(pfc.Families[0].Name, 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                UILabel Text = new UILabel
                {
                    Size = this.AppList_Admin_Url_Panel.Size,
                    Location = new Point(0, 0),
                    Font = Texta,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Name = "AppList_Label_Text",
                    Text = "暂无Url模块"
                };
                this.AppList_Admin_Url_Panel.Controls.Add(Text);
            }
            else
            {
                foreach (string subKeyName in subKeyNames)
                {
                    int i = 0;
                    while (i < subKeyNumBer)
                    {
                        RegistryKey App = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop\url\" + subKeyNames[i], true);
                        bool Admin = bool.Parse(App.GetValue("Admin").ToString());
                        string Name = App.GetValue("Name").ToString();
                        string Path = App.GetValue("Path").ToString();

                        Console.WriteLine(Name);
                        Panel App_AdminPanel = new Panel
                        {
                            Size = new Size(200, 30),
                            Location = new Point(this.Width - 880, this.Height - 550 + 50 * i),
                            BackColor = Color.Transparent,
                            Font = font,
                            Name = "AppList_Panell_" + Name
                        };
                        this.AppList_Admin_Url_Panel.Controls.Add(App_AdminPanel);

                        UILabel AppnName = new UILabel
                        {
                            Size = new Size(100, 30),
                            Location = new Point(0, 0),
                            Font = font,
                            Name = "AppList_Label_" + Name,
                            Text = Name
                        };
                        AppnName.MouseDown += new MouseEventHandler(AppLIst_Add_MouseDown);

                        UISwitch AppSwitch = new UISwitch
                        {
                            Size = new Size(80, 30),
                            Location = new Point(100, 0),
                            Name = "AppList_Switch_" + Name,
                            ActiveText = "启用",
                            InActiveText = "禁用",
                            Active = Admin
                        };
                        AppSwitch.ActiveChanged += new EventHandler(AppLIst_Add_This_AdminSwitch_ActiveChanged);

                        App_AdminPanel.Controls.Add(AppnName);
                        App_AdminPanel.Controls.Add(AppSwitch);
                        void AppLIst_Add_This_AdminSwitch_ActiveChanged(object sender, EventArgs e)
                        {
                            if (AppSwitch.Active)
                            {
                                App.SetValue("Admin", true);
                            }
                            else
                            {
                                App.SetValue("Admin", false);
                            }
                        }

                        void AppLIst_Add_MouseDown(object sender, MouseEventArgs e)
                        {
                            if (e.Button == MouseButtons.Right)
                            {
                                Url_ContextMenuStrip.Show(AppnName, e.Location);
                                Url_ContextMenuStrip.ItemClicked += new ToolStripItemClickedEventHandler(ContextMenuStrip_ItemClicked);
                            }
                        }

                        void ContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
                        {
                            if (e.ClickedItem == UrlDel)
                            {
                                try
                                {
                                    Registry.LocalMachine.DeleteSubKey(@"SOFTWARE\TeacherDesktop\url\" + Path, true);
                                    this.AppList_Admin_Url_Panel.Controls.Clear();
                                    AppList_Url_Add();
                                }
                                catch (InvalidOperationException)
                                {
                                    MessageBox.Show("删除失败，请重试");
                                }
                            }
                        }

                        i++;
                    }
                }
            }
            key.Close();
        }

        private void AppList_Exe_Add()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(FontFilePath);
            Font font = new Font(pfc.Families[0].Name, 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop\exe\", true);
            string[] subKeyNames = key.GetSubKeyNames();
            var subKeyNumBer = key.GetSubKeyNames().Length;

            if (subKeyNumBer <= 0)
            {
                Font Texta = new Font(pfc.Families[0].Name, 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                UILabel Text = new UILabel
                {
                    Size = this.AppList_Admin_Exe_Panel.Size,
                    Location = new Point(0,0),
                    Font = Texta,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Name = "AppList_Label_Text",
                    Text = "暂无exe模块"
                };
                this.AppList_Admin_Exe_Panel.Controls.Add(Text);
            }
            else
            {
                foreach (string subKeyName in subKeyNames)
                {
                    int i = 0;
                    while (i < subKeyNumBer)
                    {
                        RegistryKey App = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop\exe\" + subKeyNames[i], true);
                        bool Admin = bool.Parse(App.GetValue("Admin").ToString());
                        string Name = App.GetValue("Name").ToString();

                        Console.WriteLine(Name);
                        Panel App_AdminPanel = new Panel
                        {
                            Size = new Size(200, 30),
                            Location = new Point(this.Width - 880, this.Height - 550 + 50 * i),
                            BackColor = Color.Transparent,
                            Font = font,
                            Name = "AppList_Panell_" + Name
                        };
                        this.AppList_Admin_Exe_Panel.Controls.Add(App_AdminPanel);

                        UILabel AppnName = new UILabel
                        {
                            Size = new Size(100, 30),
                            Location = new Point(0, 0),
                            Font = font,
                            Name = "AppList_Label_" + Name,
                            Text = Name
                        };
                        AppnName.MouseDown += new MouseEventHandler(AppLIst_Add_MouseDown);

                        UISwitch AppSwitch = new UISwitch
                        {
                            Size = new Size(80, 30),
                            Location = new Point(100, 0),
                            Name = "AppList_Switch_" + Name,
                            ActiveText = "启用",
                            InActiveText = "禁用",
                            Active = Admin
                        };
                        AppSwitch.ActiveChanged += new EventHandler(AppLIst_Add_This_AdminSwitch_ActiveChanged);

                        App_AdminPanel.Controls.Add(AppnName);
                        App_AdminPanel.Controls.Add(AppSwitch);
                        void AppLIst_Add_This_AdminSwitch_ActiveChanged(object sender, EventArgs e)
                        {
                            if (AppSwitch.Name == "AppList_Switch_" + subKeyName)
                            {
                                if (AppSwitch.Active)
                                {
                                    App.SetValue("Admin", true);
                                }
                                else
                                {
                                    App.SetValue("Admin", false);
                                }
                            }
                        }

                        void AppLIst_Add_MouseDown(object sender, MouseEventArgs e)
                        {
                            if (e.Button == MouseButtons.Right)
                            {
                                Exe_ContextMenuStrip.Show(AppnName, e.Location);
                                Exe_ContextMenuStrip.ItemClicked += new ToolStripItemClickedEventHandler(ContextMenuStrip_ItemClicked);
                            }
                        }

                        void ContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
                        {
                            if (e.ClickedItem == ExeDel) // 假设menuItem1是需要处理点击事件的菜单项
                            {
                                try
                                {
                                    Registry.LocalMachine.DeleteSubKey(@"SOFTWARE\TeacherDesktop\exe\" + Name, true);
                                    this.AppList_Admin_Exe_Panel.Controls.Clear();
                                    AppList_Exe_Add();
                                }
                                catch (InvalidOperationException)
                                {
                                    MessageBox.Show("删除失败，请重试");
                                }
                            }
                        }
                        i++;
                    }
                }
            }
            key.Close();
        }

        private void TabPage_MainSettings_ChangePassword_Click(object sender, EventArgs e)
        {
            AdminSetting_ChangePassword a = new AdminSetting_ChangePassword();
            a.ShowDialog();
        }

        private void AdminSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
