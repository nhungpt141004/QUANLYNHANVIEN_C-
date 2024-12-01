using QUANLYNHANVIEN_1.database;

namespace QUANLYNHANVIEN_1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DatabaseConnection dbConnection = new DatabaseConnection();

            //// Mở kết nối
            //dbConnection.OpenConnection();

            //// Đóng kết nối
            //dbConnection.CloseConnection();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain1());
        }
    }
}