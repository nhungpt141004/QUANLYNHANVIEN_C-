using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace QUANLYNHANVIEN_1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Khởi tạo giao diện ứng dụng
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Tạo form chính là FormLogin
            FormLogin formLogin = new FormLogin();

            // Đảm bảo thoát ứng dụng khi FormLogin đóng
            formLogin.FormClosing += (sender, e) =>
            {
                Application.Exit();
            };

            // Chạy ứng dụng
            try
            {
                Application.Run(formLogin);
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show($"Lỗi khi khởi chạy ứng dụng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine($"Error occurred while running the application: {ex.Message}");
            }

        }
    }
}
