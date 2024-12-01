using System;
using MySql.Data.MySqlClient;

namespace QUANLYNHANVIEN_1.database
{
    internal class DatabaseConnection
    {
        // Chuỗi kết nối
        private string connectionString = "Server=localhost;Database=quan_ly_nhan_vien;Uid=root;Pwd=123456;";

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
                    Console.WriteLine("Kết nối thành công!");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi kết nối: " + ex.Message);
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
                    Console.WriteLine("Kết nối đã đóng.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi khi đóng kết nối: " + ex.Message);
            }
        }

        // Lấy kết nối (nếu cần dùng ở các lớp khác)
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}