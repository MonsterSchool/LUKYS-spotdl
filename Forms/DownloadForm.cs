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
                    //Get the path of specified file
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
                MessageBox.Show("Nicht alle Textfelder sind ausgefüllt. Fülle alle Felder aus, damit der Download gestartet werden kann.", "Informationen fehlen!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                writeConfigFile();
                Thread bgThread = new Thread(() => startCommandPrompt());
                bgThread.Start();
            }
        }


        //--Misc Methods
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
            if (File.Exists("config.json"))
            {
                //--Read config-File
                string fileContent = File.ReadAllText("config.json");

                if (!fileContent.Contains(jsonObject))
                {
                    try
                    {
                        //--Deserialize current Config
                        PlaylistList list = JsonConvert.DeserializeObject<PlaylistList>(fileContent);

                        //--Count up the new Index-Nr.
                        playlist.index = list.playlistList.LastOrDefault().index + 1;

                        //--Add new Playlist to the current config
                        list.playlistList.Add(playlist);

                        //--Serialize new config
                        string jsonList = JsonConvert.SerializeObject(list);

                        //--Write config to file
                        File.WriteAllText("config.json", jsonList);
                    }
                    catch (Exception eX)
                    {
                        MessageBox.Show("Es gab ein Fehler die Config-Datei zu schreiben...\r" + eX.Message, "Fehler beim Schreiben der Confi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                PlaylistList newList = new PlaylistList();
                newList.playlistList.Add(playlist);

                string newJsonObject = JsonConvert.SerializeObject(newList);
                File.WriteAllText("config.json", newJsonObject);
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
