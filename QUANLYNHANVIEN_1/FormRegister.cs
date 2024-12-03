using MySql.Data.MySqlClient;
using QUANLYNHANVIEN_1.database;
using System.Windows.Forms;
using System;
using System.Diagnostics;


using QUANLYNHANVIEN_1.Util;

namespace QUANLYNHANVIEN_1
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
            AddTextChangedListeners();
        }
        // Add event listeners for TextChanged on the TextBox controls
        private void AddTextChangedListeners()
        {
            TextBox[] fields = { jtfEmail, jtfSoDienThoai, jtfTaiKhoan, jtfFullName, jtfMatKhau, jtfNhapLaiMatKhau };
            foreach (var field in fields)
            {
                field.TextChanged += (sender, e) => ValidateFields();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Show();
            this.Hide();
        }
        private void cbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            jtfMatKhau.UseSystemPasswordChar = !cbHienThiMatKhau.Checked;
            jtfNhapLaiMatKhau.UseSystemPasswordChar = !cbHienThiMatKhau.Checked;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = jtfTaiKhoan.Text.Trim();
            string password = jtfMatKhau.Text.Trim();
            string confirmPassword = jtfNhapLaiMatKhau.Text.Trim();
            string fullname = jtfFullName.Text.Trim();
            string email = jtfEmail.Text.Trim();
            string phoneNumber = jtfSoDienThoai.Text.Trim();

            ValidateFields();

            if (!string.IsNullOrEmpty(lbFullNameError.Text) ||
                !string.IsNullOrEmpty(lbEmailError.Text) ||
                !string.IsNullOrEmpty(lbPhoneNumberError.Text) ||
                !string.IsNullOrEmpty(lbmkError.Text) ||
                !string.IsNullOrEmpty(lbNhapLaiMkError.Text))
            {
                return;
            }

            RegisterUser(username, password, fullname, email, phoneNumber);
        }

        // Kiểm tra hợp lệ các trường dữ liệu trên giao diện
        private void ValidateFields()
        {
            string username = jtfTaiKhoan.Text.Trim();
            string password = jtfMatKhau.Text.Trim();
            string confirmPassword = jtfNhapLaiMatKhau.Text.Trim();
            string fullname = jtfFullName.Text.Trim();
            string email = jtfEmail.Text.Trim();
            string phoneNumber = jtfSoDienThoai.Text.Trim();

            lbFullNameError.Text = string.IsNullOrEmpty(fullname) ? "Vui lòng nhập tên." : "";
            lbEmailError.Text = string.IsNullOrEmpty(email) ? "Vui lòng nhập email." : "";
            if (!string.IsNullOrEmpty(email))
            {
                ValidateEmailStrength(email);
            }

            lbPhoneNumberError.Text = string.IsNullOrEmpty(phoneNumber) ? "Vui lòng nhập số điện thoại." : "";
            if (!string.IsNullOrEmpty(phoneNumber))
            {
                ValidatePhoneNumberStrength(phoneNumber);
            }

            lbtkError.Text = string.IsNullOrEmpty(username) ? "Vui lòng nhập tài khoản." : "";
            lbmkError.Text = string.IsNullOrEmpty(password) ? "Vui lòng nhập mật khẩu." : "";
            lbNhapLaiMkError.Text = !password.Equals(confirmPassword) ? "Mật khẩu không khớp." : "";

            if (!string.IsNullOrEmpty(password))
            {
                ValidatePasswordStrength(password);
            }
        }
        private void ValidateEmailStrength(string email)
        {
            List<string> errors = ValidateEmail(email);
            if (errors.Count > 0)
            {
                lbEmailError.Text = string.Join(Environment.NewLine, errors);
            }
            else
            {
                lbEmailError.Text = "";
            }
        }
        private List<string> ValidateEmail(string email)
        {
            List<string> errors = new List<string>();
            string emailRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{3,6}$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailRegex)) // Kiểm tra email khớp với regex
            {
                errors.Add("Email không đúng định dạng.");
            }

            return errors;
        }
        // Kiểm tra định dạng số điện thoại
        private void ValidatePhoneNumberStrength(string phoneNumber)
        {
            List<string> errors = ValidatePhoneNumber(phoneNumber);
            if (errors.Count > 0)
            {
                lbPhoneNumberError.Text = string.Join(Environment.NewLine, errors);
            }
            else
            {
                lbPhoneNumberError.Text = "";
            }
        }

        // Phương thức kiểm tra số điện thoại hợp lệ
        private List<string> ValidatePhoneNumber(string phoneNumber)
        {
            List<string> errors = new List<string>();
            string phoneRegex = @"^\d{10,11}$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, phoneRegex)) // Kiểm tra định dạng
            {
                errors.Add("Số điện thoại phải có 10-11 chữ số.");
            }

            return errors;
        }
        // Kiểm tra độ mạnh của mật khẩu
        private void ValidatePasswordStrength(string password)
        {
            List<string> errors = ValidatePassword(password);
            if (errors.Count > 0)
            {
                lbmkError.Text = string.Join(Environment.NewLine, errors);
            }
            else
            {
                lbmkError.Text = "";
            }
        }

        // Xác thực mật khẩu với các tiêu chí mạnh (số, chữ hoa, chữ thường, ký tự đặc biệt, độ dài)
        private List<string> ValidatePassword(string password)
        {
            List<string> errors = new List<string>();

            // Kiểm tra xem mật khẩu có chứa ít nhất một chữ số không
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, @".*\d.*"))
            {
                errors.Add("Mật khẩu cần ít nhất một chữ số.");
            }

            // Kiểm tra xem mật khẩu có chứa ít nhất một ký tự chữ thường không
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, @".*[a-z].*"))
            {
                errors.Add("Mật khẩu cần ít nhất một ký tự chữ thường.");
            }

            // Kiểm tra xem mật khẩu có chứa ít nhất một ký tự chữ hoa không
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, @".*[A-Z].*"))
            {
                errors.Add("Mật khẩu cần ít nhất một ký tự chữ hoa.");
            }

            // Kiểm tra xem mật khẩu có chứa ít nhất một ký tự đặc biệt không
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, @".*[@$!%*?&].*"))
            {
                errors.Add("Mật khẩu cần ít nhất một ký tự đặc biệt.");
            }

            // Kiểm tra độ dài của mật khẩu
            if (password.Length < 12)
            {
                errors.Add("Mật khẩu cần ít nhất 12 ký tự.");
            }

            return errors;
        }
        public bool RegisterUser(string username, string password, string fullname, string email, string phoneNumber)
        {
            // Kiểm tra xem tài khoản đã tồn tại chưa
            if (IsUsernameTaken(username))
            {
                ShowMessage("Tài khoản đã tồn tại.", "Lỗi");
                return false;
            }
            // Kiểm tra xem số điện thoại đã tồn tại chưa
            else if (IsPhoneNumberTaken(phoneNumber))
            {
                ShowMessage("Số điện thoại đã tồn tại.", "Lỗi");
                return false;
            }
            // Kiểm tra xem email đã tồn tại chưa
            else if (IsEmailTaken(email))
            {
                ShowMessage("Email đã tồn tại.", "Lỗi");
                return false;
            }

            // Mã hóa mật khẩu
            string hashedPassword = HashPassword.hashPassword(password);

            // Thêm người dùng vào cơ sở dữ liệu
            if (AddUserToDatabase(username, hashedPassword, fullname, email, phoneNumber))
            {
                ShowMessage("Tạo tài khoản thành công!", "Thành công");
                return true;
            }
            else
            {
                ShowMessage("Không thể tạo tài khoản.", "Lỗi");
                return false;
            }
        }
        public bool IsUsernameTaken(string username)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                // Kết nối đến cơ sở dữ liệu MySQL
                conn = new DatabaseConnection().GetConnection();
                conn.Open();

                // Câu truy vấn để kiểm tra xem username đã tồn tại hay chưa
                string query = "SELECT COUNT(*) FROM accounts WHERE username = @username";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                Debug.WriteLine("Executing query to check if username exists: " + query);

                // Thực thi câu truy vấn và lấy kết quả
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Debug.WriteLine("Username exists: " + username);
                    return reader.GetInt32(0) > 0;
                }

                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error checking username: " + ex.Message);
                return false;
            }
            finally
            {
                // Đảm bảo đóng kết nối và giải phóng tài nguyên
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
            }
        }
        public bool IsPhoneNumberTaken(string phoneNumber)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                // Kết nối đến cơ sở dữ liệu MySQL
                conn = new DatabaseConnection().GetConnection();
                conn.Open();

                // Câu truy vấn để kiểm tra xem số điện thoại đã tồn tại hay chưa
                string query = "SELECT COUNT(*) FROM employees WHERE phone_number = @phoneNumber";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);

                Debug.WriteLine("Executing query to check if phone number exists: " + query);

                // Thực thi câu truy vấn và lấy kết quả
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Debug.WriteLine("Phone number exists: " + phoneNumber);
                    return reader.GetInt32(0) > 0;
                }

                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error checking phone number: " + ex.Message);
                return false;
            }
            finally
            {
                // Đảm bảo đóng kết nối và giải phóng tài nguyên
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
            }
        }
        public bool IsEmailTaken(string email)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                // Kết nối đến cơ sở dữ liệu MySQL
                conn = new DatabaseConnection().GetConnection();
                conn.Open();

                // Câu truy vấn để kiểm tra xem email đã tồn tại hay chưa
                string query = "SELECT COUNT(*) FROM employees WHERE email = @email";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);

                Debug.WriteLine("Executing query to check if email exists: " + query);

                // Thực thi câu truy vấn và lấy kết quả
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Debug.WriteLine("Email exists: " + email);
                    return reader.GetInt32(0) > 0;
                }

                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error checking email: " + ex.Message);
                return false;
            }
            finally
            {
                // Đảm bảo đóng kết nối và giải phóng tài nguyên
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
            }
        }
        public bool AddUserToDatabase(string username, string password, string fullname, string email, string phoneNumber)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd1 = null;
            MySqlCommand cmd2 = null;
            MySqlCommand cmd3 = null;

            try
            {
                Debug.WriteLine("Bắt đầu kết nối cơ sở dữ liệu...");

                conn = new DatabaseConnection().GetConnection();

                // Kiểm tra nếu kết nối đã được mở
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                using (var transaction = conn.BeginTransaction())
                {
                    Debug.WriteLine("Bắt đầu giao dịch...");

                    // Thêm employee
                    string employeeQuery = "INSERT INTO Employees (full_name, email, phone_number) VALUES (@fullname, @email, @phoneNumber)";
                    cmd1 = new MySqlCommand(employeeQuery, conn);
                    cmd1.Parameters.AddWithValue("@fullname", fullname);
                    cmd1.Parameters.AddWithValue("@email", email);
                    cmd1.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    cmd1.ExecuteNonQuery();

                    Debug.WriteLine("Đã thêm employee vào cơ sở dữ liệu.");

                    // Lấy employee_id
                    string getEmployeeIdQuery = "SELECT LAST_INSERT_ID()";
                    cmd1 = new MySqlCommand(getEmployeeIdQuery, conn); // Reuse cmd1 here for simplicity
                    int employeeId = Convert.ToInt32(cmd1.ExecuteScalar());
                    Debug.WriteLine($"Lấy employee_id thành công: {employeeId}");

                    // Thêm account
                    string accountQuery = "INSERT INTO Accounts (employee_id, username, password, email) VALUES (@employeeId, @username, @password, @email)";
                    cmd2 = new MySqlCommand(accountQuery, conn);
                    cmd2.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd2.Parameters.AddWithValue("@username", username);
                    cmd2.Parameters.AddWithValue("@password", password);
                    cmd2.Parameters.AddWithValue("@email", email);
                    cmd2.ExecuteNonQuery();

                    Debug.WriteLine("Đã thêm account vào cơ sở dữ liệu.");

                    // Thêm bản ghi vào bảng attendances với giá trị mặc định
                    string attendanceQuery = "INSERT INTO attendances (employee_id, day, status) VALUES (@employeeId, CURRENT_DATE, 'Chưa chấm')";
                    cmd3 = new MySqlCommand(attendanceQuery, conn);
                    cmd3.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd3.ExecuteNonQuery();

                    Debug.WriteLine("Đã thêm attendance vào cơ sở dữ liệu.");

                    // Commit transaction
                    transaction.Commit();
                    Debug.WriteLine("Giao dịch đã được commit thành công.");

                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Lỗi khi tạo tài khoản: {ex.Message}");
                if (conn != null)
                {
                    try
                    {
                        conn.Close();
                        Debug.WriteLine("Đã đóng kết nối cơ sở dữ liệu.");
                    }
                    catch (MySqlException e)
                    {
                        Debug.WriteLine($"Lỗi khi đóng kết nối: {e.Message}");
                    }
                }
                return false;
            }
            finally
            {
                // Đảm bảo đóng kết nối và các đối tượng liên quan
                try
                {
                    cmd3?.Dispose();
                    cmd2?.Dispose();
                    cmd1?.Dispose();
                    conn?.Close();
                    Debug.WriteLine("Đã đóng tất cả các đối tượng và kết nối.");
                }
                catch (Exception e)
                {
                    Debug.WriteLine($"Lỗi khi đóng kết nối: {e.Message}");
                }
            }
        }

        public void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void jtfSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu phím bấm không phải là số hoặc ký tự điều khiển (backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngừng nhập ký tự
            }

            // Tùy chọn: Giới hạn số điện thoại nhập vào tối đa 10 chữ số
            if (jtfSoDienThoai.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngừng nhập thêm ký tự
            }
        }

    }
}
