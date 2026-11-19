namespace Hotel_Booking
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

            if (!Hotel_Booking.Data.Database.TestConnection(out var err))
            {
                MessageBox.Show("Cannot connect to the database:\n" + err);
                return;
            }

            Application.Run(new frmMain());
        }
    }
}