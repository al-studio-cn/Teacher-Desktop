
namespace TDesktop
{
    partial class AppList_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppList_Add));
            this.AddlList_Add_Main = new Sunny.UI.UITabControlMenu();
            this.AppList_App_Exe = new System.Windows.Forms.TabPage();
            this.AppLIst_Add_AdminLabel = new Sunny.UI.UILabel();
            this.AppLIst_Add_AdminSwitch = new Sunny.UI.UISwitch();
            this.AppList_Add_Exe_Panel = new System.Windows.Forms.Panel();
            this.AppList_Add_Exe_IconBox = new System.Windows.Forms.PictureBox();
            this.AppList_Add_Exe_FilePath = new Sunny.UI.UILabel();
            this.AppList_Add_Exe_AddButton = new Sunny.UI.UIButton();
            this.AppList_Add_Url = new System.Windows.Forms.TabPage();
            this.AppList_Add_Url_Name_TextBox = new Sunny.UI.UITextBox();
            this.AppList_Add_Url_AddButton = new Sunny.UI.UIButton();
            this.AppList_Add_Url_Switch = new Sunny.UI.UISwitch();
            this.AppList_Add_Url_AdminLabel = new Sunny.UI.UILabel();
            this.AppList_Add_Url_TextBox = new Sunny.UI.UITextBox();
            this.AppList_Add_File = new System.Windows.Forms.TabPage();
            this.AppList_Add_File_AddButton = new Sunny.UI.UIButton();
            this.AppList_Add_File_AdminLabel = new Sunny.UI.UILabel();
            this.AppList_Add_File_AdminSwitch = new Sunny.UI.UISwitch();
            this.AppList_Add_File_FilePath = new Sunny.UI.UILabel();
            this.AddlList_Add_Main.SuspendLayout();
            this.AppList_App_Exe.SuspendLayout();
            this.AppList_Add_Exe_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppList_Add_Exe_IconBox)).BeginInit();
            this.AppList_Add_Url.SuspendLayout();
            this.AppList_Add_File.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddlList_Add_Main
            // 
            this.AddlList_Add_Main.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.AddlList_Add_Main.Controls.Add(this.AppList_App_Exe);
            this.AddlList_Add_Main.Controls.Add(this.AppList_Add_Url);
            this.AddlList_Add_Main.Controls.Add(this.AppList_Add_File);
            this.AddlList_Add_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddlList_Add_Main.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.AddlList_Add_Main.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddlList_Add_Main.Location = new System.Drawing.Point(0, 35);
            this.AddlList_Add_Main.Multiline = true;
            this.AddlList_Add_Main.Name = "AddlList_Add_Main";
            this.AddlList_Add_Main.SelectedIndex = 0;
            this.AddlList_Add_Main.Size = new System.Drawing.Size(770, 439);
            this.AddlList_Add_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.AddlList_Add_Main.TabIndex = 0;
            // 
            // AppList_App_Exe
            // 
            this.AppList_App_Exe.Controls.Add(this.AppLIst_Add_AdminLabel);
            this.AppList_App_Exe.Controls.Add(this.AppLIst_Add_AdminSwitch);
            this.AppList_App_Exe.Controls.Add(this.AppList_Add_Exe_Panel);
            this.AppList_App_Exe.Controls.Add(this.AppList_Add_Exe_FilePath);
            this.AppList_App_Exe.Controls.Add(this.AppList_Add_Exe_AddButton);
            this.AppList_App_Exe.Location = new System.Drawing.Point(201, 0);
            this.AppList_App_Exe.Name = "AppList_App_Exe";
            this.AppList_App_Exe.Size = new System.Drawing.Size(569, 439);
            this.AppList_App_Exe.TabIndex = 0;
            this.AppList_App_Exe.Text = "程序";
            this.AppList_App_Exe.UseVisualStyleBackColor = true;
            // 
            // AppLIst_Add_AdminLabel
            // 
            this.AppLIst_Add_AdminLabel.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppLIst_Add_AdminLabel.Location = new System.Drawing.Point(152, 320);
            this.AppLIst_Add_AdminLabel.Name = "AppLIst_Add_AdminLabel";
            this.AppLIst_Add_AdminLabel.Size = new System.Drawing.Size(160, 29);
            this.AppLIst_Add_AdminLabel.TabIndex = 5;
            this.AppLIst_Add_AdminLabel.Text = "仅管理员可用";
            this.AppLIst_Add_AdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AppLIst_Add_AdminSwitch
            // 
            this.AppLIst_Add_AdminSwitch.ActiveText = "启用";
            this.AppLIst_Add_AdminSwitch.Font = new System.Drawing.Font("HarmonyOS Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppLIst_Add_AdminSwitch.InActiveText = "禁用";
            this.AppLIst_Add_AdminSwitch.Location = new System.Drawing.Point(318, 320);
            this.AppLIst_Add_AdminSwitch.MinimumSize = new System.Drawing.Size(1, 1);
            this.AppLIst_Add_AdminSwitch.Name = "AppLIst_Add_AdminSwitch";
            this.AppLIst_Add_AdminSwitch.Size = new System.Drawing.Size(81, 29);
            this.AppLIst_Add_AdminSwitch.TabIndex = 4;
            // 
            // AppList_Add_Exe_Panel
            // 
            this.AppList_Add_Exe_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppList_Add_Exe_Panel.BackColor = System.Drawing.Color.Transparent;
            this.AppList_Add_Exe_Panel.Controls.Add(this.AppList_Add_Exe_IconBox);
            this.AppList_Add_Exe_Panel.Location = new System.Drawing.Point(0, 56);
            this.AppList_Add_Exe_Panel.Name = "AppList_Add_Exe_Panel";
            this.AppList_Add_Exe_Panel.Size = new System.Drawing.Size(569, 100);
            this.AppList_Add_Exe_Panel.TabIndex = 3;
            // 
            // AppList_Add_Exe_IconBox
            // 
            this.AppList_Add_Exe_IconBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppList_Add_Exe_IconBox.Location = new System.Drawing.Point(231, 0);
            this.AppList_Add_Exe_IconBox.Name = "AppList_Add_Exe_IconBox";
            this.AppList_Add_Exe_IconBox.Size = new System.Drawing.Size(103, 100);
            this.AppList_Add_Exe_IconBox.TabIndex = 2;
            this.AppList_Add_Exe_IconBox.TabStop = false;
            // 
            // AppList_Add_Exe_FilePath
            // 
            this.AppList_Add_Exe_FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AppList_Add_Exe_FilePath.Font = new System.Drawing.Font("HarmonyOS Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppList_Add_Exe_FilePath.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AppList_Add_Exe_FilePath.Location = new System.Drawing.Point(3, 198);
            this.AppList_Add_Exe_FilePath.Name = "AppList_Add_Exe_FilePath";
            this.AppList_Add_Exe_FilePath.Size = new System.Drawing.Size(563, 75);
            this.AppList_Add_Exe_FilePath.Style = Sunny.UI.UIStyle.Custom;
            this.AppList_Add_Exe_FilePath.TabIndex = 1;
            this.AppList_Add_Exe_FilePath.Text = "点击添加";
            this.AppList_Add_Exe_FilePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppList_Add_Exe_FilePath.TextChanged += new System.EventHandler(this.AppList_Add_Exe_FilePath_TextChanged);
            this.AppList_Add_Exe_FilePath.Click += new System.EventHandler(this.AppList_Add_Exe_FilePath_Click);
            // 
            // AppList_Add_Exe_AddButton
            // 
            this.AppList_Add_Exe_AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppList_Add_Exe_AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppList_Add_Exe_AddButton.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppList_Add_Exe_AddButton.Location = new System.Drawing.Point(157, 375);
            this.AppList_Add_Exe_AddButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.AppList_Add_Exe_AddButton.Name = "AppList_Add_Exe_AddButton";
            this.AppList_Add_Exe_AddButton.Size = new System.Drawing.Size(242, 41);
            this.AppList_Add_Exe_AddButton.TabIndex = 0;
            this.AppList_Add_Exe_AddButton.Text = "添加";
            this.AppList_Add_Exe_AddButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AppList_Add_Exe_AddButton.Click += new System.EventHandler(this.AppList_Add_Exe_AddButton_Click);
            // 
            // AppList_Add_Url
            // 
            this.AppList_Add_Url.Controls.Add(this.AppList_Add_Url_Name_TextBox);
            this.AppList_Add_Url.Controls.Add(this.AppList_Add_Url_AddButton);
            this.AppList_Add_Url.Controls.Add(this.AppList_Add_Url_Switch);
            this.AppList_Add_Url.Controls.Add(this.AppList_Add_Url_AdminLabel);
            this.AppList_Add_Url.Controls.Add(this.AppList_Add_Url_TextBox);
            this.AppList_Add_Url.Location = new System.Drawing.Point(201, 0);
            this.AppList_Add_Url.Name = "AppList_Add_Url";
            this.AppList_Add_Url.Size = new System.Drawing.Size(569, 439);
            this.AppList_Add_Url.TabIndex = 1;
            this.AppList_Add_Url.Text = "链接";
            this.AppList_Add_Url.UseVisualStyleBackColor = true;
            // 
            // AppList_Add_Url_Name_TextBox
            // 
            this.AppList_Add_Url_Name_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AppList_Add_Url_Name_TextBox.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppList_Add_Url_Name_TextBox.ForeColor = System.Drawing.Color.Gray;
            this.AppList_Add_Url_Name_TextBox.Location = new System.Drawing.Point(96, 100);
            this.AppList_Add_Url_Name_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppList_Add_Url_Name_TextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.AppList_Add_Url_Name_TextBox.Name = "AppList_Add_Url_Name_TextBox";
            this.AppList_Add_Url_Name_TextBox.ShowText = false;
            this.AppList_Add_Url_Name_TextBox.Size = new System.Drawing.Size(370, 48);
            this.AppList_Add_Url_Name_TextBox.Style = Sunny.UI.UIStyle.Custom;
            this.AppList_Add_Url_Name_TextBox.TabIndex = 3;
            this.AppList_Add_Url_Name_TextBox.Text = "请输入名称";
            this.AppList_Add_Url_Name_TextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppList_Add_Url_Name_TextBox.Watermark = "";
            this.AppList_Add_Url_Name_TextBox.Enter += new System.EventHandler(this.AppList_Add_Url_Name_TextBox_Enter);
            // 
            // AppList_Add_Url_AddButton
            // 
            this.AppList_Add_Url_AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppList_Add_Url_AddButton.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppList_Add_Url_AddButton.Location = new System.Drawing.Point(157, 375);
            this.AppList_Add_Url_AddButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.AppList_Add_Url_AddButton.Name = "AppList_Add_Url_AddButton";
            this.AppList_Add_Url_AddButton.Size = new System.Drawing.Size(242, 41);
            this.AppList_Add_Url_AddButton.TabIndex = 6;
            this.AppList_Add_Url_AddButton.Text = "添加";
            this.AppList_Add_Url_AddButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AppList_Add_Url_AddButton.Click += new System.EventHandler(this.AppList_Add_Url_AddButton_Click);
            // 
            // AppList_Add_Url_Switch
            // 
            this.AppList_Add_Url_Switch.ActiveText = "启用";
            this.AppList_Add_Url_Switch.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppList_Add_Url_Switch.InActiveText = "禁用";
            this.AppList_Add_Url_Switch.Location = new System.Drawing.Point(318, 320);
            this.AppList_Add_Url_Switch.MinimumSize = new System.Drawing.Size(1, 1);
            this.AppList_Add_Url_Switch.Name = "AppList_Add_Url_Switch";
            this.AppList_Add_Url_Switch.Size = new System.Drawing.Size(81, 29);
            this.AppList_Add_Url_Switch.TabIndex = 5;
            this.AppList_Add_Url_Switch.Text = "uiSwitch1";
            // 
            // AppList_Add_Url_AdminLabel
            // 
            this.AppList_Add_Url_AdminLabel.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppList_Add_Url_AdminLabel.Location = new System.Drawing.Point(152, 320);
            this.AppList_Add_Url_AdminLabel.Name = "AppList_Add_Url_AdminLabel";
            this.AppList_Add_Url_AdminLabel.Size = new System.Drawing.Size(160, 29);
            this.AppList_Add_Url_AdminLabel.TabIndex = 4;
            this.AppList_Add_Url_AdminLabel.Text = "仅管理员可用";
            this.AppList_Add_Url_AdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AppList_Add_Url_TextBox
            // 
            this.AppList_Add_Url_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AppList_Add_Url_TextBox.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppList_Add_Url_TextBox.ForeColor = System.Drawing.Color.Gray;
            this.AppList_Add_Url_TextBox.Location = new System.Drawing.Point(96, 158);
            this.AppList_Add_Url_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppList_Add_Url_TextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.AppList_Add_Url_TextBox.Name = "AppList_Add_Url_TextBox";
            this.AppList_Add_Url_TextBox.ShowText = false;
            this.AppList_Add_Url_TextBox.Size = new System.Drawing.Size(370, 48);
            this.AppList_Add_Url_TextBox.Style = Sunny.UI.UIStyle.Custom;
            this.AppList_Add_Url_TextBox.TabIndex = 1;
            this.AppList_Add_Url_TextBox.Text = "请输入链接";
            this.AppList_Add_Url_TextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppList_Add_Url_TextBox.Watermark = "";
            this.AppList_Add_Url_TextBox.Enter += new System.EventHandler(this.AppList_Add_Url_TextBox_Enter);
            // 
            // AppList_Add_File
            // 
            this.AppList_Add_File.Controls.Add(this.AppList_Add_File_AddButton);
            this.AppList_Add_File.Controls.Add(this.AppList_Add_File_AdminLabel);
            this.AppList_Add_File.Controls.Add(this.AppList_Add_File_AdminSwitch);
            this.AppList_Add_File.Controls.Add(this.AppList_Add_File_FilePath);
            this.AppList_Add_File.Location = new System.Drawing.Point(201, 0);
            this.AppList_Add_File.Name = "AppList_Add_File";
            this.AppList_Add_File.Size = new System.Drawing.Size(569, 439);
            this.AppList_Add_File.TabIndex = 2;
            this.AppList_Add_File.Text = "文件夹";
            this.AppList_Add_File.UseVisualStyleBackColor = true;
            // 
            // AppList_Add_File_AddButton
            // 
            this.AppList_Add_File_AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppList_Add_File_AddButton.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppList_Add_File_AddButton.Location = new System.Drawing.Point(157, 375);
            this.AppList_Add_File_AddButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.AppList_Add_File_AddButton.Name = "AppList_Add_File_AddButton";
            this.AppList_Add_File_AddButton.Size = new System.Drawing.Size(242, 41);
            this.AppList_Add_File_AddButton.TabIndex = 3;
            this.AppList_Add_File_AddButton.Text = "添加";
            this.AppList_Add_File_AddButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AppList_Add_File_AddButton.Click += new System.EventHandler(this.AppList_Add_File_AddButton_Click);
            // 
            // AppList_Add_File_AdminLabel
            // 
            this.AppList_Add_File_AdminLabel.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppList_Add_File_AdminLabel.Location = new System.Drawing.Point(152, 320);
            this.AppList_Add_File_AdminLabel.Name = "AppList_Add_File_AdminLabel";
            this.AppList_Add_File_AdminLabel.Size = new System.Drawing.Size(160, 29);
            this.AppList_Add_File_AdminLabel.TabIndex = 2;
            this.AppList_Add_File_AdminLabel.Text = "仅管理员可用";
            this.AppList_Add_File_AdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AppList_Add_File_AdminSwitch
            // 
            this.AppList_Add_File_AdminSwitch.ActiveText = "启用";
            this.AppList_Add_File_AdminSwitch.Font = new System.Drawing.Font("HarmonyOS Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppList_Add_File_AdminSwitch.InActiveText = "禁用";
            this.AppList_Add_File_AdminSwitch.Location = new System.Drawing.Point(318, 320);
            this.AppList_Add_File_AdminSwitch.MinimumSize = new System.Drawing.Size(1, 1);
            this.AppList_Add_File_AdminSwitch.Name = "AppList_Add_File_AdminSwitch";
            this.AppList_Add_File_AdminSwitch.Size = new System.Drawing.Size(81, 29);
            this.AppList_Add_File_AdminSwitch.TabIndex = 1;
            this.AppList_Add_File_AdminSwitch.Text = "uiSwitch1";
            // 
            // AppList_Add_File_FilePath
            // 
            this.AppList_Add_File_FilePath.Font = new System.Drawing.Font("HarmonyOS Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppList_Add_File_FilePath.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AppList_Add_File_FilePath.Location = new System.Drawing.Point(3, 130);
            this.AppList_Add_File_FilePath.Name = "AppList_Add_File_FilePath";
            this.AppList_Add_File_FilePath.Size = new System.Drawing.Size(563, 75);
            this.AppList_Add_File_FilePath.Style = Sunny.UI.UIStyle.Custom;
            this.AppList_Add_File_FilePath.TabIndex = 0;
            this.AppList_Add_File_FilePath.Text = "点击选择目录";
            this.AppList_Add_File_FilePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppList_Add_File_FilePath.TextChanged += new System.EventHandler(this.AppList_Add_File_FilePath_TextChanged);
            this.AppList_Add_File_FilePath.Click += new System.EventHandler(this.AppList_Add_File_FilePath_Click);
            // 
            // AppList_Add
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(770, 474);
            this.Controls.Add(this.AddlList_Add_Main);
            this.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppList_Add";
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Text = "添加模块";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TitleFont = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppList_Add_FormClosing);
            this.Load += new System.EventHandler(this.AppList_Add_Load);
            this.AddlList_Add_Main.ResumeLayout(false);
            this.AppList_App_Exe.ResumeLayout(false);
            this.AppList_Add_Exe_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppList_Add_Exe_IconBox)).EndInit();
            this.AppList_Add_Url.ResumeLayout(false);
            this.AppList_Add_File.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControlMenu AddlList_Add_Main;
        private System.Windows.Forms.TabPage AppList_Add_Url;
        private System.Windows.Forms.TabPage AppList_Add_File;
        private Sunny.UI.UIButton AppList_Add_Exe_AddButton;
        private System.Windows.Forms.Panel AppList_Add_Exe_Panel;
        private System.Windows.Forms.PictureBox AppList_Add_Exe_IconBox;
        private Sunny.UI.UILabel AppList_Add_Exe_FilePath;
        private Sunny.UI.UILabel AppLIst_Add_AdminLabel;
        private Sunny.UI.UISwitch AppLIst_Add_AdminSwitch;
        private System.Windows.Forms.TabPage AppList_App_Exe;
        private Sunny.UI.UITextBox AppList_Add_Url_TextBox;
        private Sunny.UI.UIButton AppList_Add_Url_AddButton;
        private Sunny.UI.UISwitch AppList_Add_Url_Switch;
        private Sunny.UI.UILabel AppList_Add_Url_AdminLabel;
        private Sunny.UI.UITextBox AppList_Add_Url_Name_TextBox;
        private Sunny.UI.UIButton AppList_Add_File_AddButton;
        private Sunny.UI.UILabel AppList_Add_File_AdminLabel;
        private Sunny.UI.UISwitch AppList_Add_File_AdminSwitch;
        private Sunny.UI.UILabel AppList_Add_File_FilePath;
    }
}