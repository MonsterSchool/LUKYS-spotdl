using lukys_spotdl.Classes;
using Newtonsoft.Json;
using System.Diagnostics;

namespace lukys_spotdl.Forms
{
    public partial class DownloadForm : UserControl
    {
        //--Variables
        private string cookieFilePath = "";
        private string spotifyUrl = "";
        private string name = "";
        private string folderPath = "";

        //--Class
        public DownloadForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
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
                txbSpotifyUrl.BackColor = Color.Red;
            }
        }

        private void txbPlaylistName_TextChanged(object sender, EventArgs e)
        {
            name = txbPlaylistName.Text;
        }

        private void btnSelectCookies_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    cookieFilePath = openFileDialog.FileName;
                    txbCookies.Text = cookieFilePath;
                }
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    folderPath = fbd.SelectedPath;
                    txbDestFolder.Text = folderPath;
                }
            }
        }

        private void btnStartDownload_Click(object sender, EventArgs e)
        {
            if (cookieFilePath == "" | spotifyUrl == "" | name == "" | folderPath == "")
            {
                MessageBox.Show("Not all text fields are filled in. Fill in all fields so that the download can be started.", "Information is missing!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //--Check if the Playlist is already downloaded
                if (checkExistingPlaylist(deserializeConfig()).Item1 == false)
                {
                    //--Write the new Playlist to the Config
                    writeConfigFile();

                    //--Start the Download in a seperate Thread
                    Thread bgThread = new Thread(() => startCommandPrompt());
                    bgThread.Start();
                }
                else
                {
                    MessageBox.Show("This playlist has already been downloaded. Check the Sync tab to see if you can update the playlist.", "Playlist already available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        //--Misc Methods
        private PlaylistManager deserializeConfig()
        {
            PlaylistManager playlistManager = null;

            //--Check if config-File exsists
            if (File.Exists(Properties.Settings.Default.configPath))
            {
                //--Read config-File
                string fileContent = File.ReadAllText(Properties.Settings.Default.configPath);

                //--Deserialize current Config
                playlistManager = JsonConvert.DeserializeObject<PlaylistManager>(fileContent);
            }

            return playlistManager;
        }

        private Tuple<bool, int, string, string, DateTime> checkExistingPlaylist(PlaylistManager pList)
        {
            if (pList != null)
            {
                foreach (Playlist playlist in pList.playlist_list)
                {
                    if (playlist.playlistSpotifyUrl == spotifyUrl)
                    {
                        return Tuple.Create(true, playlist.index, playlist.playlistName, playlist.playlistFolderPath, playlist.creationDate);
                    }
                }

                return Tuple.Create(false, 0, "", "", DateTime.Now);
            }
            else
            {
                return Tuple.Create(false, 0, "", "", DateTime.Now);
            }
        }

        private void writeConfigFile()
        {
            //--Create Playlist & List
            Playlist playlist = new Playlist()
            {
                playlistName = name,
                playlistFolderPath = folderPath,
                playlistSpotifyUrl = spotifyUrl,
                creationDate = DateTime.Now,
            };

            string jsonObject = JsonConvert.SerializeObject(playlist);

            //--Check if config-File exsists
            if (File.Exists(Properties.Settings.Default.configPath))
            {
                //--Read config-File
                string fileContent = File.ReadAllText(Properties.Settings.Default.configPath);

                if (!fileContent.Contains(jsonObject))
                {
                    try
                    {
                        //--Deserialize current Config
                        PlaylistManager list = JsonConvert.DeserializeObject<PlaylistManager>(fileContent);

                        //--Count up the new Index-Nr.
                        playlist.index = list.playlist_list.LastOrDefault().index + 1;

                        //--Add new Playlist to the current config
                        list.playlist_list.Add(playlist);

                        //--Serialize new config
                        string jsonList = JsonConvert.SerializeObject(list);

                        //--Write config to file
                        File.WriteAllText(Properties.Settings.Default.configPath, jsonList);
                    }
                    catch (Exception eX)
                    {
                        MessageBox.Show("There was an error writing the config file...\r" + eX.Message, "Error writing the Config!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                //--Create a new Config-File
                PlaylistManager newList = new PlaylistManager();
                newList.playlist_list.Add(playlist);

                string newJsonObject = JsonConvert.SerializeObject(newList);
                File.WriteAllText(Properties.Settings.Default.configPath, newJsonObject);
            }
        }

        private void startCommandPrompt()
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;

            //--Start new Process
            cmd.Start();

            //--Change dir
            cmd.StandardInput.WriteLine("cd " + folderPath);
            cmd.StandardInput.Flush();
            Thread.Sleep(50);

            //--Start spotdl Download
            cmd.StandardInput.WriteLine("spotdl sync " + spotifyUrl + " --save-file \"" + name + ".sync.spotdl\"" + " --cookie-file " + cookieFilePath + " --bitrate disable --format m4a");

            //--Wait for Exit
            cmd.WaitForExit();

            resetForm();
        }

        private void resetForm()
        {
            //--Reset Form-Inputs
            txbCookies.Text = "";
            txbSpotifyUrl.Text = "";
            txbPlaylistName.Text = "";
            txbDestFolder.Text = "";

            //--Reset Variables
            cookieFilePath = "";
            spotifyUrl = "";
            name = "";
            folderPath = "";
        }
    }
}
