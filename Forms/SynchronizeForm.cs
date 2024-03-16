using lukys_spotdl.Classes;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Xml.Linq;

namespace lukys_spotdl.Forms
{
    public partial class SynchronizeForm : UserControl
    {
        //--Variables
        private PlaylistList list;
        private string cookieFilePath = "";
        private string spotifyUrl = "";
        private string name = "";
        private string folderPath = "";

        private Playlist selectedPlaylist;

        public SynchronizeForm()
        {
            InitializeComponent();
        }

        private void playlistSelect_SelectedItemChanged(object sender, EventArgs e)
        {
            foreach (Playlist item in list.playlistList)
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
            checkConfigFile();
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
                MessageBox.Show("Nicht alle Textfelder sind ausgefüllt. Fülle alle Felder aus, damit der Download gestartet werden kann.", "Informationen fehlen!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Thread bgThread = new Thread(() => startCommandPrompt());
                bgThread.Start();
            }
        }

        //--Misc Methods
        private void checkConfigFile()
        {
            //--Check if config-File exsists
            if (File.Exists("config.json"))
            {
                //--Read config-File
                string fileContent = File.ReadAllText("config.json");

                try
                {
                    list = JsonConvert.DeserializeObject<PlaylistList>(fileContent);

                    foreach (Playlist playlist in list.playlistList)
                    {
                        UpDownPlaylist.Items.Add(playlist.index + ". " + playlist.playlistName + " : " + playlist.creationDate.ToShortDateString());
                    }                    
                }
                catch (Exception eX)
                {
                    MessageBox.Show("Die Config konnte nicht gelesen werden: " + eX.Message, "Fehler mit der Config!", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                } 
            }
            else
            {
                MessageBox.Show("Lade deine erste Playlist herunter um sie hier synchronisieren zu können", "Bisher gibt es noch keine gespeicherten Playlists!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            cmd.StandardInput.WriteLine("spotdl sync \"" + name + ".sync.spotdl\"" + " --cookie-file " + cookieFilePath + " --bitrate disable --format m4a");

            //--Wait for Exit
            cmd.WaitForExit();
        }
    }
}
