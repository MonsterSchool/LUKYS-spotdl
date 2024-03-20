using lukys_spotdl.Classes;
using Newtonsoft.Json;
using System.Diagnostics;

namespace lukys_spotdl.Forms
{
    public partial class SynchronizeForm : UserControl
    {
        //--Variables
        private PlaylistManager list;
        private string cookieFilePath = "";
        private string spotifyUrl = "";
        private string name = "";
        private string folderPath = "";

        private Playlist selectedPlaylist;

        public SynchronizeForm()
        {
            InitializeComponent();

            //--Try to read the config
            loadPlaylistsFromConfig();
        }

        private void playlistSelect_SelectedItemChanged(object sender, EventArgs e)
        {
            //--Get the current selected Playlist matching to the index from the config-file
            foreach (Playlist item in list.playlist_list)
            {
                if (UpDownPlaylist.SelectedItem.ToString().StartsWith(item.index + ". "))
                {
                    selectedPlaylist = item;
                }
            }

            //--Setting variables
            spotifyUrl = selectedPlaylist.playlistSpotifyUrl;
            name = selectedPlaylist.playlistName;
            folderPath = selectedPlaylist.playlistFolderPath;
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            readPlaylistsFromConfig();
        }

        private void btnCookies_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    cookieFilePath = openFileDialog.FileName;
                    txbCookies.Text = cookieFilePath;
                }
            }
        }
        private void btnStartDownload_Click(object sender, EventArgs e)
        {
            if (cookieFilePath == "" | spotifyUrl == "" | name == "" | folderPath == "")
            {
                MessageBox.Show("Not all text fields are filled in. Fill in all fields so that the sync can be started.", "Information is missing!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Thread bgThread = new Thread(() => executeSyncCommand());
                bgThread.Start();
            }
        }

        //--Misc Methods
        /// <summary>
        /// This Method is used when initializing the form to load (if avilable) the playlists from the config-file.
        /// </summary>
        private void loadPlaylistsFromConfig()
        {
            //--Check if config-File exsists
            if (File.Exists(Properties.Settings.Default.configPath))
            {
                //--Read config-File
                string fileContent = File.ReadAllText(Properties.Settings.Default.configPath);

                try
                {
                    //--Deserialize the config
                    list = JsonConvert.DeserializeObject<PlaylistManager>(fileContent);

                    //--Add each Playlist from the Config to the DomainUpDown
                    foreach (Playlist playlist in list.playlist_list)
                    {
                        UpDownPlaylist.Items.Add(playlist.index + ". " + playlist.playlistName + " : " + playlist.creationDate.ToShortDateString());
                    }

                    UpDownPlaylist.DownButton();
                }
                catch (Exception) { }
            }
        }

        /// <summary>
        /// This Method trys to read the Playlists from the Config-file if the user forces a new Read-In.
        /// </summary>
        private void readPlaylistsFromConfig()
        {
            //--Check if config-File exsists
            if (File.Exists(Properties.Settings.Default.configPath))
            {
                //--Read config-File
                string fileContent = File.ReadAllText(Properties.Settings.Default.configPath);

                try
                {
                    //--Deserialize the config
                    list = JsonConvert.DeserializeObject<PlaylistManager>(fileContent);

                    //--Delete all Items from the DomainUpDown-Container
                    UpDownPlaylist.Items.Clear();

                    //--Add each Playlist from the Config to the DomainUpDown
                    foreach (Playlist playlist in list.playlist_list)
                    {
                        UpDownPlaylist.Items.Add(playlist.index + ". " + playlist.playlistName + " : " + playlist.creationDate.ToShortDateString());
                    }
                }
                catch (Exception eX)
                {
                    MessageBox.Show("The config could not be read: " + eX.Message, "Config error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Download your first playlist to be able to synchronize it here", "There are no saved playlists yet!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void executeSyncCommand()
        {
            //--Check the folderPath and adjust if it contains whitespace
            if (folderPath.Any(Char.IsWhiteSpace))
            {
                folderPath = "\"" + folderPath + "\"";
            }

            //--Create a new Process
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;

            //--Start new Process
            cmd.Start();

            //--Change dir
            cmd.StandardInput.WriteLine("cd " + folderPath);
            cmd.StandardInput.Flush();
            Thread.Sleep(50);

            //--Start spotdl Sync
            cmd.StandardInput.WriteLine("spotdl sync \"" + name + ".sync.spotdl\"" + " --cookie-file " + cookieFilePath + " --bitrate disable --format m4a");

            //--Wait for Exit
            cmd.WaitForExit();
        }
    }
}
