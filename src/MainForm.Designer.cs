namespace lukys_spotdl
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabCntrl = new TabControl();
            tabPageDownload = new TabPage();
            downloadForm1 = new Forms.DownloadForm();
            tabPageSync = new TabPage();
            synchronizeForm1 = new Forms.SynchronizeForm();
            tabPageHelp = new TabPage();
            rtxbLicense = new RichTextBox();
            picBoxLogo = new PictureBox();
            lblAutor = new Label();
            lblVersion = new Label();
            tabCntrl.SuspendLayout();
            tabPageDownload.SuspendLayout();
            tabPageSync.SuspendLayout();
            tabPageHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // tabCntrl
            // 
            tabCntrl.Controls.Add(tabPageDownload);
            tabCntrl.Controls.Add(tabPageSync);
            tabCntrl.Controls.Add(tabPageHelp);
            tabCntrl.Dock = DockStyle.Fill;
            tabCntrl.Location = new Point(0, 0);
            tabCntrl.Margin = new Padding(2);
            tabCntrl.Name = "tabCntrl";
            tabCntrl.SelectedIndex = 0;
            tabCntrl.Size = new Size(584, 311);
            tabCntrl.TabIndex = 10;
            // 
            // tabPageDownload
            // 
            tabPageDownload.Controls.Add(downloadForm1);
            tabPageDownload.Location = new Point(4, 24);
            tabPageDownload.Margin = new Padding(2);
            tabPageDownload.Name = "tabPageDownload";
            tabPageDownload.Padding = new Padding(2);
            tabPageDownload.Size = new Size(576, 283);
            tabPageDownload.TabIndex = 0;
            tabPageDownload.Text = "Download";
            tabPageDownload.UseVisualStyleBackColor = true;
            // 
            // downloadForm1
            // 
            downloadForm1.Dock = DockStyle.Fill;
            downloadForm1.Location = new Point(2, 2);
            downloadForm1.Margin = new Padding(2);
            downloadForm1.Name = "downloadForm1";
            downloadForm1.Size = new Size(572, 279);
            downloadForm1.TabIndex = 0;
            // 
            // tabPageSync
            // 
            tabPageSync.Controls.Add(synchronizeForm1);
            tabPageSync.Location = new Point(4, 24);
            tabPageSync.Margin = new Padding(2);
            tabPageSync.Name = "tabPageSync";
            tabPageSync.Size = new Size(576, 283);
            tabPageSync.TabIndex = 1;
            tabPageSync.Text = "Sync";
            tabPageSync.UseVisualStyleBackColor = true;
            // 
            // synchronizeForm1
            // 
            synchronizeForm1.Dock = DockStyle.Fill;
            synchronizeForm1.Location = new Point(0, 0);
            synchronizeForm1.Margin = new Padding(2);
            synchronizeForm1.Name = "synchronizeForm1";
            synchronizeForm1.Size = new Size(576, 283);
            synchronizeForm1.TabIndex = 0;
            // 
            // tabPageHelp
            // 
            tabPageHelp.Controls.Add(rtxbLicense);
            tabPageHelp.Controls.Add(picBoxLogo);
            tabPageHelp.Controls.Add(lblAutor);
            tabPageHelp.Controls.Add(lblVersion);
            tabPageHelp.Location = new Point(4, 24);
            tabPageHelp.Name = "tabPageHelp";
            tabPageHelp.Size = new Size(576, 283);
            tabPageHelp.TabIndex = 2;
            tabPageHelp.Text = "Hilfe";
            // 
            // rtxbLicense
            // 
            rtxbLicense.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtxbLicense.BorderStyle = BorderStyle.None;
            rtxbLicense.Location = new Point(10, 90);
            rtxbLicense.Name = "rtxbLicense";
            rtxbLicense.ReadOnly = true;
            rtxbLicense.Size = new Size(560, 185);
            rtxbLicense.TabIndex = 4;
            rtxbLicense.Text = resources.GetString("rtxbLicense.Text");
            // 
            // picBoxLogo
            // 
            picBoxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picBoxLogo.Image = Properties.Resources.spotify;
            picBoxLogo.Location = new Point(510, 10);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(60, 60);
            picBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxLogo.TabIndex = 2;
            picBoxLogo.TabStop = false;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(10, 35);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(108, 15);
            lblAutor.TabIndex = 1;
            lblAutor.Text = "Autor: Max Luckert";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(10, 15);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(56, 15);
            lblVersion.TabIndex = 0;
            lblVersion.Text = "Version: -";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(tabCntrl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MinimumSize = new Size(600, 350);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LUKY - spotdl";
            Load += MainForm_Load;
            tabCntrl.ResumeLayout(false);
            tabPageDownload.ResumeLayout(false);
            tabPageSync.ResumeLayout(false);
            tabPageHelp.ResumeLayout(false);
            tabPageHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabCntrl;
        private TabPage tabPageDownload;
        private TabPage tabPageSync;
        private TabPage tabPageHelp;
        private Label lblAutor;
        private Label lblVersion;
        private RichTextBox rtxbLicense;
        private PictureBox picBoxLogo;
        private Forms.SynchronizeForm synchronizeForm1;
        private Forms.DownloadForm downloadForm1;
    }
}
