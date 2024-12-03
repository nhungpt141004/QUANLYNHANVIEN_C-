using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using QUANLYNHANVIEN_1.database;

namespace QUANLYNHANVIEN_1
{
    public partial class FormThongtin : Form
    {
        private string username;
        private string password;

        public FormThongtin(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            LoadEmployeeData(username);
        }

        private void LoadEmployeeData(string identifier)
        {
            string query = "SELECT e.full_name, e.email, e.phone_number, e.address, e.date_of_birth, s.net_salary " +
                           "FROM employees e " +
                           "LEFT JOIN accounts a ON e.employee_id = a.employee_id " +
                           "LEFT JOIN salaries s ON e.employee_id = s.employee_id " +
                           "WHERE a.username = @identifier OR a.email = @identifier OR e.phone_number = @identifier";

            try
            {
                using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@identifier", identifier);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtEmail.Text = reader.GetString("email");
                            txtFullName.Text = reader.GetString("full_name");
                            txtPhoneNumber.Text = reader.GetString("phone_number");

                            string address = reader.IsDBNull(reader.GetOrdinal("address")) ? string.Empty : reader.GetString("address");
                            if (string.IsNullOrEmpty(address))
                            {
                                txtAddress.Text = "Chưa có thông tin, liên hệ Admin để cập nhật!";
                                txtAddress.ForeColor = Color.Red;
                            }
                            else
                            {
                                txtAddress.Text = address;
                                txtAddress.ForeColor = Color.Black;
                            }

                            string dob = reader.IsDBNull(reader.GetOrdinal("date_of_birth")) ? string.Empty : reader.GetDateTime(reader.GetOrdinal("date_of_birth")).ToString("yyyy-MM-dd");
                            if (string.IsNullOrEmpty(dob))
                            {
                                txtDateOfBirth.Text = "Chưa có thông tin, liên hệ Admin để cập nhật!";
                                txtDateOfBirth.ForeColor = Color.Red;
                            }
                            else
                            {
                                txtDateOfBirth.Text = dob;
                                txtDateOfBirth.ForeColor = Color.Black;
                            }

                            float salary = reader.IsDBNull(reader.GetOrdinal("net_salary")) ? 0 : reader.GetFloat("net_salary");
                            if (salary == 0)
                            {
                                txtSalary.Text = "Chưa có thông tin, liên hệ Admin để cập nhật!";
                                txtSalary.ForeColor = Color.Red;
                            }
                            else
                            {
                                txtSalary.Text = string.Format("{0:n0}", salary);  // Format salary with comma
                                txtSalary.ForeColor = Color.Black;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                FormLogin loginForm = new FormLogin();
                loginForm.Show();
                this.Close();
            }
        }

        private void btnChangepass_Click(object sender, EventArgs e)
        {
            FormDoimatkhau changePasswordForm = new FormDoimatkhau(username);
            changePasswordForm.Show();
            this.Close();
        }

        private void btnXuatThongTin_Click(object sender, EventArgs e)
        {
            string filePath = @"F:\A _Bai_Tap_Cuoi_Ky\Thong_Tin_Nhan_Vien_Hien_Tai.xlsx";
            var workbook = new XSSFWorkbook();
            var sheet = workbook.CreateSheet("Employee Data");

            // Tạo dòng tiêu đề
            var headers = new string[] { "Full Name", "Email", "Phone Number", "Address", "Date of Birth", "Net Salary" };
            var headerRow = sheet.CreateRow(0);
            for (int i = 0; i < headers.Length; i++)
            {
                var cell = headerRow.CreateCell(i);
                cell.SetCellValue(headers[i]);
            }

            // Tạo dòng dữ liệu từ thông tin hiện tại
            var row = sheet.CreateRow(1);

            // Lấy dữ liệu từ các TextBox (hoặc các điều khiển giao diện khác)
            string fullName = txtFullName.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            string dob = txtDateOfBirth.Text;
            string salary = txtSalary.Text;

            // Gán dữ liệu vào file Excel
            row.CreateCell(0).SetCellValue(fullName);
            row.CreateCell(1).SetCellValue(email);
            row.CreateCell(2).SetCellValue(phoneNumber);
            row.CreateCell(3).SetCellValue(address);
            row.CreateCell(4).SetCellValue(dob);
            row.CreateCell(5).SetCellValue(salary);

            // Auto-size các cột
            for (int i = 0; i < headers.Length; i++)
            {
                sheet.AutoSizeColumn(i);
            }

            try
            {
                // Ghi dữ liệu vào file
                using (FileStream fileOut = new FileStream(filePath, FileMode.Create))
                {
                    workbook.Write(fileOut);
                }

                MessageBox.Show("Xuất thông tin nhân viên hiện tại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi ghi file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
