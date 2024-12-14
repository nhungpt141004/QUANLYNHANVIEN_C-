using MySql.Data.MySqlClient;
using OfficeOpenXml;
using QUANLYNHANVIEN_1.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.ComponentModel;  // Namespace của LicenseContext trong System
using OfficeOpenXml;          // Namespace của EPPlus
using ExcelLicenseContext = OfficeOpenXml.LicenseContext;


namespace QUANLYNHANVIEN_1
{
    public partial class FormNhanvien : Form
    {
        public FormNhanvien()
        {
            InitializeComponent();
            LoadEmployeeData();


        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
        }

        private void btnChamcong_Click(object sender, EventArgs e)
        {
            FormChamcong formChamcong = new FormChamcong();
            formChamcong.Show();
            this.Hide();
        }

        private void btnTinhluong_Click(object sender, EventArgs e)
        {
            FormTinhluong FormTinhluong = new FormTinhluong();
            FormTinhluong.Show();
            this.Hide();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Show();
            this.Hide();
        }



        // thêm nhân viên
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            string id = txtID.Text.Trim();
            string ten = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            string phonenb = txtPhone.Text.Trim();
            DateTime ngaySinh = dtpDateofBirth.Value;

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phonenb))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate email
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Email không đúng định dạng, vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate phone number (chỉ cho phép số, độ dài từ 10-11 chữ số)
            string phonePattern = @"^[0-9]{10,11}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(phonenb, phonePattern))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng (chỉ gồm số và có độ dài 10-11 chữ số)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra năm sinh
            int namSinh = ngaySinh.Year;
            if (namSinh < 1950 || namSinh > 2008)
            {
                MessageBox.Show("Năm sinh chỉ được nằm trong khoảng 1950-2008", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Tạo đối tượng DatabaseConnection
                DatabaseConnection db = new DatabaseConnection();
                db.OpenConnection();

                // Kiểm tra xem email đã tồn tại trong cơ sở dữ liệu chưa
                string checkEmailSQL = "SELECT COUNT(*) FROM employees WHERE email = @Email";
                using (MySqlCommand cmd = new MySqlCommand(checkEmailSQL, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    int emailExists = Convert.ToInt32(cmd.ExecuteScalar());
                    if (emailExists > 0)
                    {
                        MessageBox.Show("Email này đã tồn tại, vui lòng chọn email khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Kiểm tra xem số điện thoại đã tồn tại trong cơ sở dữ liệu chưa
                string checkPhoneSQL = "SELECT COUNT(*) FROM employees WHERE phone_number = @Phone";
                using (MySqlCommand cmd = new MySqlCommand(checkPhoneSQL, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Phone", phonenb);
                    int phoneExists = Convert.ToInt32(cmd.ExecuteScalar());
                    if (phoneExists > 0)
                    {
                        MessageBox.Show("Số điện thoại này đã tồn tại, vui lòng chọn số điện thoại khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Câu lệnh SQL INSERT
                string query = "INSERT INTO employees (employee_id, full_name, email, phone_number, address, date_of_birth) " +
                               "VALUES (@ID, @FullName, @Email, @Phone, @Address, @DateOfBirth)";
                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@FullName", ten);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phonenb);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@DateOfBirth", ngaySinh);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Thêm dữ liệu vào bảng attendances( SUA BANG CHAM CONG THANH DATAGRIDVIEW :))))
                        string sqlChamCong = "INSERT INTO attendances (employee_id, day, status) VALUES (@EmployeeID, CURDATE(), 'N/A')";
                        using (MySqlCommand cmdChamCong = new MySqlCommand(sqlChamCong, db.GetConnection()))
                        {
                            cmdChamCong.Parameters.AddWithValue("@EmployeeID", id);
                            cmdChamCong.ExecuteNonQuery();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm nhân viên. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                db.CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //hien thi du lieu tu database
        private void LoadEmployeeData()
        {
            try
            {
                // Tạo đối tượng DatabaseConnection
                DatabaseConnection db = new DatabaseConnection();

                // Mở kết nối
                db.OpenConnection();

                // Câu lệnh SQL SELECT với JOIN giữa employees và accounts
                string query = @"
                    SELECT e.employee_id, e.full_name, e.email, e.phone_number, e.address, e.date_of_birth, a.role_id 
                    FROM employees e 
                     LEFT JOIN accounts a ON e.employee_id = a.employee_id";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.GetConnection());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Gắn DataTable vào DataGridView
                tbEmployee.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }




        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadEmployeeData();


            // Làm mới các trường dữ liệu
            txtID.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            dtpDateofBirth.Value = DateTime.Now;
        }

        //xoá nhân viên
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbEmployee.SelectedRows.Count > 0)
            {
                // Hỏi xác nhận trước khi xóa
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa các nhân viên đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        // Tạo đối tượng DatabaseConnection
                        DatabaseConnection db = new DatabaseConnection();
                        db.OpenConnection();

                        // Bắt đầu giao dịch để đảm bảo tính toàn vẹn dữ liệu
                        using (var transaction = db.GetConnection().BeginTransaction())
                        {
                            try
                            {
                                foreach (DataGridViewRow selectedRow in tbEmployee.SelectedRows)
                                {
                                    // Lấy ID của nhân viên từ cột 'employee_id'
                                    string employeeID = selectedRow.Cells["employee_id"].Value.ToString();

                                    // Câu lệnh SQL DELETE
                                    string query = "DELETE FROM employees WHERE employee_id = @EmployeeID";

                                    using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection(), transaction))
                                    {
                                        // Thêm tham số để tránh SQL Injection
                                        cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                                        // Thực thi lệnh
                                        int rowsAffected = cmd.ExecuteNonQuery();

                                        if (rowsAffected > 0)
                                        {
                                            // Xóa hàng trong DataGridView sau khi xóa thành công
                                            tbEmployee.Rows.Remove(selectedRow);
                                        }
                                    }
                                }

                                // Xác nhận giao dịch
                                transaction.Commit();
                                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (MySqlException ex)
                            {
                                // Hủy bỏ giao dịch nếu xảy ra lỗi
                                transaction.Rollback();
                                MessageBox.Show("Đã xảy ra lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        // Đóng kết nối
                        db.CloseConnection();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một nhân viên để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormNhanvien_Load(object sender, EventArgs e)
        {

        }

        //sửa nhân viên
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Lấy hàng được chọn trong DataGridView
            if (tbEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy dữ liệu từ dòng được chọn
            DataGridViewRow selectedRow = tbEmployee.SelectedRows[0];
            string employeeId = selectedRow.Cells["employee_id"].Value.ToString();
            string ten = selectedRow.Cells["full_name"].Value.ToString();
            string email = selectedRow.Cells["email"].Value.ToString();
            string soDienThoai = selectedRow.Cells["phone_number"].Value.ToString();
            string diaChi = selectedRow.Cells["address"].Value.ToString();
            string ngaySinh = selectedRow.Cells["date_of_birth"].Value?.ToString();
            string roleId = selectedRow.Cells["role_id"].Value.ToString();

            // Tạo các TextBox và ComboBox để sửa thông tin
            TextBox txtEmployeeId = new TextBox { Text = employeeId, ReadOnly = true };
            TextBox txtTen = new TextBox { Text = ten };
            TextBox txtEmail = new TextBox { Text = email };
            TextBox txtSoDienThoai = new TextBox { Text = soDienThoai };
            TextBox txtDiaChi = new TextBox { Text = diaChi };

            // Tạo DateTimePicker để chọn ngày sinh
            DateTimePicker dtpNgaySinh = new DateTimePicker { Format = DateTimePickerFormat.Custom, CustomFormat = "yyyy-MM-dd" };
            if (!string.IsNullOrEmpty(ngaySinh))
            {
                dtpNgaySinh.Value = DateTime.Parse(ngaySinh);
            }

            // Tạo ComboBox để chọn Role
            ComboBox cboRole = new ComboBox();
            cboRole.Items.Add("Admin");
            cboRole.Items.Add("Employee");
            cboRole.SelectedItem = roleId == "1" ? "Admin" : "Employee";

            // Tạo giao diện sửa thông tin
            TableLayoutPanel panel = new TableLayoutPanel { ColumnCount = 2, AutoSize = true };
            panel.Controls.Add(new Label { Text = "Employee ID:" });
            panel.Controls.Add(txtEmployeeId);
            panel.Controls.Add(new Label { Text = "Full Name:" });
            panel.Controls.Add(txtTen);
            panel.Controls.Add(new Label { Text = "Email:" });
            panel.Controls.Add(txtEmail);
            panel.Controls.Add(new Label { Text = "Phone Number:" });
            panel.Controls.Add(txtSoDienThoai);
            panel.Controls.Add(new Label { Text = "Address:" });
            panel.Controls.Add(txtDiaChi);
            panel.Controls.Add(new Label { Text = "Date of Birth:" });
            panel.Controls.Add(dtpNgaySinh);
            panel.Controls.Add(new Label { Text = "Role:" });
            panel.Controls.Add(cboRole);

            // Tạo form mới để hiển thị các điều khiển
            Form editForm = new Form
            {
                Text = "Sửa thông tin nhân viên",
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen
            };

            // Tạo nút OK
            Button btnOk = new Button { Text = "OK" };
            btnOk.Click += (s, ev) =>
            {
                try
                {
                    // Lấy giá trị mới
                    string newTen = txtTen.Text.Trim();
                    string newEmail = txtEmail.Text.Trim();
                    string newSoDienThoai = txtSoDienThoai.Text.Trim();
                    string newDiaChi = txtDiaChi.Text.Trim();
                    string newNgaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                    string newRoleId = cboRole.SelectedItem.ToString() == "Admin" ? "1" : "2";

                    // Cập nhật thông tin trong cơ sở dữ liệu
                    string sqlUpdateEmployee = @"
                UPDATE employees 
                SET full_name = @FullName, email = @Email, phone_number = @Phone, 
                    address = @Address, date_of_birth = @DateOfBirth
                WHERE employee_id = @EmployeeID";

                    string sqlUpdateRole = @"
                UPDATE accounts
                SET role_id = @RoleID
                WHERE employee_id = @EmployeeID";

                    DatabaseConnection db = new DatabaseConnection();
                    {
                        db.OpenConnection();

                        using (MySqlCommand cmd = new MySqlCommand(sqlUpdateEmployee, db.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("@FullName", newTen);
                            cmd.Parameters.AddWithValue("@Email", newEmail);
                            cmd.Parameters.AddWithValue("@Phone", newSoDienThoai);
                            cmd.Parameters.AddWithValue("@Address", newDiaChi);
                            cmd.Parameters.AddWithValue("@DateOfBirth", newNgaySinh);
                            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Cập nhật thông tin role_id trong bảng accounts
                                using (MySqlCommand cmdRole = new MySqlCommand(sqlUpdateRole, db.GetConnection()))
                                {
                                    cmdRole.Parameters.AddWithValue("@RoleID", newRoleId);
                                    cmdRole.Parameters.AddWithValue("@EmployeeID", employeeId);
                                    cmdRole.ExecuteNonQuery();
                                }

                                // Cập nhật giao diện DataGridView
                                selectedRow.Cells["full_name"].Value = newTen;
                                selectedRow.Cells["email"].Value = newEmail;
                                selectedRow.Cells["phone_number"].Value = newSoDienThoai;
                                selectedRow.Cells["address"].Value = newDiaChi;
                                selectedRow.Cells["date_of_birth"].Value = newNgaySinh;
                                selectedRow.Cells["role_id"].Value = newRoleId;

                                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                editForm.DialogResult = DialogResult.OK; // Đóng form
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            // Tạo nút Cancel
            Button btnCancel = new Button { Text = "Cancel" };
            btnCancel.Click += (s, ev) =>
            {
                editForm.DialogResult = DialogResult.Cancel; // Đóng form mà không lưu
            };

            // Thêm nút vào form
            panel.Controls.Add(btnOk);
            panel.Controls.Add(btnCancel);

            // Thêm panel vào form
            editForm.Controls.Add(panel);

            // Hiển thị form sửa thông tin
            DialogResult result = editForm.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                // Nếu Cancel thì không làm gì thêm
                MessageBox.Show("Cập nhật bị hủy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void tbEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                SearchData(keyword); // Gọi hàm tìm kiếm theo từ khóa
            }
        }

        // Xử lý sự kiện Click (khi nhấn nút Tìm kiếm)
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                SearchData(keyword); // Gọi hàm tìm kiếm theo từ khóa
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Hàm tìm kiếm dữ liệu từ cơ sở dữ liệu
        private void SearchData(string keyword)
        {
            try
            {
                DatabaseConnection db = new DatabaseConnection();
                db.OpenConnection(); // Mở kết nối cơ sở dữ liệu

                // Câu truy vấn tìm kiếm (dựa trên tên nhân viên hoặc mã nhân viên)
                string query = "SELECT * FROM employees WHERE full_name LIKE @keyword OR employee_id LIKE @keyword";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%"); // Sử dụng ký tự wildcard '%' để tìm kiếm gần đúng

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable); // Đổ dữ liệu vào DataTable

                    // Hiển thị dữ liệu trong DataGridView
                    tbEmployee.DataSource = dataTable;
                }

                db.CloseConnection(); // Đóng kết nối cơ sở dữ liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {

        }

        //XUẤT EXCEL
        private void btnOutput_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo một file Excel mới
                using (var package = new ExcelPackage())
                {
                    // Tạo một worksheet mới
                    var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                    // Lấy dữ liệu từ DataGridView (giả sử dgvEmployees là DataGridView của bạn)
                    int rowCount = tbEmployee.Rows.Count;
                    int colCount = tbEmployee.Columns.Count;

                    // Lặp qua các cột và hàng để đưa dữ liệu vào Excel
                    for (int col = 0; col < colCount; col++)
                    {
                        // Ghi tên các cột vào dòng đầu tiên
                        worksheet.Cells[1, col + 1].Value = tbEmployee.Columns[col].HeaderText;
                    }

                    for (int row = 0; row < rowCount; row++)
                    {
                        for (int col = 0; col < colCount; col++)
                        {
                            // Ghi dữ liệu vào các ô tương ứng
                            worksheet.Cells[row + 2, col + 1].Value = tbEmployee.Rows[row].Cells[col].Value;
                        }
                    }

                    // Lưu file Excel
                    var saveFileDialog = new SaveFileDialog
                    {
                        Filter = "NhungChuChe.xlsx",//Cai nay thang duc anh ghi. No bố láo quá
                        Title = "Save an Excel File"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo fi = new FileInfo(saveFileDialog.FileName);
                        package.SaveAs(fi);
                        MessageBox.Show("Data exported successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMain1 formMain1 = new FormMain1();
            formMain1.Show();
            this.Hide();
        }
    }
}

