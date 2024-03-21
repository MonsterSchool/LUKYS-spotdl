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
            using (OpenFileDialog fbD = new OpenFileDialog())
            {
                fbD.Filter = "json files (*.json)|*.json";
                fbD.RestoreDirectory = true;

                if (fbD.ShowDialog() == DialogResult.OK)
                {
                    configPath = fbD.FileName;
                    txbConfigPath.Text = configPath;

                    Properties.Settings.Default.configPath = configPath;
                }
                else
                {
                    txbConfigPath.Text = "no config selected!";
                    Properties.Settings.Default.configPath = null;
                }

                Properties.Settings.Default.Save();
            }
        }

        private void btnValidateConfig_Click(object sender, EventArgs e)
        {
            validateConfig();
        }

        private void btnUpdateSpotdl_Click(object sender, EventArgs e)
        {
            startCommandPrompt("pip install spotdl --upgrade");
        }

        private void btnGenerateConfig_Click(object sender, EventArgs e)
        {
            GenerateConfigForm generateConfigForm = new GenerateConfigForm();
            generateConfigForm.ShowDialog();
        }

        //--Misc Methods
        private void validateConfig()
        {
            if (File.Exists(Properties.Settings.Default.configPath))
            {
                //--Read config-File
                string fileContent = File.ReadAllText(Properties.Settings.Default.configPath);

                try
                {
                    JsonConvert.DeserializeObject<PlaylistManager>(fileContent);
                    MessageBox.Show("The configuration was read in successfully without errors.", "Configuration check successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception eX)
                {
                    MessageBox.Show("An error occurred while checking the configuration.\r" + eX.Message, "Configuration check failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No configuration could be found at the specified path. Downloading a playlist automatically creates a configuration.", "The configuration file could not be found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

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
