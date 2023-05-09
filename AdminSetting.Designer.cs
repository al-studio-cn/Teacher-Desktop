
namespace TDesktop
{
    partial class AdminSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSetting));
            this.TabControl_Main = new Sunny.UI.UITabControl();
            this.TabPage_MainSettings = new System.Windows.Forms.TabPage();
            this.uiRadioButtonGroup1 = new Sunny.UI.UIRadioButtonGroup();
            this.UploadBgImg = new Sunny.UI.UIButton();
            this.BingBg = new Sunny.UI.UIRadioButton();
            this.FileBg = new Sunny.UI.UIRadioButton();
            this.TabPage_MainSettings_ChangePassword = new Sunny.UI.UIButton();
            this.TabPage_MainSettings_PowerBoot = new Sunny.UI.UICheckBox();
            this.TabPage_About = new System.Windows.Forms.TabPage();
            this.TabPage_About_Group = new Sunny.UI.UICheckBoxGroup();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.TabPage_About_Github_Link_Click = new Sunny.UI.UILinkLabel();
            this.TabPage_About_Gitee_Link = new Sunny.UI.UILinkLabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.TabPage_About_Icon = new System.Windows.Forms.PictureBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.TabPage_About_Title = new Sunny.UI.UILabel();
            this.TabPage_AppList = new System.Windows.Forms.TabPage();
            this.AppList_Admin_TitleLabel = new Sunny.UI.UILabel();
            this.AppList_Admin_File_Panel = new System.Windows.Forms.Panel();
            this.AppList_Admin_Url_Panel = new System.Windows.Forms.Panel();
            this.AppList_Admin_Exe_Panel = new System.Windows.Forms.Panel();
            this.File_ContextMenuStrip = new Sunny.UI.UIContextMenuStrip();
            this.FileDel = new System.Windows.Forms.ToolStripMenuItem();
            this.Exe_ContextMenuStrip = new Sunny.UI.UIContextMenuStrip();
            this.ExeDel = new System.Windows.Forms.ToolStripMenuItem();
            this.Url_ContextMenuStrip = new Sunny.UI.UIContextMenuStrip();
            this.UrlDel = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl_Main.SuspendLayout();
            this.TabPage_MainSettings.SuspendLayout();
            this.uiRadioButtonGroup1.SuspendLayout();
            this.TabPage_About.SuspendLayout();
            this.TabPage_About_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabPage_About_Icon)).BeginInit();
            this.TabPage_AppList.SuspendLayout();
            this.File_ContextMenuStrip.SuspendLayout();
            this.Exe_ContextMenuStrip.SuspendLayout();
            this.Url_ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_Main
            // 
            this.TabControl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_Main.Controls.Add(this.TabPage_MainSettings);
            this.TabControl_Main.Controls.Add(this.TabPage_About);
            this.TabControl_Main.Controls.Add(this.TabPage_AppList);
            this.TabControl_Main.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabControl_Main.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl_Main.Frame = this;
            this.TabControl_Main.ItemSize = new System.Drawing.Size(150, 40);
            this.TabControl_Main.Location = new System.Drawing.Point(0, 35);
            this.TabControl_Main.MainPage = "";
            this.TabControl_Main.Name = "TabControl_Main";
            this.TabControl_Main.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabControl_Main.SelectedIndex = 0;
            this.TabControl_Main.Size = new System.Drawing.Size(923, 545);
            this.TabControl_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl_Main.TabIndex = 0;
            this.TabControl_Main.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // TabPage_MainSettings
            // 
            this.TabPage_MainSettings.Controls.Add(this.uiRadioButtonGroup1);
            this.TabPage_MainSettings.Controls.Add(this.TabPage_MainSettings_ChangePassword);
            this.TabPage_MainSettings.Controls.Add(this.TabPage_MainSettings_PowerBoot);
            this.TabPage_MainSettings.Location = new System.Drawing.Point(0, 40);
            this.TabPage_MainSettings.Name = "TabPage_MainSettings";
            this.TabPage_MainSettings.Size = new System.Drawing.Size(923, 505);
            this.TabPage_MainSettings.TabIndex = 0;
            this.TabPage_MainSettings.Text = "基本设置";
            this.TabPage_MainSettings.UseVisualStyleBackColor = true;
            // 
            // uiRadioButtonGroup1
            // 
            this.uiRadioButtonGroup1.Controls.Add(this.UploadBgImg);
            this.uiRadioButtonGroup1.Controls.Add(this.BingBg);
            this.uiRadioButtonGroup1.Controls.Add(this.FileBg);
            this.uiRadioButtonGroup1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiRadioButtonGroup1.Location = new System.Drawing.Point(89, 232);
            this.uiRadioButtonGroup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButtonGroup1.Name = "uiRadioButtonGroup1";
            this.uiRadioButtonGroup1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup1.Size = new System.Drawing.Size(275, 109);
            this.uiRadioButtonGroup1.TabIndex = 2;
            this.uiRadioButtonGroup1.Text = "背景设置";
            this.uiRadioButtonGroup1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UploadBgImg
            // 
            this.UploadBgImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UploadBgImg.Enabled = false;
            this.UploadBgImg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UploadBgImg.Location = new System.Drawing.Point(133, 35);
            this.UploadBgImg.MinimumSize = new System.Drawing.Size(1, 1);
            this.UploadBgImg.Name = "UploadBgImg";
            this.UploadBgImg.Size = new System.Drawing.Size(127, 29);
            this.UploadBgImg.TabIndex = 2;
            this.UploadBgImg.Text = "选择图片";
            this.UploadBgImg.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UploadBgImg.Click += new System.EventHandler(this.UploadBgImg_Click);
            // 
            // BingBg
            // 
            this.BingBg.Checked = true;
            this.BingBg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BingBg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BingBg.Location = new System.Drawing.Point(17, 70);
            this.BingBg.MinimumSize = new System.Drawing.Size(1, 1);
            this.BingBg.Name = "BingBg";
            this.BingBg.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.BingBg.Size = new System.Drawing.Size(243, 29);
            this.BingBg.TabIndex = 1;
            this.BingBg.Text = "网络图片（Bing）";
            this.BingBg.CheckedChanged += new System.EventHandler(this.BingBg_CheckedChanged);
            // 
            // FileBg
            // 
            this.FileBg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FileBg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileBg.Location = new System.Drawing.Point(17, 35);
            this.FileBg.MinimumSize = new System.Drawing.Size(1, 1);
            this.FileBg.Name = "FileBg";
            this.FileBg.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.FileBg.Size = new System.Drawing.Size(110, 29);
            this.FileBg.TabIndex = 0;
            this.FileBg.Text = "本地图片";
            this.FileBg.CheckedChanged += new System.EventHandler(this.FileBg_CheckedChanged);
            // 
            // TabPage_MainSettings_ChangePassword
            // 
            this.TabPage_MainSettings_ChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabPage_MainSettings_ChangePassword.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPage_MainSettings_ChangePassword.Location = new System.Drawing.Point(89, 134);
            this.TabPage_MainSettings_ChangePassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.TabPage_MainSettings_ChangePassword.Name = "TabPage_MainSettings_ChangePassword";
            this.TabPage_MainSettings_ChangePassword.Radius = 15;
            this.TabPage_MainSettings_ChangePassword.Size = new System.Drawing.Size(167, 49);
            this.TabPage_MainSettings_ChangePassword.TabIndex = 1;
            this.TabPage_MainSettings_ChangePassword.Text = "修改密码";
            this.TabPage_MainSettings_ChangePassword.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabPage_MainSettings_ChangePassword.Click += new System.EventHandler(this.TabPage_MainSettings_ChangePassword_Click);
            // 
            // TabPage_MainSettings_PowerBoot
            // 
            this.TabPage_MainSettings_PowerBoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabPage_MainSettings_PowerBoot.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPage_MainSettings_PowerBoot.Location = new System.Drawing.Point(89, 59);
            this.TabPage_MainSettings_PowerBoot.MinimumSize = new System.Drawing.Size(1, 1);
            this.TabPage_MainSettings_PowerBoot.Name = "TabPage_MainSettings_PowerBoot";
            this.TabPage_MainSettings_PowerBoot.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.TabPage_MainSettings_PowerBoot.Size = new System.Drawing.Size(167, 52);
            this.TabPage_MainSettings_PowerBoot.TabIndex = 0;
            this.TabPage_MainSettings_PowerBoot.Text = "开机自启动";
            this.TabPage_MainSettings_PowerBoot.CheckedChanged += new System.EventHandler(this.TabPage_MainSettings_PowerBoot_CheckedChanged);
            // 
            // TabPage_About
            // 
            this.TabPage_About.Controls.Add(this.TabPage_About_Group);
            this.TabPage_About.Controls.Add(this.TabPage_About_Github_Link_Click);
            this.TabPage_About.Controls.Add(this.TabPage_About_Gitee_Link);
            this.TabPage_About.Controls.Add(this.uiLabel2);
            this.TabPage_About.Controls.Add(this.TabPage_About_Icon);
            this.TabPage_About.Controls.Add(this.uiLabel1);
            this.TabPage_About.Controls.Add(this.TabPage_About_Title);
            this.TabPage_About.Font = new System.Drawing.Font("HarmonyOS Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPage_About.Location = new System.Drawing.Point(0, 40);
            this.TabPage_About.Name = "TabPage_About";
            this.TabPage_About.Size = new System.Drawing.Size(923, 505);
            this.TabPage_About.TabIndex = 2;
            this.TabPage_About.Text = "关于";
            this.TabPage_About.UseVisualStyleBackColor = true;
            // 
            // TabPage_About_Group
            // 
            this.TabPage_About_Group.Controls.Add(this.uiLabel3);
            this.TabPage_About_Group.FillColor = System.Drawing.Color.White;
            this.TabPage_About_Group.FillColor2 = System.Drawing.Color.Transparent;
            this.TabPage_About_Group.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabPage_About_Group.ForeColor = System.Drawing.Color.Red;
            this.TabPage_About_Group.Location = new System.Drawing.Point(162, 307);
            this.TabPage_About_Group.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPage_About_Group.MinimumSize = new System.Drawing.Size(1, 1);
            this.TabPage_About_Group.Name = "TabPage_About_Group";
            this.TabPage_About_Group.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.TabPage_About_Group.RectColor = System.Drawing.Color.Red;
            this.TabPage_About_Group.RectDisableColor = System.Drawing.Color.Maroon;
            this.TabPage_About_Group.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("TabPage_About_Group.SelectedIndexes")));
            this.TabPage_About_Group.Size = new System.Drawing.Size(588, 119);
            this.TabPage_About_Group.Style = Sunny.UI.UIStyle.Custom;
            this.TabPage_About_Group.TabIndex = 6;
            this.TabPage_About_Group.Text = "告知";
            this.TabPage_About_Group.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.Location = new System.Drawing.Point(3, 50);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(582, 40);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 0;
            this.uiLabel3.Text = "⚠如果你是购买来的，那么你被骗了，请立即退款+举报";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabPage_About_Github_Link_Click
            // 
            this.TabPage_About_Github_Link_Click.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.TabPage_About_Github_Link_Click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TabPage_About_Github_Link_Click.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabPage_About_Github_Link_Click.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.TabPage_About_Github_Link_Click.Location = new System.Drawing.Point(574, 238);
            this.TabPage_About_Github_Link_Click.Name = "TabPage_About_Github_Link_Click";
            this.TabPage_About_Github_Link_Click.Size = new System.Drawing.Size(82, 23);
            this.TabPage_About_Github_Link_Click.TabIndex = 5;
            this.TabPage_About_Github_Link_Click.TabStop = true;
            this.TabPage_About_Github_Link_Click.Text = "Github";
            this.TabPage_About_Github_Link_Click.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.TabPage_About_Github_Link_Click.Click += new System.EventHandler(this.TabPage_About_Github_Link_Click_Click);
            // 
            // TabPage_About_Gitee_Link
            // 
            this.TabPage_About_Gitee_Link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.TabPage_About_Gitee_Link.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabPage_About_Gitee_Link.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.TabPage_About_Gitee_Link.Location = new System.Drawing.Point(455, 238);
            this.TabPage_About_Gitee_Link.Name = "TabPage_About_Gitee_Link";
            this.TabPage_About_Gitee_Link.Size = new System.Drawing.Size(63, 23);
            this.TabPage_About_Gitee_Link.TabIndex = 4;
            this.TabPage_About_Gitee_Link.TabStop = true;
            this.TabPage_About_Gitee_Link.Text = "Gitee";
            this.TabPage_About_Gitee_Link.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.TabPage_About_Gitee_Link.Click += new System.EventHandler(this.TabPage_About_Gitee_Link_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(455, 189);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(201, 36);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "MIT开源协议";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabPage_About_Icon
            // 
            this.TabPage_About_Icon.Image = global::TDesktop.Properties.Resources.TDesktopx1000;
            this.TabPage_About_Icon.Location = new System.Drawing.Point(172, 82);
            this.TabPage_About_Icon.Name = "TabPage_About_Icon";
            this.TabPage_About_Icon.Size = new System.Drawing.Size(210, 194);
            this.TabPage_About_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TabPage_About_Icon.TabIndex = 2;
            this.TabPage_About_Icon.TabStop = false;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(455, 140);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(197, 49);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "作者：一只屑阿狼";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabPage_About_Title
            // 
            this.TabPage_About_Title.Font = new System.Drawing.Font("HarmonyOS Sans", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPage_About_Title.Location = new System.Drawing.Point(450, 82);
            this.TabPage_About_Title.Name = "TabPage_About_Title";
            this.TabPage_About_Title.Size = new System.Drawing.Size(211, 68);
            this.TabPage_About_Title.TabIndex = 0;
            this.TabPage_About_Title.Text = "教师桌面";
            this.TabPage_About_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabPage_AppList
            // 
            this.TabPage_AppList.Controls.Add(this.AppList_Admin_TitleLabel);
            this.TabPage_AppList.Controls.Add(this.AppList_Admin_File_Panel);
            this.TabPage_AppList.Controls.Add(this.AppList_Admin_Url_Panel);
            this.TabPage_AppList.Controls.Add(this.AppList_Admin_Exe_Panel);
            this.TabPage_AppList.Location = new System.Drawing.Point(0, 40);
            this.TabPage_AppList.Name = "TabPage_AppList";
            this.TabPage_AppList.Size = new System.Drawing.Size(923, 505);
            this.TabPage_AppList.TabIndex = 3;
            this.TabPage_AppList.Text = "磁贴设置";
            this.TabPage_AppList.UseVisualStyleBackColor = true;
            // 
            // AppList_Admin_TitleLabel
            // 
            this.AppList_Admin_TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppList_Admin_TitleLabel.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppList_Admin_TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.AppList_Admin_TitleLabel.Name = "AppList_Admin_TitleLabel";
            this.AppList_Admin_TitleLabel.Size = new System.Drawing.Size(923, 46);
            this.AppList_Admin_TitleLabel.TabIndex = 3;
            this.AppList_Admin_TitleLabel.Text = "仅管理员可用选项，右键模块名可删除该模块";
            this.AppList_Admin_TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppList_Admin_File_Panel
            // 
            this.AppList_Admin_File_Panel.Location = new System.Drawing.Point(657, 49);
            this.AppList_Admin_File_Panel.Name = "AppList_Admin_File_Panel";
            this.AppList_Admin_File_Panel.Size = new System.Drawing.Size(266, 456);
            this.AppList_Admin_File_Panel.TabIndex = 2;
            // 
            // AppList_Admin_Url_Panel
            // 
            this.AppList_Admin_Url_Panel.Location = new System.Drawing.Point(336, 49);
            this.AppList_Admin_Url_Panel.Name = "AppList_Admin_Url_Panel";
            this.AppList_Admin_Url_Panel.Size = new System.Drawing.Size(267, 456);
            this.AppList_Admin_Url_Panel.TabIndex = 1;
            // 
            // AppList_Admin_Exe_Panel
            // 
            this.AppList_Admin_Exe_Panel.Location = new System.Drawing.Point(0, 49);
            this.AppList_Admin_Exe_Panel.Name = "AppList_Admin_Exe_Panel";
            this.AppList_Admin_Exe_Panel.Size = new System.Drawing.Size(284, 453);
            this.AppList_Admin_Exe_Panel.TabIndex = 0;
            // 
            // File_ContextMenuStrip
            // 
            this.File_ContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.File_ContextMenuStrip.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.File_ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.File_ContextMenuStrip.IsScaled = true;
            this.File_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileDel});
            this.File_ContextMenuStrip.Name = "ContextMenuStrip";
            this.File_ContextMenuStrip.ShowImageMargin = false;
            this.File_ContextMenuStrip.Size = new System.Drawing.Size(92, 32);
            // 
            // FileDel
            // 
            this.FileDel.Name = "FileDel";
            this.FileDel.Size = new System.Drawing.Size(91, 28);
            this.FileDel.Text = "删除";
            // 
            // Exe_ContextMenuStrip
            // 
            this.Exe_ContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Exe_ContextMenuStrip.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exe_ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Exe_ContextMenuStrip.IsScaled = true;
            this.Exe_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExeDel});
            this.Exe_ContextMenuStrip.Name = "ContextMenuStrip";
            this.Exe_ContextMenuStrip.ShowImageMargin = false;
            this.Exe_ContextMenuStrip.Size = new System.Drawing.Size(92, 32);
            // 
            // ExeDel
            // 
            this.ExeDel.Name = "ExeDel";
            this.ExeDel.Size = new System.Drawing.Size(91, 28);
            this.ExeDel.Text = "删除";
            // 
            // Url_ContextMenuStrip
            // 
            this.Url_ContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Url_ContextMenuStrip.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Url_ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Url_ContextMenuStrip.IsScaled = true;
            this.Url_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UrlDel});
            this.Url_ContextMenuStrip.Name = "ContextMenuStrip";
            this.Url_ContextMenuStrip.ShowImageMargin = false;
            this.Url_ContextMenuStrip.Size = new System.Drawing.Size(92, 32);
            // 
            // UrlDel
            // 
            this.UrlDel.Name = "UrlDel";
            this.UrlDel.Size = new System.Drawing.Size(91, 28);
            this.UrlDel.Text = "删除";
            // 
            // AdminSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(923, 580);
            this.Controls.Add(this.TabControl_Main);
            this.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainTabControl = this.TabControl_Main;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminSetting";
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Text = "管理员设置";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TitleFont = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminSetting_FormClosing);
            this.Load += new System.EventHandler(this.AdminSetting_Load);
            this.TabControl_Main.ResumeLayout(false);
            this.TabPage_MainSettings.ResumeLayout(false);
            this.uiRadioButtonGroup1.ResumeLayout(false);
            this.TabPage_About.ResumeLayout(false);
            this.TabPage_About_Group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabPage_About_Icon)).EndInit();
            this.TabPage_AppList.ResumeLayout(false);
            this.File_ContextMenuStrip.ResumeLayout(false);
            this.Exe_ContextMenuStrip.ResumeLayout(false);
            this.Url_ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITabControl TabControl_Main;
        private System.Windows.Forms.TabPage TabPage_MainSettings;
        private System.Windows.Forms.TabPage TabPage_About;
        private Sunny.UI.UICheckBox TabPage_MainSettings_PowerBoot;
        private Sunny.UI.UILinkLabel TabPage_About_Github_Link_Click;
        private Sunny.UI.UILinkLabel TabPage_About_Gitee_Link;
        private Sunny.UI.UILabel uiLabel2;
        private System.Windows.Forms.PictureBox TabPage_About_Icon;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel TabPage_About_Title;
        private Sunny.UI.UICheckBoxGroup TabPage_About_Group;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton TabPage_MainSettings_ChangePassword;
        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup1;
        private Sunny.UI.UIRadioButton BingBg;
        private Sunny.UI.UIRadioButton FileBg;
        private Sunny.UI.UIButton UploadBgImg;
        private System.Windows.Forms.TabPage TabPage_AppList;
        private System.Windows.Forms.Panel AppList_Admin_Exe_Panel;
        private System.Windows.Forms.Panel AppList_Admin_File_Panel;
        private System.Windows.Forms.Panel AppList_Admin_Url_Panel;
        private Sunny.UI.UILabel AppList_Admin_TitleLabel;
        private Sunny.UI.UIContextMenuStrip File_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileDel;
        private Sunny.UI.UIContextMenuStrip Exe_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExeDel;
        private Sunny.UI.UIContextMenuStrip Url_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem UrlDel;
    }
}