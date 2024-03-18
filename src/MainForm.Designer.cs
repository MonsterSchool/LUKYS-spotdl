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
            downloadForm = new Forms.DownloadForm();
            tabPageSync = new TabPage();
            synchronizeForm = new Forms.SynchronizeForm();
            tabPageSettings = new TabPage();
            settingsForm = new Forms.SettingsForm();
            tabPageAbout = new TabPage();
            rtxbLicense = new RichTextBox();
            picBoxLogo = new PictureBox();
            lblAutor = new Label();
            lblVersion = new Label();
            tabCntrl.SuspendLayout();
            tabPageDownload.SuspendLayout();
            tabPageSync.SuspendLayout();
            tabPageSettings.SuspendLayout();
            tabPageAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // tabCntrl
            // 
            tabCntrl.Controls.Add(tabPageDownload);
            tabCntrl.Controls.Add(tabPageSync);
            tabCntrl.Controls.Add(tabPageSettings);
            tabCntrl.Controls.Add(tabPageAbout);
            tabCntrl.Dock = DockStyle.Fill;
            tabCntrl.Location = new Point(0, 0);
            tabCntrl.Margin = new Padding(2);
            tabCntrl.Name = "tabCntrl";
            tabCntrl.SelectedIndex = 0;
            tabCntrl.Size = new Size(584, 311);
            tabCntrl.SizeMode = TabSizeMode.Fixed;
            tabCntrl.TabIndex = 10;
            // 
            // tabPageDownload
            // 
            tabPageDownload.Controls.Add(downloadForm);
            tabPageDownload.Location = new Point(4, 24);
            tabPageDownload.Margin = new Padding(0);
            tabPageDownload.Name = "tabPageDownload";
            tabPageDownload.Size = new Size(576, 283);
            tabPageDownload.TabIndex = 0;
            tabPageDownload.Text = "Download";
            tabPageDownload.UseVisualStyleBackColor = true;
            // 
            // downloadForm
            // 
            downloadForm.BackColor = SystemColors.Control;
            downloadForm.Dock = DockStyle.Fill;
            downloadForm.Location = new Point(0, 0);
            downloadForm.Margin = new Padding(0);
            downloadForm.Name = "downloadForm";
            downloadForm.Size = new Size(576, 283);
            downloadForm.TabIndex = 0;
            // 
            // tabPageSync
            // 
            tabPageSync.Controls.Add(synchronizeForm);
            tabPageSync.Location = new Point(4, 24);
            tabPageSync.Margin = new Padding(0);
            tabPageSync.Name = "tabPageSync";
            tabPageSync.Size = new Size(576, 283);
            tabPageSync.TabIndex = 1;
            tabPageSync.Text = "Sync";
            tabPageSync.UseVisualStyleBackColor = true;
            // 
            // synchronizeForm
            // 
            synchronizeForm.BackColor = SystemColors.Control;
            synchronizeForm.Dock = DockStyle.Fill;
            synchronizeForm.Location = new Point(0, 0);
            synchronizeForm.Margin = new Padding(0);
            synchronizeForm.Name = "synchronizeForm";
            synchronizeForm.Size = new Size(576, 283);
            synchronizeForm.TabIndex = 0;
            // 
            // tabPageSettings
            // 
            tabPageSettings.Controls.Add(settingsForm);
            tabPageSettings.Location = new Point(4, 24);
            tabPageSettings.Margin = new Padding(0);
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.Size = new Size(576, 283);
            tabPageSettings.TabIndex = 3;
            tabPageSettings.Text = "Settings";
            tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // settingsForm
            // 
            settingsForm.BackColor = SystemColors.Control;
            settingsForm.Dock = DockStyle.Fill;
            settingsForm.Location = new Point(0, 0);
            settingsForm.Margin = new Padding(0);
            settingsForm.Name = "settingsForm";
            settingsForm.Size = new Size(576, 283);
            settingsForm.TabIndex = 0;
            // 
            // tabPageAbout
            // 
            tabPageAbout.Controls.Add(rtxbLicense);
            tabPageAbout.Controls.Add(picBoxLogo);
            tabPageAbout.Controls.Add(lblAutor);
            tabPageAbout.Controls.Add(lblVersion);
            tabPageAbout.Location = new Point(4, 24);
            tabPageAbout.Margin = new Padding(0);
            tabPageAbout.Name = "tabPageAbout";
            tabPageAbout.Size = new Size(576, 283);
            tabPageAbout.TabIndex = 2;
            tabPageAbout.Text = "About";
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
            MaximizeBox = false;
            MinimumSize = new Size(600, 350);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LUKY - spotdl";
            Load += MainForm_Load;
            tabCntrl.ResumeLayout(false);
            tabPageDownload.ResumeLayout(false);
            tabPageSync.ResumeLayout(false);
            tabPageSettings.ResumeLayout(false);
            tabPageAbout.ResumeLayout(false);
            tabPageAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabCntrl;
        private TabPage tabPageDownload;
        private TabPage tabPageSync;
        private TabPage tabPageAbout;
        private Label lblAutor;
        private Label lblVersion;
        private RichTextBox rtxbLicense;
        private PictureBox picBoxLogo;
        private TabPage tabPageSettings;
        private Forms.SettingsForm settingsForm;
        private Forms.DownloadForm downloadForm;
        private Forms.SynchronizeForm synchronizeForm;
    }
}
