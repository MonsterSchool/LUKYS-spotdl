namespace lukys_spotdl.Forms
{
    partial class DownloadForm
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            btnStartDownload = new Button();
            txbPlaylistName = new TextBox();
            lblPlaylistName = new Label();
            btnSelectCookies = new Button();
            txbCookies = new TextBox();
            lblCookies = new Label();
            txbSpotifyUrl = new TextBox();
            lblSpotifyUrl = new Label();
            lblInfo = new Label();
            lblDestFolder = new Label();
            txbDestFolder = new TextBox();
            btnSelectFolder = new Button();
            SuspendLayout();
            // 
            // btnStartDownload
            // 
            btnStartDownload.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStartDownload.Location = new Point(10, 185);
            btnStartDownload.Margin = new Padding(2);
            btnStartDownload.Name = "btnStartDownload";
            btnStartDownload.Size = new Size(505, 27);
            btnStartDownload.TabIndex = 29;
            btnStartDownload.Text = "Start Download";
            btnStartDownload.UseVisualStyleBackColor = true;
            btnStartDownload.Click += btnStartDownload_Click;
            // 
            // txbPlaylistName
            // 
            txbPlaylistName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbPlaylistName.Location = new Point(10, 155);
            txbPlaylistName.Margin = new Padding(2);
            txbPlaylistName.Name = "txbPlaylistName";
            txbPlaylistName.Size = new Size(505, 23);
            txbPlaylistName.TabIndex = 26;
            txbPlaylistName.TextChanged += txbPlaylistName_TextChanged;
            // 
            // lblPlaylistName
            // 
            lblPlaylistName.AutoSize = true;
            lblPlaylistName.Location = new Point(10, 140);
            lblPlaylistName.Margin = new Padding(2, 0, 2, 0);
            lblPlaylistName.Name = "lblPlaylistName";
            lblPlaylistName.Size = new Size(84, 15);
            lblPlaylistName.TabIndex = 25;
            lblPlaylistName.Text = "Playlist-Name:";
            // 
            // btnSelectCookies
            // 
            btnSelectCookies.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelectCookies.Location = new Point(425, 70);
            btnSelectCookies.Margin = new Padding(2);
            btnSelectCookies.Name = "btnSelectCookies";
            btnSelectCookies.Size = new Size(92, 25);
            btnSelectCookies.TabIndex = 24;
            btnSelectCookies.Text = "Select File";
            btnSelectCookies.UseVisualStyleBackColor = true;
            btnSelectCookies.Click += btnSelectCookies_Click;
            // 
            // txbCookies
            // 
            txbCookies.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbCookies.Location = new Point(10, 70);
            txbCookies.Margin = new Padding(2);
            txbCookies.Name = "txbCookies";
            txbCookies.Size = new Size(410, 23);
            txbCookies.TabIndex = 23;
            // 
            // lblCookies
            // 
            lblCookies.AutoSize = true;
            lblCookies.Location = new Point(10, 55);
            lblCookies.Margin = new Padding(2, 0, 2, 0);
            lblCookies.Name = "lblCookies";
            lblCookies.Size = new Size(101, 15);
            lblCookies.TabIndex = 22;
            lblCookies.Text = "Cookies.txt-Datei:";
            // 
            // txbSpotifyUrl
            // 
            txbSpotifyUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbSpotifyUrl.Location = new Point(10, 25);
            txbSpotifyUrl.Margin = new Padding(2);
            txbSpotifyUrl.Name = "txbSpotifyUrl";
            txbSpotifyUrl.Size = new Size(505, 23);
            txbSpotifyUrl.TabIndex = 21;
            txbSpotifyUrl.TextChanged += txbSpotifyUrl_TextChanged;
            // 
            // lblSpotifyUrl
            // 
            lblSpotifyUrl.AutoSize = true;
            lblSpotifyUrl.Location = new Point(10, 10);
            lblSpotifyUrl.Margin = new Padding(2, 0, 2, 0);
            lblSpotifyUrl.Name = "lblSpotifyUrl";
            lblSpotifyUrl.Size = new Size(73, 15);
            lblSpotifyUrl.TabIndex = 20;
            lblSpotifyUrl.Text = "Spotify-URL:";
            // 
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblInfo.ForeColor = Color.Red;
            lblInfo.Location = new Point(10, 220);
            lblInfo.Margin = new Padding(2, 0, 2, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(507, 25);
            lblInfo.TabIndex = 30;
            lblInfo.Text = "Do not close the Terminal-Window!";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDestFolder
            // 
            lblDestFolder.AutoSize = true;
            lblDestFolder.Location = new Point(10, 95);
            lblDestFolder.Margin = new Padding(2, 0, 2, 0);
            lblDestFolder.Name = "lblDestFolder";
            lblDestFolder.Size = new Size(106, 15);
            lblDestFolder.TabIndex = 31;
            lblDestFolder.Text = "Destination Folder:";
            // 
            // txbDestFolder
            // 
            txbDestFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbDestFolder.Location = new Point(10, 110);
            txbDestFolder.Margin = new Padding(2);
            txbDestFolder.Name = "txbDestFolder";
            txbDestFolder.Size = new Size(410, 23);
            txbDestFolder.TabIndex = 32;
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelectFolder.Location = new Point(425, 110);
            btnSelectFolder.Margin = new Padding(2);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(90, 25);
            btnSelectFolder.TabIndex = 33;
            btnSelectFolder.Text = "Select Folder";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // DownloadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSelectFolder);
            Controls.Add(txbDestFolder);
            Controls.Add(lblDestFolder);
            Controls.Add(lblInfo);
            Controls.Add(btnStartDownload);
            Controls.Add(txbPlaylistName);
            Controls.Add(lblPlaylistName);
            Controls.Add(btnSelectCookies);
            Controls.Add(txbCookies);
            Controls.Add(lblCookies);
            Controls.Add(txbSpotifyUrl);
            Controls.Add(lblSpotifyUrl);
            Margin = new Padding(2);
            Name = "DownloadForm";
            Size = new Size(525, 255);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartDownload;
        private TextBox txbPlaylistName;
        private Label lblPlaylistName;
        private Button btnSelectCookies;
        private TextBox txbCookies;
        private Label lblCookies;
        private TextBox txbSpotifyUrl;
        private Label lblSpotifyUrl;
        private Label lblInfo;
        private Label lblDestFolder;
        private TextBox txbDestFolder;
        private Button btnSelectFolder;
    }
}
