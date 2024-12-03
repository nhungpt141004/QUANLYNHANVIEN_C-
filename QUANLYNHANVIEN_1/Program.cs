using System;
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
            FormRegister formLogin = new FormRegister();

            // Đảm bảo thoát ứng dụng khi FormLogin đóng
            formLogin.FormClosing += (sender, e) =>
            {
                Application.Exit();
            };

            // Chạy ứng dụng
            Application.Run(formLogin);
        }
    }
}
