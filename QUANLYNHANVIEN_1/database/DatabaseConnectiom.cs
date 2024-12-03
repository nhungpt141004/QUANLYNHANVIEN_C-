using System;
using MySql.Data.MySqlClient;

namespace QUANLYNHANVIEN_1.database
{
    internal class DatabaseConnection
    {
        // Chuỗi kết nối
        private string connectionString = "Server=localhost;Port=3306;Database=quan_ly_nhan_vien;Uid=root;Pwd=123456789;";

        // Kết nối MySQL
        private MySqlConnection connection;

        // Hàm khởi tạo
        public DatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        // Mở kết nối
        public void OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi kết nối: " + ex.Message);
                Console.WriteLine("Stack Trace: " + ex.StackTrace);
            }
        }

        // Đóng kết nối
        public void CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi khi đóng kết nối: " + ex.Message);
                Console.WriteLine("Stack Trace: " + ex.StackTrace);
            }
        }

        // Lấy kết nối (nếu cần dùng ở các lớp khác)
        public MySqlConnection GetConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                OpenConnection();
            }
            return connection;
        }
    }
}
