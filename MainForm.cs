using Microsoft.Win32;
using Sunny.UI;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDesktop
{
    public partial class MainFrom : Form
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(int Description, int ReservedValue);
        private bool isPreloaded;
        public string FontFilePath = @".\Resources\HarmonyOS_Sans.ttf";
        public string Alimama_ShuHeiTi_Bold = @".\Resources\Alimama_ShuHeiTi_Bold.ttf";

        #region 方法一
        /// <summary>
        /// 用于检查网络是否可以连接互联网,true表示连接成功,false表示连接失败 
        /// </summary>
        /// <returns></returns>
        public static bool IsConnectInternet()
        {
            int Description = 0;
            return InternetGetConnectedState(Description, 0);
        }
        #endregion

        // 异步加载窗口所需资源的方法
        private async Task PreloadAsync()
        {

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(FontFilePath);

            PrivateFontCollection pfca = new PrivateFontCollection();
            pfca.AddFontFile(Alimama_ShuHeiTi_Bold);
            Font DateTimeFont = new Font(pfca.Families[0].Name, 72F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            Font Msg = new Font(pfc.Families[0].Name, 48F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));

            Time_Label.Font = DateTimeFont;
            App_Main_Text.Font = Msg;
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop", true);
            string BgType = key.GetValue("BgType").ToString();
            string FlieUrl = key.GetValue("FlieUrl").ToString();

            if (BgType == "File")
            {
                if (FlieUrl != null)
                {
                    BackgroundImage = Image.FromFile(FlieUrl);
                }
                else
                {
                    key.SetValue("BgType", "Bing");
                    Application.Restart();
                }
            }

            if (BgType == "Bing")
            {
                if (IsConnectInternet() == true)
                {
                    BackgroundImage = Image.FromStream(System.Net.WebRequest.Create("https://bing.shangzhenyang.com/api/1080p").GetResponse().GetResponseStream());
                }
                else
                {
                    key.SetValue("BgType", "File");
                    Application.Restart();
                }
            }

            GetNew_DateTime.Start();
            AppList_File_Add();
            AppList_Url_Add();
            AppList_Exe_Add();
            await Task.Delay(100);

            isPreloaded = true;
        }


        public MainFrom()
        {
            InitializeComponent();
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
            App_Main_Text.Text = "模块加载中...";
             PreloadAsync();
            App_Main_Text.Text = "尊敬的老师，您好";
        }

        //创建UI/File
        private void AppList_File_Add()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(FontFilePath);
            Font font = new Font(pfc.Families[0].Name, 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));

            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop\file\", true);
            string[] subKeyNames = key.GetSubKeyNames();
            var subKeyNumBer = key.GetSubKeyNames().Length; ;

            if (subKeyNumBer <= 0)
            {
                Font Texta = new Font(pfc.Families[0].Name, 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                UILabel Text = new UILabel
                {
                    Size = this.App_File_Panel.Size,
                    Location = new Point(0, 0),
                    Font = Texta,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.White,
                    Name = "AppList_Label_Text",
                    Text = "暂无File模块"
                };
                this.App_File_Panel.Controls.Add(Text);
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
                        string Path = App.GetValue("Path").ToString();
                        string Name = App.GetValue("Name").ToString();

                        UIButton AppButton = new UIButton
                        {
                            Size = new Size(200, 200),
                            Location = new Point(0 + 230 * i, 0),
                            Font = font,
                            Name = "App_File_Button_" + Name,
                            Text = "(文件夹)\n" + Name
                        };
                        AppButton.Click += new EventHandler(App_File_Button_Click);
                        App_File_Panel.Controls.Add(AppButton);

                        void App_File_Button_Click(object sender, EventArgs e)
                        {
                            if (AppButton.Name == "App_File_Button_" + Name)
                            {
                                if (Admin == true)
                                {
                                    AdminVerify AdminVerify = new AdminVerify();
                                    DialogResult result = AdminVerify.ShowDialog();

                                    if (result == DialogResult.OK)
                                    {
                                        try
                                        {
                                            Process.Start("explorer.exe", Path);
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("启动失败" + ex);
                                        }
                                    }
                                }
                                else
                                {
                                    try
                                    {
                                        Process.Start("explorer.exe", Path);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("启动失败" + ex);
                                    }
                                }
                            }
                        }

                        i++;
                    }
                }
            }
            key.Close();
        }

        //创建UI/File
        private void AppList_Url_Add()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(FontFilePath);
            Font font = new Font(pfc.Families[0].Name, 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));

            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop\url\", true);
            string[] subKeyNames = key.GetSubKeyNames();
            var subKeyNumBer = key.GetSubKeyNames().Length;

            if (subKeyNumBer <= 0)
            {
                Font Texta = new Font(pfc.Families[0].Name, 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                UILabel Text = new UILabel
                {
                    Size = this.App_File_Panel.Size,
                    Location = new Point(0, 0),
                    Font = Texta,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.White,
                    Name = "AppList_Label_Text",
                    Text = "暂无Url模块"
                };
                this.App_Url_Panel.Controls.Add(Text);
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
                        string Path = App.GetValue("Path").ToString();
                        string Name = App.GetValue("Name").ToString();

                        Console.WriteLine(Name);

                        UIButton AppButton = new UIButton
                        {
                            Size = new Size(200, 200),
                            Location = new Point(0 + 230 * i, 0),
                            Font = font,
                            Name = "App_Url_Button_" + Name,
                            Text = "(链接)\n" + Name
                        };
                        AppButton.Click += new EventHandler(App_Url_Button_Click);

                        App_Url_Panel.Controls.Add(AppButton);
                        void App_Url_Button_Click(object sender, EventArgs e)
                        {
                            if (AppButton.Name == "App_Url_Button_" + Name)
                            {
                                if (Admin == true)
                                {
                                    AdminVerify AdminVerify = new AdminVerify();
                                    DialogResult result = AdminVerify.ShowDialog();

                                    if (result == DialogResult.OK)
                                    {
                                        try
                                        {
                                            Process.Start(Path);
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("启动失败" + ex);
                                        }
                                    }
                                }
                                else
                                {
                                    try
                                    {
                                        Process.Start(Path);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("启动失败" + ex);
                                    }
                                }
                            }
                        }
                        i++;
                    }
                }
            }
            key.Close();
        }

        //创建UI/File
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
                    Size = this.App_File_Panel.Size,
                    Location = new Point(0, 0),
                    Font = Texta,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.White,
                    Name = "AppList_Label_Text",
                    Text = "暂无Exe模块"
                };
                this.App_Exe_Panel.Controls.Add(Text);
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
                        string Path = App.GetValue("Path").ToString();
                        string Name = App.GetValue("Name").ToString();

                        if (File.Exists(Path))
                        {
                            Image AppIcon_Path = Icon.ExtractAssociatedIcon(Path).ToBitmap();

                            UIButton AppButton = new UIButton
                            {
                                Size = new Size(200, 200),
                                Location = new Point(0 + 230 * i, 0),
                                Name = "App_Exe_Button_" + Name,
                                FillColor = Color.FromArgb(100, 115, 179, 255),
                                FillColor2 = Color.FromArgb(100, 115, 179, 255),
                                BackgroundImageLayout = ImageLayout.Zoom,
                                BackgroundImage = AppIcon_Path,
                                ForeColor = Color.Black,
                                Font = font,
                                Radius = 100,
                                Text = "(程序)\n" + Name
                            };

                            AppButton.Click += new EventHandler(App_Exe_Button_Click);
                            App_Exe_Panel.Controls.Add(AppButton);

                            void App_Exe_Button_Click(object sender, EventArgs e)
                            {
                                if (AppButton.Name == "App_Exe_Button_" + Name)
                                {
                                    if (Admin == true)
                                    {
                                        AdminVerify AdminVerify = new AdminVerify();
                                        DialogResult result = AdminVerify.ShowDialog();

                                        if (result == DialogResult.OK)
                                        {
                                            try
                                            {
                                                Process.Start(Path);
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("启动失败" + ex);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        try
                                        {
                                            Process.Start(Path);
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("启动失败" + ex);
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("错误，" + Name + "路径无效");
                        }
                        i++;
                    }
                }
            }
            key.Close();
        }

        private void Close_MainFrom_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //打开设置&刷新页面
        private void AdminSettings_Button_Click(object sender, EventArgs e)
        {
            AdminVerify AdminVerify = new AdminVerify();
            DialogResult result = AdminVerify.ShowDialog();

            if (result == DialogResult.OK)
            {
                AdminSetting a = new AdminSetting();
                DialogResult b = a.ShowDialog();
                if (b == DialogResult.OK)
                {
                    App_File_Panel.Controls.Clear();
                    App_Url_Panel.Controls.Clear();
                    App_Exe_Panel.Controls.Clear();
                    AppList_File_Add();
                    AppList_Url_Add();
                    AppList_Exe_Add();
                }
            }
        }

        private void OpenComputer_Click(object sender, EventArgs e)
        {
            string myComputerPath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            System.Diagnostics.Process.Start("explorer.exe", myComputerPath);
        }

        private void AppList_addButton_Click(object sender, EventArgs e)
        {
            AdminVerify AdminVerify = new AdminVerify();
            DialogResult result = AdminVerify.ShowDialog();

            if (result == DialogResult.OK)
            {
                AppList_Add AppList_Add = new AppList_Add();
                DialogResult resulta = AppList_Add.ShowDialog();

                if (resulta == DialogResult.OK)
                {
                    App_File_Panel.Controls.Clear();
                    App_Url_Panel.Controls.Clear();
                    App_Exe_Panel.Controls.Clear();
                    AppList_File_Add();
                    AppList_Url_Add();
                    AppList_Exe_Add();
                }
            }
        }
    }
}
