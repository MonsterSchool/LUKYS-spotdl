using lukys_spotdl.Classes;
using Newtonsoft.Json;
using System.Diagnostics;

namespace lukys_spotdl.Forms
{
    public partial class SettingsForm : UserControl
    {
        //--Variables
        private string configPath;

        //--Class
        public SettingsForm()
        {
            InitializeComponent();
            updateConfigPath();
        }

        private void btnSetConfigPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    configPath = fbd.SelectedPath + @"\config.json";
                    txbConfigPath.Text = configPath;

                    Properties.Settings.Default.configPath = configPath;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void btnValidateConfig_Click(object sender, EventArgs e)
        {
            if (File.Exists(Properties.Settings.Default.configPath))
            {
                //--Read config-File
                string fileContent = File.ReadAllText(Properties.Settings.Default.configPath);

                try
                {
                    JsonConvert.DeserializeObject<PlaylistManager>(fileContent);
                    MessageBox.Show("Die Konfiguration konnte erfolgreich und ohne Fehler eingelesen werden.", "Prüfen der Konfiguration erfolgreich!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception eX)
                {
                    MessageBox.Show("Beim Prüfen der Konfiguration ist ein Fehler aufgetreten.\r" + eX.Message, "Prüfen der Konfiguration fehlgeschlagen!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Am angegebenen Pfad konnte keine Konfiguration gefunden werden. Durch den Download einer Playlist wird automatisch eine Konfiguration erzeugt.", "Die Konfigurationsdatei konnte nicht gefunden werden!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateSpotdl_Click(object sender, EventArgs e)
        {
            startCommandPrompt("pip install spotdl --upgrade");
        }

        //--Misc Methods
        private void updateConfigPath()
        {
            configPath = Properties.Settings.Default.configPath;
            txbConfigPath.Text = Properties.Settings.Default.configPath;
        }

        private void startCommandPrompt(string pCommand)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;

            //--Start new Process
            cmd.Start();

            //--Start the update-process
            cmd.StandardInput.WriteLine(pCommand);
            cmd.StandardInput.Flush();

            //--Wait for Exit
            cmd.WaitForExit();
        }
    }
}
