namespace lukys_spotdl.Forms
{
    partial class SynchronizeForm
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
            lblInfo = new Label();
            btnStartDownload = new Button();
            lblPlaylistName = new Label();
            txbCookies = new TextBox();
            lblCookies = new Label();
            btnCookies = new Button();
            UpDownPlaylist = new DomainUpDown();
            btnRefreshList = new Button();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblInfo.ForeColor = Color.Red;
            lblInfo.Location = new Point(10, 130);
            lblInfo.Margin = new Padding(2, 0, 2, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(505, 30);
            lblInfo.TabIndex = 36;
            lblInfo.Text = "Do not close the Terminal-Window!";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStartDownload
            // 
            btnStartDownload.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStartDownload.Location = new Point(125, 100);
            btnStartDownload.Margin = new Padding(2);
            btnStartDownload.Name = "btnStartDownload";
            btnStartDownload.Size = new Size(391, 25);
            btnStartDownload.TabIndex = 35;
            btnStartDownload.Text = "Start Sync";
            btnStartDownload.UseVisualStyleBackColor = true;
            btnStartDownload.Click += btnStartDownload_Click;
            // 
            // lblPlaylistName
            // 
            lblPlaylistName.AutoSize = true;
            lblPlaylistName.Location = new Point(10, 10);
            lblPlaylistName.Margin = new Padding(2, 0, 2, 0);
            lblPlaylistName.Name = "lblPlaylistName";
            lblPlaylistName.Size = new Size(84, 15);
            lblPlaylistName.TabIndex = 33;
            lblPlaylistName.Text = "Playlist-Name:";
            // 
            // txbCookies
            // 
            txbCookies.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbCookies.Location = new Point(10, 70);
            txbCookies.Margin = new Padding(2);
            txbCookies.Name = "txbCookies";
            txbCookies.Size = new Size(410, 23);
            txbCookies.TabIndex = 32;
            // 
            // lblCookies
            // 
            lblCookies.AutoSize = true;
            lblCookies.Location = new Point(10, 55);
            lblCookies.Margin = new Padding(2, 0, 2, 0);
            lblCookies.Name = "lblCookies";
            lblCookies.Size = new Size(101, 15);
            lblCookies.TabIndex = 31;
            lblCookies.Text = "Cookies.txt-Datei:";
            // 
            // btnCookies
            // 
            btnCookies.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCookies.Location = new Point(425, 70);
            btnCookies.Margin = new Padding(2);
            btnCookies.Name = "btnCookies";
            btnCookies.Size = new Size(90, 25);
            btnCookies.TabIndex = 37;
            btnCookies.Text = "Datei öffnen";
            btnCookies.UseVisualStyleBackColor = true;
            btnCookies.Click += btnCookies_Click;
            // 
            // UpDownPlaylist
            // 
            UpDownPlaylist.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UpDownPlaylist.Location = new Point(10, 25);
            UpDownPlaylist.Margin = new Padding(2);
            UpDownPlaylist.Name = "UpDownPlaylist";
            UpDownPlaylist.ReadOnly = true;
            UpDownPlaylist.Size = new Size(505, 23);
            UpDownPlaylist.TabIndex = 38;
            UpDownPlaylist.Text = "Select Playlist";
            UpDownPlaylist.SelectedItemChanged += playlistSelect_SelectedItemChanged;
            // 
            // btnRefreshList
            // 
            btnRefreshList.Location = new Point(10, 100);
            btnRefreshList.Margin = new Padding(2);
            btnRefreshList.Name = "btnRefreshList";
            btnRefreshList.Size = new Size(111, 25);
            btnRefreshList.TabIndex = 39;
            btnRefreshList.Text = "Load Config";
            btnRefreshList.UseVisualStyleBackColor = true;
            btnRefreshList.Click += btnRefreshList_Click;
            // 
            // SynchronizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRefreshList);
            Controls.Add(UpDownPlaylist);
            Controls.Add(btnCookies);
            Controls.Add(lblInfo);
            Controls.Add(btnStartDownload);
            Controls.Add(lblPlaylistName);
            Controls.Add(txbCookies);
            Controls.Add(lblCookies);
            Margin = new Padding(2);
            Name = "SynchronizeForm";
            Size = new Size(525, 170);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private Button btnStartDownload;
        private Label lblPlaylistName;
        private TextBox txbCookies;
        private Label lblCookies;
        private Button btnCookies;
        private DomainUpDown UpDownPlaylist;
        private Button btnRefreshList;
    }
}
