using MySql.Data.MySqlClient;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using QUANLYNHANVIEN_1.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHANVIEN_1
{
    public partial class FormTinhluong : Form
    {
        private FormChamcong formChamcong;

        public FormTinhluong()
        {
            this.formChamcong = new FormChamcong(); // Tạo mới đối tượng FormChamcong
            InitializeComponent();
            DisplaySalary();
            AddTableClickListener();
        }

        public FormTinhluong(FormChamcong formChamcong)
        {
            this.formChamcong = formChamcong;
            InitializeComponent();
            DisplaySalary();
            AddTableClickListener();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMain1 FormMain = new FormMain1();
            FormMain.Show();
            this.Hide();
        }



        private void btbTinhluong_Click(object sender, EventArgs e)
        {
            try
            {
                int employeeId = int.Parse(txtID.Text);
                double baseSalary = double.Parse(txtBaseSalary.Text);

                double bonus = string.IsNullOrEmpty(txtBonus.Text) ? 0 : double.Parse(txtBonus.Text);

                // Lấy số ngày nghỉ từ bảng
                int dayOff = 0;
                if (jtbLuong.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = jtbLuong.SelectedRows[0].Index;
                    dayOff = int.Parse(jtbLuong.Rows[selectedRowIndex].Cells[4].Value.ToString()); // Cột Day Off
                }

                using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    Debug.WriteLine("Kết nối cơ sở dữ liệu thành công.");

                    // Lấy tháng và năm từ cơ sở dữ liệu
                    string dateSql = "SELECT salary_month, salary_year FROM salaries WHERE employee_id = @employeeId ORDER BY salary_year DESC, salary_month DESC LIMIT 1";
                    MySqlCommand dateCmd = new MySqlCommand(dateSql, conn);
                    dateCmd.Parameters.AddWithValue("@employeeId", employeeId);

                    Debug.WriteLine("Thực thi câu lệnh SQL lấy tháng và năm: " + dateSql);

                    MySqlDataReader dateReader = dateCmd.ExecuteReader();
                    int month, year;

                    if (dateReader.Read())
                    {
                        month = dateReader.GetInt32(0);
                        year = dateReader.GetInt32(1);
                        Debug.WriteLine($"Lấy được tháng: {month}, năm: {year}.");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tháng và năm trong cơ sở dữ liệu!");
                        dateReader.Close();
                        return;
                    }
                    dateReader.Close();

                    // Tính số ngày trong tháng
                    int daysInMonth = DateTime.DaysInMonth(year, month);
                    Debug.WriteLine($"Số ngày trong tháng: {daysInMonth}");

                    // Tính thực lĩnh theo công thức mới
                    double netSalary = baseSalary + bonus - (baseSalary / daysInMonth * dayOff);
                    Debug.WriteLine($"Tính lương thực lĩnh: {netSalary}");

                    // Kiểm tra xem lương đã tồn tại cho tháng và năm từ database
                    string checkSql = "SELECT COUNT(*) FROM salaries WHERE employee_id = @employeeId AND salary_month = @month AND salary_year = @year";
                    MySqlCommand checkCmd = new MySqlCommand(checkSql, conn);
                    checkCmd.Parameters.AddWithValue("@employeeId", employeeId);
                    checkCmd.Parameters.AddWithValue("@month", month);
                    checkCmd.Parameters.AddWithValue("@year", year);

                    Debug.WriteLine("Kiểm tra dữ liệu lương có tồn tại trong cơ sở dữ liệu.");

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    Debug.WriteLine($"Số bản ghi lương tồn tại: {count}");

                    string sql;
                    if (count > 0)
                    {
                        sql = "UPDATE salaries SET basic_salary = @baseSalary, bonuses = @bonus, net_salary = @netSalary WHERE employee_id = @employeeId AND salary_month = @month AND salary_year = @year";
                        Debug.WriteLine("Cập nhật lương vào cơ sở dữ liệu.");
                    }
                    else
                    {
                        sql = "INSERT INTO salaries (employee_id, salary_month, salary_year, basic_salary, bonuses, net_salary) VALUES (@employeeId, @month, @year, @baseSalary, @bonus, @netSalary)";
                        Debug.WriteLine("Thêm mới lương vào cơ sở dữ liệu.");
                    }

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@baseSalary", baseSalary);
                    cmd.Parameters.AddWithValue("@bonus", bonus);
                    cmd.Parameters.AddWithValue("@netSalary", netSalary);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Tính lương thành công và đã lưu vào cơ sở dữ liệu!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Hiển thị thông tin chi tiết về việc tính lương
                        string message = $"Chi tiết tính lương:\n" +
                                         $"Lương cơ bản: {baseSalary:F2}\n" +
                                         $"Thưởng: {bonus:F2}\n" +
                                         $"Số ngày nghỉ: {dayOff}\n" +
                                         $"Số ngày trong tháng: {daysInMonth}\n" +
                                         $"Thực lĩnh: {netSalary:F2}";
                        MessageBox.Show(message, "Chi tiết lương", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Debug.WriteLine("Tính lương thành công và thông tin đã được hiển thị.");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi lưu lương vào cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Debug.WriteLine("Có lỗi khi lưu lương vào cơ sở dữ liệu.");
                    }
                }

                DisplaySalary();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Vui lòng nhập số cho lương cơ bản và thưởng!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine("Lỗi định dạng: " + ex.Message);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi khi kết nối cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine("Lỗi MySQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine("Lỗi không xác định: " + ex.Message);
            }
        }


        public void DisplaySalary()
        {
            try
            {
                // Kết nối database
                using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        MessageBox.Show("Kết nối không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Query SQL kết hợp salary_month và salary_year
                    string sql = "SELECT employee_id, salary_month, salary_year, " +
                                 "basic_salary, bonuses, net_salary " +
                                 "FROM salaries " +
                                 "ORDER BY salary_year DESC, salary_month DESC";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Xóa dữ liệu cũ trước khi thêm dữ liệu mới
                        jtbLuong.Rows.Clear();

                        int stt = 1; // Biến đếm STT
                        var culture = CultureInfo.GetCultureInfo("vi-VN");

                        while (reader.Read())
                        {
                            int employeeId = reader.GetInt32("employee_id");
                            int month = reader.GetInt32("salary_month");
                            int year = reader.GetInt32("salary_year");
                            string monthYear = string.Format("{0:D2}/{1}", month, year);

                            // TODO: Thay thế formChamcong.GetDayOffForEmployee bằng phương thức phù hợp
                            int dayOff = formChamcong.GetDayOffForEmployee(employeeId, monthYear);

                            // Kiểm tra xem dữ liệu có NULL không trước khi truy xuất
                            double baseSalary = reader.IsDBNull(reader.GetOrdinal("basic_salary")) ? 0 : reader.GetDouble("basic_salary");
                            double bonus = reader.IsDBNull(reader.GetOrdinal("bonuses")) ? 0 : reader.GetDouble("bonuses");
                            double netSalary = reader.IsDBNull(reader.GetOrdinal("net_salary")) ? 0 : reader.GetDouble("net_salary");

                            string formattedBaseSalary = string.Format(culture, "{0:N0}", baseSalary);
                            string formattedBonus = string.Format(culture, "{0:N0}", bonus);
                            string formattedNetSalary = string.Format(culture, "{0:N0}", netSalary);

                            // Thêm dòng mới vào DataGridView
                            jtbLuong.Rows.Add(stt++, employeeId, monthYear, formattedBaseSalary, dayOff, formattedBonus, formattedNetSalary);
                        }

                        // Căn chỉnh độ rộng cột
                        if (jtbLuong.Columns.Count > 0)
                        {
                            jtbLuong.Columns[0].Width = 50; // Cột STT
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi truy vấn database: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }












        private void btnLoad_Click(object sender, EventArgs e)
        {
            DisplaySalary();
            // Xóa các trường nhập liệu
            txtBaseSalary.Text = string.Empty;
            txtID.Text = string.Empty;
            txtBonus.Text = string.Empty;
            txtMonth.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }

        private string GetFullNameByEmployeeId(int employeeId, MySqlConnection conn)
        {
            string fullName = string.Empty;
            string sql = "SELECT full_name FROM employees WHERE employee_id = @EmployeeId";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            fullName = reader["full_name"].ToString();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message); // Thay thế bằng log nếu cần
            }

            return fullName;
        }


        private void btnOuput_Click(object sender, EventArgs e)
        {
            string filePath = "E:\\Documents\\File Exel\\SalaryTable.xlsx"; // Đường dẫn lưu file Excel
            Console.WriteLine("Đã nhấn nút xuất Excel");

            try
            {
                // Tạo workbook và sheet
                using (var workbook = new XSSFWorkbook())
                {
                    ISheet sheet = workbook.CreateSheet("Salary Table");

                    // Lấy dữ liệu từ bảng
                    var model = (DataTable)jtbLuong.DataSource;

                    // Tạo tiêu đề cột
                    IRow headerRow = sheet.CreateRow(0);
                    for (int col = 0; col < model.Columns.Count; col++)
                    {
                        ICell cell = headerRow.CreateCell(col);
                        cell.SetCellValue(model.Columns[col].ColumnName);
                    }

                    // Lấy kết nối tới cơ sở dữ liệu
                    using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                    {

                        // Thêm dữ liệu vào các dòng
                        for (int row = 0; row < model.Rows.Count; row++)
                        {
                            IRow excelRow = sheet.CreateRow(row + 1);
                            for (int col = 0; col < model.Columns.Count; col++)
                            {
                                ICell cell = excelRow.CreateCell(col);
                                var cellValue = model.Rows[row][col];

                                if (col == 0) // Cột Employee ID, lấy thông tin từ cơ sở dữ liệu
                                {
                                    int employeeId = Convert.ToInt32(model.Rows[row][0]);
                                    string fullName = GetFullNameByEmployeeId(employeeId, conn); // Lấy tên đầy đủ từ bảng employees
                                    cell.SetCellValue($"{employeeId} - {fullName}"); // Kết hợp employee_id và full_name
                                }
                                else
                                {
                                    cell.SetCellValue(cellValue?.ToString() ?? "N/A"); // Hiển thị "N/A" nếu giá trị là null
                                }
                            }
                        }
                    }

                    // Ghi vào file
                    using (var fileOut = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        workbook.Write(fileOut);
                    }
                }

                MessageBox.Show("Xuất bảng lương ra Excel thành công!");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Lỗi khi xuất Excel: {ex.Message}");
                Console.WriteLine(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedRow = jtbLuong.CurrentRow?.Index ?? -1; // `dgvSalary` là DataGridView
            if (selectedRow == -1)
            {
                MessageBox.Show("Vui lòng chọn một hàng để xoá.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xoá bản ghi này?", "Xác nhận xoá", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            string employeeId = jtbLuong.Rows[selectedRow].Cells[1].Value.ToString();
            string monthYear = jtbLuong.Rows[selectedRow].Cells[2].Value.ToString();

            string[] parts = monthYear.Split('/');
            int month = int.Parse(parts[0]);
            int year = int.Parse(parts[1]);

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                string sql = "DELETE FROM salaries WHERE employee_id = @EmployeeId AND salary_month = @Month AND salary_year = @Year";

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeId", int.Parse(employeeId));
                        cmd.Parameters.AddWithValue("@Month", month);
                        cmd.Parameters.AddWithValue("@Year", year);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Xoá bản ghi thành công!");
                            DisplaySalary(); // Hàm cập nhật lại DataGridView

                            // Xoá dữ liệu trong các trường nhập liệu
                            txtID.Clear();
                            txtBaseSalary.Clear();
                            txtBonus.Clear();
                            txtMonth.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xoá bản ghi. Vui lòng thử lại.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Lỗi khi xoá bản ghi: " + ex.Message);
                }
            }
        }

        private void AddTableClickListener()
        {
            jtbLuong.CellClick += (s, e) =>
            {
                int row = e.RowIndex; // Lấy chỉ số hàng được chọn
                if (row >= 0) // Kiểm tra nếu hàng hợp lệ
                {
                    // Lấy dữ liệu từ các cột của hàng được chọn
                    string employeeId = jtbLuong.Rows[row].Cells[1].Value?.ToString() ?? "";
                    string baseSalary = jtbLuong.Rows[row].Cells[3].Value?.ToString() ?? "";
                    string bonus = jtbLuong.Rows[row].Cells[5].Value?.ToString() ?? "";
                    string monthYear = jtbLuong.Rows[row].Cells[2].Value?.ToString() ?? "";

                    // Hiển thị dữ liệu vào các TextBox tương ứng
                    txtID.Text = employeeId;

                    // Loại bỏ dấu phẩy từ baseSalary và bonus trước khi hiển thị
                    txtBaseSalary.Text = baseSalary.Replace(",", "");
                    txtBonus.Text = bonus.Replace(",", "");
                    txtMonth.Text = monthYear;
                }
            };
        }


        //public void UpdateDayOff(int employeeId, string monthYear)
        //{
        //    // Tách tháng và năm từ monthYear
        //    string[] parts = monthYear.Split('/');
        //    if (parts.Length != 2)
        //    {
        //        return;
        //    }

        //    int month;
        //    int year;
        //    try
        //    {
        //        month = int.Parse(parts[0]);
        //        year = int.Parse(parts[1]);
        //    }
        //    catch (FormatException)
        //    {
        //        return;
        //    }

        //    // Lấy số ngày nghỉ cho nhân viên
        //    int dayOff = formChamcong.GetDayOffForEmployee(employeeId, monthYear);

        //    // Cập nhật giá trị Day Off trong DataGridView (dgvSalary)
        //    bool found = false;
        //    foreach (DataGridViewRow row in jtbTinhLuong.Rows)
        //    {
        //        if (row.Cells[1].Value.ToString() == employeeId.ToString() &&
        //            row.Cells[2].Value.ToString() == monthYear)
        //        {
        //            row.Cells[4].Value = dayOff;
        //            found = true;
        //            break;
        //        }
        //    }

        //    if (!found)
        //    {
        //        Console.WriteLine("Không tìm thấy hàng phù hợp trong bảng.");
        //    }
        //}

    }
}
