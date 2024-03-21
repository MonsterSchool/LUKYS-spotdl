using lukys_spotdl.Classes;
using Newtonsoft.Json;

namespace lukys_spotdl.Forms
{
    public partial class GenerateConfigForm : Form
    {
        //--Counter-Variable for Playlists-Index
        private int playlistIndex = 0;

        //--Variables
        private string folderPath;
        private string spotifyUrl;
        private string playlistName;

        //--PlaylistManager
        private PlaylistManager playlistManager = new PlaylistManager();

        //--Class
        public GenerateConfigForm()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    folderPath = fbd.SelectedPath;
                    txbFolderPath.Text = folderPath;
                }
            }
        }

        private void btnAddToConfig_Click(object sender, EventArgs e)
        {
            if (playlistName == "" | spotifyUrl == "" | folderPath == "")
            {
                MessageBox.Show("Not all text fields are filled in. Fill in all fields so that the download can be started.", "Information is missing!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    //--Search in the selected Folder for the spotdl-sync-file.
                    string[] files = Directory.GetFiles(folderPath, "*.sync.spotdl");

                    if (files.Length == 1)
                    {
                        //--Get FileName (Path + Name)
                        string fileName = cutStart(files[0], folderPath + "\\");

                        //--Create a new Playlist
                        Playlist tmpPlaylist = new Playlist()
                        {
                            index = playlistIndex += 1,
                            creationDate = DateTime.Now,
                            playlistFolderPath = folderPath,
                            playlistName = fileName.Split('.')[0],
                            playlistSpotifyUrl = spotifyUrl,
                        };

                        //--Add Playlist to List
                        playlistManager.playlist_list.Add(tmpPlaylist);

                        //--Add Item to the ListBox (GUI)
                        listBoxConfig.Items.Add(playlistIndex + ". " + folderPath);
                    }
                    else
                    {
                        MessageBox.Show("No playlist file found for spotdl. Make sure that there is a sync file from spotdl in the selected folder.", "No Sync-File found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error reading the specified folder", "Error reading the specified folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //--Reset Form and Variable
            txbFolderPath.Text = "";
            txbPlaylistName.Text = "";
            txbSpotifyUrl.Text = "";

            spotifyUrl = "";
            folderPath = "";
            playlistName = "";
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            writeConfigFile();
        }

        private void txbPlaylistName_TextChanged(object sender, EventArgs e)
        {
            playlistName = txbPlaylistName.Text;
        }

        private void txbSpotifyUrl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var url = new Uri(txbSpotifyUrl.Text);
                txbSpotifyUrl.BackColor = Color.White;
                spotifyUrl = txbSpotifyUrl.Text;
            }
            catch (Exception)
            {
                if (txbSpotifyUrl.Text != "")
                    txbSpotifyUrl.BackColor = Color.Red;
            }
        }

        //--Misc Methods
        private void writeConfigFile()
        {
            string configName = "";

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Save the config-file";
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.DefaultExt = ".json";
                saveFileDialog.Filter = "json (*.json)|*.json";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    configName = saveFileDialog.FileName;

                    //--Check if config-File exsists
                    if (File.Exists(configName))
                    {
                        MessageBox.Show("Make sure that the file name and file path are entered correctly. Also make sure that you have write authorisation for the desired path.", "Error writing the config", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //--Write Config to File
                        string newJsonObject = JsonConvert.SerializeObject(playlistManager);
                        File.WriteAllText(configName, newJsonObject);

                        //--Message to the user
                        MessageBox.Show("The configuration was successfully created under: " + configName, "The configuration was created successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //--Close Dialog
                        this.Close();
                    }
                }
            }
        }

        /// <summary>
        /// This Method cuts out a string from another strings beginning
        /// </summary>
        /// <param name="entireText">The entire Text</param>
        /// <param name="cutText">The start-Part of the Text which you want to cut out</param>
        /// <returns></returns>
        private string cutStart(string entireText, string cutText)
        {
            if (entireText.StartsWith(cutText))
                return entireText.Substring(cutText.Length);
            else
                return entireText;
        }
    }
}
