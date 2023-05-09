
namespace TDesktop
{
    partial class AdminVerify
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
            this.AdminVerify_button = new Sunny.UI.UIButton();
            this.AdminVerify_Input = new Sunny.UI.UITextBox();
            this.AdminVerify_Label = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // AdminVerify_button
            // 
            this.AdminVerify_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminVerify_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminVerify_button.Font = new System.Drawing.Font("HarmonyOS Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminVerify_button.Location = new System.Drawing.Point(166, 208);
            this.AdminVerify_button.MinimumSize = new System.Drawing.Size(1, 1);
            this.AdminVerify_button.Name = "AdminVerify_button";
            this.AdminVerify_button.Radius = 15;
            this.AdminVerify_button.Size = new System.Drawing.Size(245, 47);
            this.AdminVerify_button.TabIndex = 1;
            this.AdminVerify_button.Text = "验证";
            this.AdminVerify_button.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AdminVerify_button.Click += new System.EventHandler(this.AdminVerify_button_Click);
            // 
            // AdminVerify_Input
            // 
            this.AdminVerify_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminVerify_Input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminVerify_Input.Font = new System.Drawing.Font("HarmonyOS Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminVerify_Input.Location = new System.Drawing.Point(28, 120);
            this.AdminVerify_Input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminVerify_Input.Maximum = 16D;
            this.AdminVerify_Input.MaxLength = 16;
            this.AdminVerify_Input.Minimum = 0D;
            this.AdminVerify_Input.MinimumSize = new System.Drawing.Size(1, 16);
            this.AdminVerify_Input.Name = "AdminVerify_Input";
            this.AdminVerify_Input.PasswordChar = '✦';
            this.AdminVerify_Input.Radius = 15;
            this.AdminVerify_Input.ShowText = false;
            this.AdminVerify_Input.Size = new System.Drawing.Size(527, 50);
            this.AdminVerify_Input.TabIndex = 2;
            this.AdminVerify_Input.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminVerify_Input.Watermark = "";
            // 
            // AdminVerify_Label
            // 
            this.AdminVerify_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminVerify_Label.Font = new System.Drawing.Font("HarmonyOS Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminVerify_Label.Location = new System.Drawing.Point(28, 63);
            this.AdminVerify_Label.Name = "AdminVerify_Label";
            this.AdminVerify_Label.Size = new System.Drawing.Size(527, 36);
            this.AdminVerify_Label.TabIndex = 3;
            this.AdminVerify_Label.Text = "请输入管理员密码";
            this.AdminVerify_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminVerify
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(579, 302);
            this.Controls.Add(this.AdminVerify_Label);
            this.Controls.Add(this.AdminVerify_Input);
            this.Controls.Add(this.AdminVerify_button);
            this.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminVerify";
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Text = "管理员验证";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminVerify_FormClosing);
            this.Load += new System.EventHandler(this.AdminVerify_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton AdminVerify_button;
        private Sunny.UI.UITextBox AdminVerify_Input;
        private Sunny.UI.UILabel AdminVerify_Label;
    }
}