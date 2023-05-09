using System;
using System.Drawing;

namespace TDesktop
{
    partial class MainFrom
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrom));
            this.GetNew_DateTime = new System.Windows.Forms.Timer(this.components);
            this.AdminSettings_Button = new Sunny.UI.UIButton();
            this.StyleManager = new Sunny.UI.UIStyleManager(this.components);
            this.Time_Label = new Sunny.UI.UILabel();
            this.Close_MainFrom_Button = new Sunny.UI.UIButton();
            this.ButtonPane_N = new System.Windows.Forms.Panel();
            this.App_Exe_Panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OpenComputer = new Sunny.UI.UIButton();
            this.App_Url_Panel = new System.Windows.Forms.Panel();
            this.App_File_Panel = new System.Windows.Forms.Panel();
            this.AppList_addButton = new Sunny.UI.UIButton();
            this.App_Main_Text = new Sunny.UI.UILabel();
            this.ButtonPane_N.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetNew_DateTime
            // 
            this.GetNew_DateTime.Interval = 1000;
            this.GetNew_DateTime.Tick += new System.EventHandler(this.GetNew_DateTime_Tick);
            // 
            // AdminSettings_Button
            // 
            this.AdminSettings_Button.BackColor = System.Drawing.Color.Transparent;
            this.AdminSettings_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AdminSettings_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminSettings_Button.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSettings_Button.Location = new System.Drawing.Point(3, 3);
            this.AdminSettings_Button.MinimumSize = new System.Drawing.Size(1, 1);
            this.AdminSettings_Button.Name = "AdminSettings_Button";
            this.AdminSettings_Button.Radius = 12;
            this.AdminSettings_Button.Size = new System.Drawing.Size(165, 70);
            this.AdminSettings_Button.TabIndex = 1;
            this.AdminSettings_Button.Text = "程序设置";
            this.AdminSettings_Button.TipsFont = new System.Drawing.Font("HarmonyOS Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSettings_Button.Click += new System.EventHandler(this.AdminSettings_Button_Click);
            // 
            // StyleManager
            // 
            this.StyleManager.DPIScale = true;
            // 
            // Time_Label
            // 
            this.Time_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Time_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Time_Label.Font = new System.Drawing.Font("HarmonyOS Sans", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Label.ForeColor = System.Drawing.Color.White;
            this.Time_Label.Location = new System.Drawing.Point(0, 26);
            this.Time_Label.Name = "Time_Label";
            this.Time_Label.Size = new System.Drawing.Size(1920, 162);
            this.Time_Label.Style = Sunny.UI.UIStyle.Custom;
            this.Time_Label.TabIndex = 2;
            this.Time_Label.Text = "2023/5/6 20:31:38";
            this.Time_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Close_MainFrom_Button
            // 
            this.Close_MainFrom_Button.BackColor = System.Drawing.Color.Transparent;
            this.Close_MainFrom_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_MainFrom_Button.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_MainFrom_Button.Location = new System.Drawing.Point(3, 79);
            this.Close_MainFrom_Button.MinimumSize = new System.Drawing.Size(1, 1);
            this.Close_MainFrom_Button.Name = "Close_MainFrom_Button";
            this.Close_MainFrom_Button.Radius = 12;
            this.Close_MainFrom_Button.Size = new System.Drawing.Size(165, 66);
            this.Close_MainFrom_Button.TabIndex = 0;
            this.Close_MainFrom_Button.Text = "关闭程序";
            this.Close_MainFrom_Button.TipsFont = new System.Drawing.Font("HarmonyOS Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_MainFrom_Button.TouchPressClick = true;
            this.Close_MainFrom_Button.Click += new System.EventHandler(this.Close_MainFrom_Button_Click);
            // 
            // ButtonPane_N
            // 
            this.ButtonPane_N.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPane_N.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPane_N.Controls.Add(this.AdminSettings_Button);
            this.ButtonPane_N.Controls.Add(this.Close_MainFrom_Button);
            this.ButtonPane_N.Location = new System.Drawing.Point(1748, 933);
            this.ButtonPane_N.Name = "ButtonPane_N";
            this.ButtonPane_N.Size = new System.Drawing.Size(170, 148);
            this.ButtonPane_N.TabIndex = 3;
            // 
            // App_Exe_Panel
            // 
            this.App_Exe_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.App_Exe_Panel.BackColor = System.Drawing.Color.Transparent;
            this.App_Exe_Panel.Location = new System.Drawing.Point(37, 877);
            this.App_Exe_Panel.Name = "App_Exe_Panel";
            this.App_Exe_Panel.Size = new System.Drawing.Size(1674, 201);
            this.App_Exe_Panel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.OpenComputer);
            this.panel1.Location = new System.Drawing.Point(1748, 782);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 148);
            this.panel1.TabIndex = 4;
            // 
            // OpenComputer
            // 
            this.OpenComputer.BackColor = System.Drawing.Color.Transparent;
            this.OpenComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OpenComputer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenComputer.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenComputer.Location = new System.Drawing.Point(3, 3);
            this.OpenComputer.MinimumSize = new System.Drawing.Size(1, 1);
            this.OpenComputer.Name = "OpenComputer";
            this.OpenComputer.Radius = 12;
            this.OpenComputer.Size = new System.Drawing.Size(165, 142);
            this.OpenComputer.TabIndex = 1;
            this.OpenComputer.Text = "此电脑";
            this.OpenComputer.TipsFont = new System.Drawing.Font("HarmonyOS Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenComputer.Click += new System.EventHandler(this.OpenComputer_Click);
            // 
            // App_Url_Panel
            // 
            this.App_Url_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.App_Url_Panel.BackColor = System.Drawing.Color.Transparent;
            this.App_Url_Panel.Location = new System.Drawing.Point(37, 655);
            this.App_Url_Panel.Name = "App_Url_Panel";
            this.App_Url_Panel.Size = new System.Drawing.Size(1674, 201);
            this.App_Url_Panel.TabIndex = 11;
            // 
            // App_File_Panel
            // 
            this.App_File_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.App_File_Panel.BackColor = System.Drawing.Color.Transparent;
            this.App_File_Panel.Location = new System.Drawing.Point(37, 431);
            this.App_File_Panel.Name = "App_File_Panel";
            this.App_File_Panel.Size = new System.Drawing.Size(1674, 201);
            this.App_File_Panel.TabIndex = 12;
            // 
            // AppList_addButton
            // 
            this.AppList_addButton.BackColor = System.Drawing.Color.Transparent;
            this.AppList_addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppList_addButton.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppList_addButton.Location = new System.Drawing.Point(1751, 698);
            this.AppList_addButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.AppList_addButton.Name = "AppList_addButton";
            this.AppList_addButton.Radius = 25;
            this.AppList_addButton.Size = new System.Drawing.Size(165, 78);
            this.AppList_addButton.Style = Sunny.UI.UIStyle.Custom;
            this.AppList_addButton.TabIndex = 13;
            this.AppList_addButton.Text = "添加模块";
            this.AppList_addButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AppList_addButton.Click += new System.EventHandler(this.AppList_addButton_Click);
            // 
            // App_Main_Text
            // 
            this.App_Main_Text.BackColor = System.Drawing.Color.Transparent;
            this.App_Main_Text.Font = new System.Drawing.Font("HarmonyOS Sans", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App_Main_Text.ForeColor = System.Drawing.Color.Red;
            this.App_Main_Text.Location = new System.Drawing.Point(-1, 188);
            this.App_Main_Text.Name = "App_Main_Text";
            this.App_Main_Text.Size = new System.Drawing.Size(1921, 145);
            this.App_Main_Text.Style = Sunny.UI.UIStyle.Custom;
            this.App_Main_Text.TabIndex = 14;
            this.App_Main_Text.Text = "尊敬的老师，您好";
            this.App_Main_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.App_Main_Text);
            this.Controls.Add(this.AppList_addButton);
            this.Controls.Add(this.App_File_Panel);
            this.Controls.Add(this.App_Url_Panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.App_Exe_Panel);
            this.Controls.Add(this.ButtonPane_N);
            this.Controls.Add(this.Time_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrom";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教室桌面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.ButtonPane_N.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer GetNew_DateTime;
        private Sunny.UI.UIButton AdminSettings_Button;
        private Sunny.UI.UIStyleManager StyleManager;
        private void GetNew_DateTime_Tick(object sender, EventArgs e)
        {
            Time_Label.Text = DateTime.Now.ToString();
        }

        private Sunny.UI.UILabel Time_Label;
        private Sunny.UI.UIButton Close_MainFrom_Button;
        private System.Windows.Forms.Panel ButtonPane_N;
        private System.Windows.Forms.Panel App_Exe_Panel;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIButton OpenComputer;
        private System.Windows.Forms.Panel App_Url_Panel;
        private System.Windows.Forms.Panel App_File_Panel;
        private Sunny.UI.UIButton AppList_addButton;
        private Sunny.UI.UILabel App_Main_Text;
    }
}

