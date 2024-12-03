using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics; // Thêm thư viện Debug
using QUANLYNHANVIEN_1.Util;
using MySql.Data.MySqlClient;
using QUANLYNHANVIEN_1.database;

namespace QUANLYNHANVIEN_1
{
    public partial class FormDoimatkhau : Form
    {
        private string username;
        private string newPassword;

        public FormDoimatkhau(string username)
        {
            InitializeComponent();
            this.username = username;
            this.Text = "Đổi mật khẩu";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void txtCheckpass_CheckedChanged(object sender, EventArgs e)
        {
            txtOldPass.UseSystemPasswordChar = !txtCheckpass.Checked;
            txtNewPass.UseSystemPasswordChar = !txtCheckpass.Checked;
            txtConfirmPass.UseSystemPasswordChar = !txtCheckpass.Checked;
        }

        private void btnGetcode_Click(object sender, EventArgs e)
        {
            string otp = GenerateOtp();
            string filePath = @"C:\OTP\OTP.txt";
            SaveOtpToFile(otp, filePath);

            // Debugging: Xác nhận mã OTP đã được tạo
            Debug.WriteLine($"Generated OTP: {otp}");
            MessageBox.Show($"Mã OTP đã được tạo và lưu vào file: {filePath}");
        }

        private string GenerateOtp()
        {
            Random random = new Random();
            StringBuilder otp = new StringBuilder();

            for (int i = 0; i < 6; i++)
            {
                otp.Append(random.Next(10));
            }

            // Debugging: In OTP được tạo ra
            Debug.WriteLine($"Generated OTP: {otp}");
            return otp.ToString();
        }

        private void SaveOtpToFile(string otp, string filePath)
        {
            try
            {
                string directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                    Debug.WriteLine($"Directory created: {directory}");
                }

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(otp);
                    writer.WriteLine(DateTime.Now.ToString("o")); // ISO 8601 format
                }

                Debug.WriteLine($"OTP saved to file: {filePath}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error saving OTP: {ex.Message}");
                MessageBox.Show("Lỗi khi lưu mã OTP vào file!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidatePasswords(string matKhauMoi, string matKhauXacNhan)
        {
            if (string.IsNullOrWhiteSpace(matKhauMoi))
            {
                Debug.WriteLine("Mật khẩu mới bị trống");
                MessageBox.Show("Mật khẩu mới không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (matKhauMoi.Length < 8)
            {
                Debug.WriteLine("Mật khẩu mới quá ngắn");
                MessageBox.Show("Mật khẩu mới phải có ít nhất 8 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(matKhauMoi, @"[A-Z]"))
            {
                Debug.WriteLine("Mật khẩu không có ký tự viết hoa");
                MessageBox.Show("Mật khẩu mới phải chứa ít nhất một ký tự viết hoa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(matKhauMoi, @"\d"))
            {
                Debug.WriteLine("Mật khẩu không có chữ số");
                MessageBox.Show("Mật khẩu mới phải chứa ít nhất một chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(matKhauMoi, @"[!@#$%^&*(),.?""\:{}|<>]"))
            {
                Debug.WriteLine("Mật khẩu không có ký tự đặc biệt");
                MessageBox.Show("Mật khẩu mới phải chứa ít nhất một ký tự đặc biệt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (matKhauMoi != matKhauXacNhan)
            {
                Debug.WriteLine("Mật khẩu xác nhận không khớp");
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string matKhauHienTai = txtOldPass.Text;
            string matKhauMoi = txtNewPass.Text;
            string matKhauXacNhan = txtConfirmPass.Text;
            string otp = txtPassCode.Text;

            Debug.WriteLine($"Old Password: {matKhauHienTai}, New Password: {matKhauMoi}, Confirm Password: {matKhauXacNhan}, OTP: {otp}");

            if (!ValidatePasswords(matKhauMoi, matKhauXacNhan))
            {
                return;
            }

            string matKhauHienTaiHashed = HashPassword.hashPassword(matKhauHienTai);
            Debug.WriteLine($"Hashed Current Password: {matKhauHienTaiHashed}");

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                string employeeId = GetEmployeeIdByEmailOrPhone(username);
                Debug.WriteLine($"Employee ID: {employeeId}");

                if (employeeId == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "SELECT password FROM accounts WHERE employee_id = @employeeId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@employeeId", employeeId);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string matKhauDaLuu = reader.GetString(0);
                    Debug.WriteLine($"Stored Password: {matKhauDaLuu}");

                    if (matKhauDaLuu == matKhauHienTaiHashed && IsValidOtp(otp))
                    {
                        reader.Close();

                        string updateQuery = "UPDATE accounts SET password = @newPassword WHERE employee_id = @employeeId";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@newPassword", HashPassword.hashPassword(matKhauMoi));
                        updateCmd.Parameters.AddWithValue("@employeeId", employeeId);
                        updateCmd.ExecuteNonQuery();

                        Debug.WriteLine("Password updated successfully!");
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        new FormThongtin(username, matKhauMoi).Show();
                        this.Close();
                    }
                    else
                    {
                        Debug.WriteLine("Current password or OTP is invalid.");
                        MessageBox.Show("Mật khẩu hiện tại hoặc mã OTP không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string GetEmployeeIdByEmailOrPhone(string input)
        {
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                string query = "SELECT employee_id FROM employees WHERE email = @input OR phone_number = @input";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@input", input);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Sửa lỗi ép kiểu, chuyển giá trị số sang chuỗi
                    int employeeId = reader.GetInt32(0); // Đọc cột kiểu INT
                    Debug.WriteLine($"Found Employee ID: {employeeId}");
                    return employeeId.ToString(); // Chuyển số sang chuỗi để trả về
                }
            }

            Debug.WriteLine("Employee ID not found.");
            return null;
        }


        private bool IsValidOtp(string otp)
        {
            string filePath = @"C:\OTP\OTP.txt";

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                string otpFromFile = lines[0];
                DateTime createdTime = DateTime.Parse(lines[1]);

                Debug.WriteLine($"OTP from file: {otpFromFile}, Created Time: {createdTime}");

                if (otp != otpFromFile)
                {
                    Debug.WriteLine("OTP không hợp lệ.");
                    MessageBox.Show("Mã OTP không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if ((DateTime.Now - createdTime).TotalMinutes >= 2)
                {
                    Debug.WriteLine("OTP hết hạn.");
                    MessageBox.Show("Mã OTP đã hết hạn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error reading OTP file: {ex.Message}");
                MessageBox.Show("Lỗi khi đọc mã OTP từ file!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string matKhau = !string.IsNullOrEmpty(newPassword) ? newPassword : txtOldPass.Text;
            Debug.WriteLine($"Returning to info form with password: {matKhau}");
            new FormThongtin(username, matKhau).Show();
            this.Close();
        }
    }
}
