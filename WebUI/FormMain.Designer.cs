namespace WebUI
{
    partial class FormMain
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
            this.wb_Main = new WebKit.WebKitBrowser();
            this.SuspendLayout();
            // 
            // wb_Main
            // 
            this.wb_Main.BackColor = System.Drawing.Color.White;
            this.wb_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb_Main.Location = new System.Drawing.Point(0, 0);
            this.wb_Main.Name = "wb_Main";
            this.wb_Main.Size = new System.Drawing.Size(284, 262);
            this.wb_Main.TabIndex = 1;
            this.wb_Main.Url = new System.Uri(System.Environment.CurrentDirectory + "../../../Modern_admin/index.html", System.UriKind.Absolute);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.wb_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private WebKit.WebKitBrowser wb_Main;
    }
}

