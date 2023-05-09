
namespace TDesktop
{
    partial class Firstuse_boot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firstuse_boot));
            this.FisrtUse_Panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // FisrtUse_Panel
            // 
            this.FisrtUse_Panel.BackColor = System.Drawing.Color.Transparent;
            this.FisrtUse_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FisrtUse_Panel.Location = new System.Drawing.Point(0, 35);
            this.FisrtUse_Panel.Name = "FisrtUse_Panel";
            this.FisrtUse_Panel.Size = new System.Drawing.Size(891, 502);
            this.FisrtUse_Panel.TabIndex = 0;
            this.FisrtUse_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.FisrtUse_Panel_Paint);
            // 
            // Firstuse_boot
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(891, 537);
            this.Controls.Add(this.FisrtUse_Panel);
            this.Font = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Firstuse_boot";
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.ShowTitleIcon = true;
            this.Text = "安装引导";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TitleFont = new System.Drawing.Font("HarmonyOS Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.Load += new System.EventHandler(this.Firstuse_boot_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FisrtUse_Panel;
    }
}