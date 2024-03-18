namespace lukys_spotdl
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //--Initialize Configuration
            initializeConfig();

            //--Run the Application
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }

        private static void initializeConfig()
        {
            string configPath;

            //--Check if the path to the config-file is present
            if (Properties.Settings.Default.configPath == "")
            {
                //--If not, create a new path in the current working-dir
                configPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\default-config.json";
                Properties.Settings.Default.configPath = configPath;
            }
            else
            {
                //--Get the configured path
                configPath = Properties.Settings.Default.configPath;
            }
        }
    }
}