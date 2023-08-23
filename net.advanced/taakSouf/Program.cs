namespace taakSouf
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string path = "C:\\Souf\\Output.csv";
            if (!File.Exists(path))
            {
                Application.Run(new LoginForm());
                return;
            }
            Application.Run(File.ReadAllText(path).Contains("true") ? new HomeForm() : new LoginForm());
            
        }
    }
}