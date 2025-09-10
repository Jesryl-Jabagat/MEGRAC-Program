using SIR_ARCANA.Data;
using SIR_ARCANA.Forms;

namespace SIR_ARCANA
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

            try
            {
                // Try to initialize database (optional for testing)
                try
                {
                    DatabaseHelper.InitializeDatabase();
                }
                catch (Exception dbEx)
                {
                    // Database initialization failed, but continue with mock authentication
                    Console.WriteLine($"Database initialization failed: {dbEx.Message}");
                    Console.WriteLine("Application will use mock authentication for testing.");
                }
                
                // Start with login form
                Application.Run(new LoginForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to start application: {ex.Message}", "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}