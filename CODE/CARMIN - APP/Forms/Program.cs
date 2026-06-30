using CARMIN___DAL.Initialization;

namespace CARMIN___APP.Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.

                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-AR");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-AR");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                ApplicationConfiguration.Initialize();

                var databaseInitializer = new SqliteDatabaseInitializer();
                databaseInitializer.EnsureInitialized();

                Application.Run(new MainForm());

            }
            catch (Exception ex)
            {
                MessageBox.Show(
        ex.InnerException?.ToString() ?? ex.ToString());
            }
            
        }
    }
}
