namespace iKBenPeanut
{
    //If you seem to be having trouble like, 'Skybound' not found, then remove the library from the refrences, and re-add it,
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Loader = new System.Windows.Forms.WebBrowser();
            this.CMStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReloadClientBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.CMStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Loader
            // 
            this.Loader.ContextMenuStrip = this.CMStrip;
            this.Loader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Loader.IsWebBrowserContextMenuEnabled = false;
            this.Loader.Location = new System.Drawing.Point(0, 0);
            this.Loader.MinimumSize = new System.Drawing.Size(20, 20);
            this.Loader.Name = "Loader";
            this.Loader.ScriptErrorsSuppressed = true;
            this.Loader.ScrollBarsEnabled = false;
            this.Loader.Size = new System.Drawing.Size(680, 503);
            this.Loader.TabIndex = 0;
            this.Loader.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Loader_DocumentCompleted);
            // 
            // CMStrip
            // 
            this.CMStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReloadClientBtn,
            this.SettingsBtn});
            this.CMStrip.Name = "CMStrip";
            this.CMStrip.Size = new System.Drawing.Size(145, 48);
            // 
            // ReloadClientBtn
            // 
            this.ReloadClientBtn.Name = "ReloadClientBtn";
            this.ReloadClientBtn.Size = new System.Drawing.Size(144, 22);
            this.ReloadClientBtn.Text = "Reload Client";
            this.ReloadClientBtn.Click += new System.EventHandler(this.ReloadClientBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(144, 22);
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 503);
            this.Controls.Add(this.Loader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iKBenPeanut ~ 0[1]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.CMStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser Loader;
        private System.Windows.Forms.ContextMenuStrip CMStrip;
        private System.Windows.Forms.ToolStripMenuItem ReloadClientBtn;
        private System.Windows.Forms.ToolStripMenuItem SettingsBtn;

    }
}