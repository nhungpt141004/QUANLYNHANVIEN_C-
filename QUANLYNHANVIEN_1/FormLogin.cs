using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using QUANLYNHANVIEN_1.database;
using QUANLYNHANVIEN_1.Util;
using System.Diagnostics;  // Thêm thư viện Debug

namespace QUANLYNHANVIEN_1
{
    public partial class FormLogin : Form
    {
        private const int LOGIN_SUCCESS_ADMIN = 1;
        private const int LOGIN_SUCCESS_EMPLOYEE = 2;
        private const int ACCOUNT_NOT_FOUND = -1;
        private const int WRONG_PASSWORD = -2;
        private const int DATABASE_ERROR = -3;
        private const int INVALID_ROLE = -4;

        public FormLogin()
        {
            InitializeComponent();
            jtfTaiKhoan.KeyDown += jtfTaiKhoan_KeyDown;
            jtfMatKhau.KeyDown += jtfmatKhau_KeyDown;
        }

        private void jtfTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                jtfMatKhau.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void jtfmatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDNhap.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string usernameOrEmail = jtfTaiKhoan.Text.Trim();
                string password = jtfMatKhau.Text.Trim();

                if (string.IsNullOrEmpty(usernameOrEmail) || string.IsNullOrEmpty(password))
                {
                    ShowMessage("Tài khoản và mật khẩu không được để trống!");
                    return;
                }

                string hashedPassword = HashPassword.hashPassword(password);


                if (usernameOrEmail.Contains("@"))
                {
                    LoginWithEmail(usernameOrEmail, hashedPassword);
                }
                else
                {
                    LoginWithUsername(usernameOrEmail, hashedPassword);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error during login: {ex.Message}");
                ShowMessage("Đã xảy ra lỗi không xác định. Vui lòng thử lại!");
            }
        }

        private void LoginWithUsername(string username, string hashedPassword)
        {
            try
            {
                int loginResult = CheckLoginByUsername(username, hashedPassword);
                HandleLoginResult(loginResult, username, hashedPassword);
            }
            catch (Exception ex)
            {
                ShowMessage("Đã xảy ra lỗi khi đăng nhập, lỗi trong LoginWithUsername. Vui lòng thử lại!");
            }
        }

        private void LoginWithEmail(string email, string hashedPassword)
        {
            try
            {
                int loginResult = CheckLoginByEmail(email, hashedPassword);
                HandleLoginResult(loginResult, email, hashedPassword);
            }
            catch (Exception ex)
            {
                ShowMessage("Đã xảy ra lỗi khi đăng nhập, lỗi trong LoginWithEmail. Vui lòng thử lại!");
            }
        }

        private int CheckLoginByUsername(string username, string hashedPassword)
        {
            string query = "SELECT password, role_id FROM accounts WHERE username = @identifier";
            return CheckLoginWithQuery(username, hashedPassword, query);
        }

        private int CheckLoginByEmail(string email, string hashedPassword)
        {
            string query = "SELECT password, role_id FROM accounts WHERE email = @identifier";
            return CheckLoginWithQuery(email, hashedPassword, query);
        }

        private int CheckLoginWithQuery(string identifier, string hashedPassword, string query)
        {
            try
            {
                using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@identifier", identifier);

                        Debug.WriteLine($"Executing query: {query} with identifier: {identifier}");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string dbPassword = reader["password"].ToString();

                                // Kiểm tra xem role_id có phải là NULL không trước khi ép kiểu
                                int roleId = reader.IsDBNull(reader.GetOrdinal("role_id")) ? -1 : reader.GetInt32("role_id");

                                Debug.WriteLine($"Retrieved password from DB: {dbPassword}, Role: {roleId}");

                                if (hashedPassword == dbPassword)
                                {
                                    if (roleId == -1)
                                        return INVALID_ROLE;
                                    else if (roleId == 1)
                                        return LOGIN_SUCCESS_ADMIN;
                                    else if (roleId == 2)
                                        return LOGIN_SUCCESS_EMPLOYEE;
                                    else
                                        return INVALID_ROLE;
                                }
                                else
                                {
                                    return WRONG_PASSWORD;
                                }
                            }
                            else
                            {
                                return ACCOUNT_NOT_FOUND;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error executing query: {ex.Message}");
                ShowMessage("Đã xảy ra lỗi khi thực hiện truy vấn. Vui lòng thử lại!");
                return DATABASE_ERROR;
            }
        }




        private void HandleLoginResult(int loginResult, string input, string hashedPassword)
        {
            Debug.WriteLine($"Login result: {loginResult}");

            switch (loginResult)
            {
                case LOGIN_SUCCESS_ADMIN:
                    FormMain1 adminPage = new FormMain1();
                    adminPage.Show();
                    this.Hide();
                    break;

                case LOGIN_SUCCESS_EMPLOYEE:
                    FormThongtin employeePage = new FormThongtin(input, hashedPassword);
                    employeePage.Show();
                    this.Hide();
                    break;

                case ACCOUNT_NOT_FOUND:
                    ShowMessage("Tài khoản không tồn tại trong hệ thống!");
                    break;

                case WRONG_PASSWORD:
                    ShowMessage("Mật khẩu không chính xác!");
                    break;

                case DATABASE_ERROR:
                    ShowMessage("Lỗi kết nối đến cơ sở dữ liệu!");
                    break;

                case INVALID_ROLE:
                    ShowMessage("Tài khoản chưa được cấp quyền hoặc quyền hạn không phù hợp!");
                    break;

                default:
                    ShowMessage($"Đã xảy ra lỗi không xác định! (Mã lỗi: {loginResult})");
                    break;
            }
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void jcbAnHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            jtfMatKhau.UseSystemPasswordChar = !jcbAnHienMatKhau.Checked;
        }

        private void btnRegister_Click(object sender, EventArgs e) 
        {
            FormRegister form = new FormRegister();
            form.Show();
            this.Hide();
        }

    }
}
