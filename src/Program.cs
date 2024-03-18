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
            // Initialize Configuration
            initializeConfig();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }

        private static void initializeConfig()
        {
            string configPath;

            if (Properties.Settings.Default.configPath.Length == 0)
            {
                configPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\config.json";
                Properties.Settings.Default.configPath = configPath;
            }
            else
            {
                configPath = Properties.Settings.Default.configPath;
            }
        }
    }
}