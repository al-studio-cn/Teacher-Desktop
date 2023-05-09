using Microsoft.Win32;
using Sunny.UI;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TDesktop
{
    public partial class AppList_Add : UIForm
    {
        public string FontFilePath = @".\Resources\HarmonyOS_Sans.ttf";
        public string AppNames = "";
        public string AppPath = "";
        public string AppIconPath = "";

        public AppList_Add()
        {
            InitializeComponent();
        }

        private void AppList_Add_Load(object sender, EventArgs e)
        {
            if (File.Exists(FontFilePath))
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile(FontFilePath);
                Font TitleFont = new Font(pfc.Families[0].Name, 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                Font Font = new Font(pfc.Families[0].Name, 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));

                this.TitleFont = TitleFont;
                AppList_Add_Exe_FilePath.Font = Font;
                AppList_Add_Exe_AddButton.Font = Font;
                AppLIst_Add_AdminLabel.Font = Font;
                AppLIst_Add_AdminSwitch.Font = Font;

                AppList_Add_Url_Name_TextBox.Font = Font;
                AppList_Add_Url_TextBox.Font = Font;
                AppList_Add_Url_AdminLabel.Font = Font;
                AppList_Add_Url_Switch.Font = Font;
                AppList_Add_Url_AddButton.Font = Font;

                AppList_Add_File_FilePath.Font = Font;
                AppList_Add_File_AdminLabel.Font = Font;
                AppList_Add_File_AdminSwitch.Font = Font;
                AppList_Add_File_AddButton.Font = Font;
            }
            if (AppList_Add_Exe_FilePath.Text == "点击添加")
            {
                AppList_Add_Exe_AddButton.Enabled = false;
            }
        }

        private void AppList_Add_Exe_FilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "可执行程序文件 (*.exe)|*.exe";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                AppPath = openFileDialog.FileName;
                AppNames = Path.GetFileNameWithoutExtension(openFileDialog.SafeFileName);
                AppList_Add_Exe_FilePath.Text = AppNames;
                Icon icon = Icon.ExtractAssociatedIcon(AppPath);
                AppList_Add_Exe_IconBox.BackgroundImageLayout = ImageLayout.Zoom;
                AppList_Add_Exe_IconBox.BackgroundImage = icon.ToBitmap();
            }
            openFileDialog.Dispose();
        }

        private void AppList_Add_Exe_AddButton_Click(object sender, EventArgs e)
        {
            RegistryKey AppN = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop\exe\" + AppNames, true);
            if(AppN != null)
            {
                MessageBox.Show("已添加，请勿重复添加");
                AppList_Add_Exe_IconBox.BackgroundImage = null;
                AppList_Add_Exe_FilePath.Text = "点击添加";
            }
            else
            {
                RegistryKey App = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\TeacherDesktop\exe\" + AppNames, true);
                App.SetValue("Name", AppNames);
                App.SetValue("Path", AppPath);
                App.SetValue("Type", "exe");
                if (AppLIst_Add_AdminSwitch.Active)
                {
                    App.SetValue("Admin", true);
                }
                else
                {
                    App.SetValue("Admin", false);
                }
                MessageBox.Show("添加成功");
            }
            AppList_Add_Exe_IconBox.BackgroundImage = null;
            AppList_Add_Exe_FilePath.Text = "点击添加";
        }

        private void AppList_Add_Exe_FilePath_TextChanged(object sender, EventArgs e)
        {
            if (AppList_Add_Exe_FilePath.Text=="点击添加")
            {
                AppList_Add_Exe_AddButton.Enabled = false;
            }
            else
            {
                AppList_Add_Exe_AddButton.Enabled = true;
            }
        }

        private void AppList_Add_Url_AddButton_Click(object sender, EventArgs e)
        {
            var urlName = AppList_Add_Url_Name_TextBox.Text;
            var url = AppList_Add_Url_TextBox.Text;
            if (url != "" && urlName!="")
            {
                string pattern = @"^(https?|http)://[^\s/$.?#].[^\s]*$";
                // 创建正则表达式对象
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
                // 判断是否匹配
                bool isMatched = regex.IsMatch(url);
                if (isMatched)
                {
                    RegistryKey AppN = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop\url\" + url, true);
                    if (AppN != null)
                    {
                        MessageBox.Show("已添加，请勿重复添加");
                        AppList_Add_Url_Name_TextBox.Text = "";
                        AppList_Add_Url_TextBox.Text = "";
                        AppIconPath = "";
                    }
                    else
                    {
                        RegistryKey App = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\TeacherDesktop\url\" + url, true);
                        App.SetValue("Name", urlName);
                        App.SetValue("Path", url);
                        App.SetValue("Type", "url");
                        if (AppList_Add_Url_Switch.Active)
                        {
                            App.SetValue("Admin", true);
                        }
                        else
                        {
                            App.SetValue("Admin", false);
                        }
                        MessageBox.Show("添加成功");
                        AppList_Add_Url_Name_TextBox.Text = "";
                        AppList_Add_Url_TextBox.Text = "";
                        AppIconPath = "";
                    }
                }
                else
                {
                    MessageBox.Show("链接格式错误");
                    AppList_Add_Url_TextBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("链接不能为空");
            }
        }

        private void AppList_Add_Url_TextBox_Enter(object sender, EventArgs e)
        {
            if (AppList_Add_Url_TextBox.Text == "请输入链接")
            {
                // 清空备注信息并还原字体颜色
                AppList_Add_Url_TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
                AppList_Add_Url_TextBox.Text = "";
            }
        }

        private void AppList_Add_Url_Name_TextBox_Enter(object sender, EventArgs e)
        {
            if (AppList_Add_Url_Name_TextBox.Text == "请输入名称")
            {
                // 清空备注信息并还原字体颜色
                AppList_Add_Url_Name_TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
                AppList_Add_Url_Name_TextBox.Text = "";
            }
        }

        private void AppList_Add_File_FilePath_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件夹";
            dialog.ShowNewFolderButton = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                AppPath = dialog.SelectedPath;
                AppNames = Path.GetFileName(AppPath);
                AppList_Add_File_FilePath.Text = AppNames;
            }
            else
            {
                AppPath = "";
                AppNames = "";
                AppList_Add_File_FilePath.Text = "点击选择目录";
            }
        }

        private void AppList_Add_File_AddButton_Click(object sender, EventArgs e)
        {
            RegistryKey AppN = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\TeacherDesktop\file\" + AppNames, true);
            if (AppN != null)
            {
                MessageBox.Show("已添加，请勿重复添加");
                AppPath = "";
                AppNames = "";
                AppList_Add_File_FilePath.Text = "点击选择目录";
            }
            else
            {
                RegistryKey App = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\TeacherDesktop\file\" + AppNames, true);
                App.SetValue("Name", AppNames);
                App.SetValue("Path", AppPath);
                App.SetValue("Type", "file");
                if (AppList_Add_File_AdminSwitch.Active)
                {
                    App.SetValue("Admin", true);
                }
                else
                {
                    App.SetValue("Admin", false);
                }
                MessageBox.Show("添加成功");
                AppPath = "";
                AppNames = "";
                AppList_Add_File_FilePath.Text = "点击选择目录";
            }
        }

        private void AppList_Add_File_FilePath_TextChanged(object sender, EventArgs e)
        {
            if (AppList_Add_File_FilePath.Text == "点击选择目录")
            {
                AppList_Add_File_AddButton.Enabled = false;
            }
            else
            {
                AppList_Add_File_AddButton.Enabled = true;
            }
        }

        private void AppList_Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
