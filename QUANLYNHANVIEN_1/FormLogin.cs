using MySql.Data.MySqlClient;
using QUANLYNHANVIEN_1.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHANVIEN_1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            string input = txtUser.Text.Trim(); // Username hoặc email
            string password = txtPassword.Text.Trim(); // Mật khẩu

            // Kiểm tra nếu input hoặc password bị bỏ trống
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kết nối đến cơ sở dữ liệu
            try
            {
                // Tạo kết nối
                DatabaseConnection db = new DatabaseConnection(); // Đã tạo lớp này trước đó
                db.OpenConnection();
                MessageBox.Show("Kết nối cơ sở dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Truy vấn kiểm tra tài khoản và mật khẩu
                string query = "SELECT * FROM accounts WHERE (username = @input OR email = @input) AND password = @password";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    // Thêm tham số để tránh SQL Injection
                    cmd.Parameters.AddWithValue("@input", input);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Nếu tìm thấy tài khoản
                        {
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Hiển thị form main
                            FormMain1 formmain1 = new FormMain1();
                            formmain1.ShowDialog();

                            // Ẩn form đăng nhập hiện tại
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                // Đóng kết nối
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
