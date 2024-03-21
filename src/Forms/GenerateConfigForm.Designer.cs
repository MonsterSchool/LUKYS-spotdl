namespace lukys_spotdl.Forms
{
    partial class GenerateConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateConfigForm));
            lblFolderPath = new Label();
            txbFolderPath = new TextBox();
            btnSelectFolder = new Button();
            btnAddToConfig = new Button();
            listBoxConfig = new ListBox();
            btnSaveConfig = new Button();
            txbPlaylistName = new TextBox();
            lblPlaylistName = new Label();
            txbSpotifyUrl = new TextBox();
            lblSpotifyUrl = new Label();
            SuspendLayout();
            // 
            // lblFolderPath
            // 
            lblFolderPath.AutoSize = true;
            lblFolderPath.Location = new Point(10, 10);
            lblFolderPath.Name = "lblFolderPath";
            lblFolderPath.Size = new Size(43, 15);
            lblFolderPath.TabIndex = 0;
            lblFolderPath.Text = "Folder:";
            // 
            // txbFolderPath
            // 
            txbFolderPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbFolderPath.Location = new Point(10, 25);
            txbFolderPath.Name = "txbFolderPath";
            txbFolderPath.ReadOnly = true;
            txbFolderPath.Size = new Size(385, 23);
            txbFolderPath.TabIndex = 1;
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelectFolder.Location = new Point(400, 24);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(90, 25);
            btnSelectFolder.TabIndex = 2;
            btnSelectFolder.Text = "Select Folder";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // btnAddToConfig
            // 
            btnAddToConfig.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAddToConfig.Location = new Point(10, 145);
            btnAddToConfig.Name = "btnAddToConfig";
            btnAddToConfig.Size = new Size(480, 25);
            btnAddToConfig.TabIndex = 3;
            btnAddToConfig.Text = "Add to Config";
            btnAddToConfig.UseVisualStyleBackColor = true;
            btnAddToConfig.Click += btnAddToConfig_Click;
            // 
            // listBoxConfig
            // 
            listBoxConfig.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxConfig.FormattingEnabled = true;
            listBoxConfig.ItemHeight = 15;
            listBoxConfig.Location = new Point(10, 180);
            listBoxConfig.Name = "listBoxConfig";
            listBoxConfig.Size = new Size(480, 169);
            listBoxConfig.TabIndex = 4;
            // 
            // btnSaveConfig
            // 
            btnSaveConfig.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSaveConfig.Location = new Point(10, 361);
            btnSaveConfig.Name = "btnSaveConfig";
            btnSaveConfig.Size = new Size(480, 25);
            btnSaveConfig.TabIndex = 5;
            btnSaveConfig.Text = "Save Config";
            btnSaveConfig.UseVisualStyleBackColor = true;
            btnSaveConfig.Click += btnSaveConfig_Click;
            // 
            // txbPlaylistName
            // 
            txbPlaylistName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbPlaylistName.Location = new Point(10, 70);
            txbPlaylistName.Name = "txbPlaylistName";
            txbPlaylistName.Size = new Size(480, 23);
            txbPlaylistName.TabIndex = 7;
            txbPlaylistName.TextChanged += txbPlaylistName_TextChanged;
            // 
            // lblPlaylistName
            // 
            lblPlaylistName.AutoSize = true;
            lblPlaylistName.Location = new Point(10, 55);
            lblPlaylistName.Name = "lblPlaylistName";
            lblPlaylistName.Size = new Size(84, 15);
            lblPlaylistName.TabIndex = 6;
            lblPlaylistName.Text = "Playlist-Name:";
            // 
            // txbSpotifyUrl
            // 
            txbSpotifyUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbSpotifyUrl.Location = new Point(10, 115);
            txbSpotifyUrl.Name = "txbSpotifyUrl";
            txbSpotifyUrl.Size = new Size(480, 23);
            txbSpotifyUrl.TabIndex = 9;
            txbSpotifyUrl.TextChanged += txbSpotifyUrl_TextChanged;
            // 
            // lblSpotifyUrl
            // 
            lblSpotifyUrl.AutoSize = true;
            lblSpotifyUrl.Location = new Point(10, 100);
            lblSpotifyUrl.Name = "lblSpotifyUrl";
            lblSpotifyUrl.Size = new Size(73, 15);
            lblSpotifyUrl.TabIndex = 8;
            lblSpotifyUrl.Text = "Spotify-URL:";
            // 
            // GenerateConfigForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 392);
            Controls.Add(txbSpotifyUrl);
            Controls.Add(lblSpotifyUrl);
            Controls.Add(txbPlaylistName);
            Controls.Add(lblPlaylistName);
            Controls.Add(btnSaveConfig);
            Controls.Add(listBoxConfig);
            Controls.Add(btnAddToConfig);
            Controls.Add(btnSelectFolder);
            Controls.Add(txbFolderPath);
            Controls.Add(lblFolderPath);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GenerateConfigForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generate Config";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFolderPath;
        private TextBox txbFolderPath;
        private Button btnSelectFolder;
        private Button btnAddToConfig;
        private ListBox listBoxConfig;
        private Button btnSaveConfig;
        private TextBox txbPlaylistName;
        private Label lblPlaylistName;
        private TextBox txbSpotifyUrl;
        private Label lblSpotifyUrl;
    }
}