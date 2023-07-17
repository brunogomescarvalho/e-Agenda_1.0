using Serilog;

namespace e_Agenda.WinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
                 .WriteTo.File("log_e_Agenda.txt", rollingInterval: RollingInterval.Day, retainedFileCountLimit:1)
                 .MinimumLevel.Debug()
                 .CreateLogger();

            ApplicationConfiguration.Initialize();
            Application.Run(new TelaPrincipal());
        }
    }
}