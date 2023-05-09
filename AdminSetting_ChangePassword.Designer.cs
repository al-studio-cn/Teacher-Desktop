
namespace TDesktop
{
    partial class AdminSetting_ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSetting_ChangePassword));
            this.AdminSetting_ChangePassword_button = new Sunny.UI.UIButton();
            this.AdminSetting_ChangePassword_Input = new Sunny.UI.UITextBox();
            this.AdminSetting_ChangePassword_Label = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // AdminSetting_ChangePassword_button
            // 
            this.AdminSetting_ChangePassword_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminSetting_ChangePassword_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminSetting_ChangePassword_button.Font = new System.Drawing.Font("HarmonyOS Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSetting_ChangePassword_button.Location = new System.Drawing.Point(166, 208);
            this.AdminSetting_ChangePassword_button.MinimumSize = new System.Drawing.Size(1, 1);
            this.AdminSetting_ChangePassword_button.Name = "AdminSetting_ChangePassword_button";
            this.AdminSetting_ChangePassword_button.Radius = 15;
            this.AdminSetting_ChangePassword_button.Size = new System.Drawing.Size(245, 47);
            this.AdminSetting_ChangePassword_button.TabIndex = 1;
            this.AdminSetting_ChangePassword_button.Text = "设置";
            this.AdminSetting_ChangePassword_button.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AdminSetting_ChangePassword_button.Click += new System.EventHandler(this.AdminVerify_button_Click);
            // 
            // AdminSetting_ChangePassword_Input
            // 
            this.AdminSetting_ChangePassword_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminSetting_ChangePassword_Input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminSetting_ChangePassword_Input.Font = new System.Drawing.Font("HarmonyOS Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSetting_ChangePassword_Input.Location = new System.Drawing.Point(28, 120);
            this.AdminSetting_ChangePassword_Input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminSetting_ChangePassword_Input.Maximum = 16D;
            this.AdminSetting_ChangePassword_Input.MaxLength = 16;
            this.AdminSetting_ChangePassword_Input.Minimum = 0D;
            this.AdminSetting_ChangePassword_Input.MinimumSize = new System.Drawing.Size(1, 16);
            this.AdminSetting_ChangePassword_Input.Name = "AdminSetting_ChangePassword_Input";
            this.AdminSetting_ChangePassword_Input.PasswordChar = '✦';
            this.AdminSetting_ChangePassword_Input.Radius = 15;
            this.AdminSetting_ChangePassword_Input.ShowText = false;
            this.AdminSetting_ChangePassword_Input.Size = new System.Drawing.Size(527, 50);
            this.AdminSetting_ChangePassword_Input.TabIndex = 2;
            this.AdminSetting_ChangePassword_Input.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminSetting_ChangePassword_Input.Watermark = "";
            // 
            // AdminSetting_ChangePassword_Label
            // 
            this.AdminSetting_ChangePassword_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminSetting_ChangePassword_Label.Font = new System.Drawing.Font("HarmonyOS Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSetting_ChangePassword_Label.Location = new System.Drawing.Point(28, 63);
            this.AdminSetting_ChangePassword_Label.Name = "AdminSetting_ChangePassword_Label";
            this.AdminSetting_ChangePassword_Label.Size = new System.Drawing.Size(527, 36);
            this.AdminSetting_ChangePassword_Label.TabIndex = 3;
            this.AdminSetting_ChangePassword_Label.Text = "请输入新管理员密码";
            this.AdminSetting_ChangePassword_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminSetting_ChangePassword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(579, 302);
            this.Controls.Add(this.AdminSetting_ChangePassword_Label);
            this.Controls.Add(this.AdminSetting_ChangePassword_Input);
            this.Controls.Add(this.AdminSetting_ChangePassword_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminSetting_ChangePassword";
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Text = "更改密码";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.Load += new System.EventHandler(this.AdminVerify_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton AdminSetting_ChangePassword_button;
        private Sunny.UI.UITextBox AdminSetting_ChangePassword_Input;
        private Sunny.UI.UILabel AdminSetting_ChangePassword_Label;
    }
}