using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYNHANVIEN_1.database;
using System.Diagnostics;

namespace QUANLYNHANVIEN_1
{
    public partial class FormChamcong : Form
    {
        public FormChamcong()
        {
            InitializeComponent();
            setupTableListener();
            displayAttendance();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormNhanvien FormMain = new FormNhanvien();
            FormMain.Show();
            this.Hide();
        }

        private void setupTableListener()
        {
            // Thêm sự kiện Click vào DataGridView (tương tự jtbBangChamCong trong Java Swing)
            jtbChamCong.CellClick += (sender, e) =>
            {
                // Kiểm tra nếu ô được nhấp là hợp lệ
                if (e.RowIndex >= 0)
                {
                    // Lấy giá trị của hàng được chọn
                    DataGridViewRow selectedRow = jtbChamCong.Rows[e.RowIndex];

                    if (selectedRow.Cells[1].Value != null && selectedRow.Cells[2].Value != null)
                    {
                        // Lấy employeeId từ cột thứ 2 (index 1)
                        int employeeId = Convert.ToInt32(selectedRow.Cells[1].Value);

                        // Lấy monthYear từ cột thứ 3 (index 2)
                        string monthYear = selectedRow.Cells[2].Value.ToString();

                        // Gọi phương thức hiển thị chi tiết chấm công
                        DisplayDetailedAttendance(employeeId, monthYear);
                    }
                }
            };
        }

        public void DisplayDetailedAttendance(int employeeId, string monthYear)
        {
            try
            {
                // Tách chuỗi monthYear thành tháng và năm
                string[] parts = monthYear.Split('/');
                int month = int.Parse(parts[0]);
                int year = int.Parse(parts[1]);

                // Lấy dữ liệu chấm công chi tiết
                var detailedAttendance = GetDetailedAttendance(employeeId, month, year);

                // Xóa dữ liệu cũ trong các bảng
                ClearAttendanceTables();

                // Tính số ngày trong tháng
                int daysInMonth = DateTime.DaysInMonth(year, month);

                // Map để lưu trữ trạng thái của mỗi ngày
                Dictionary<int, string> attendanceMap = new Dictionary<int, string>();

                // Lưu trữ thông tin chi tiết chấm công vào Map
                foreach (var attendance in detailedAttendance)
                {
                    string dayStr = attendance["day"].ToString();
                    int day = int.Parse(dayStr.Split('/')[0]);
                    attendanceMap[day] = attendance["status"].ToString();
                }

                // Phân chia dữ liệu cho 5 bảng
                int daysPerTable = (daysInMonth + 4) / 5;

                for (int i = 0; i < 5; i++)
                {
                    int startDay = i * daysPerTable + 1;
                    int endDay = Math.Min(startDay + daysPerTable - 1, daysInMonth);

                    // Lấy DataGridView hiện tại
                    DataGridView dgv = GetAttendanceTableByIndex(i + 1);
                    dgv.Rows.Clear();

                    // Thêm dữ liệu vào bảng
                    for (int day = startDay; day <= endDay; day++)
                    {
                        string status = attendanceMap.ContainsKey(day) ? attendanceMap[day] : "N/A";
                        dgv.Rows.Add(day, status);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi hiển thị chi tiết chấm công: {ex.Message}",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        private void ClearAttendanceTables()
        {
            // Xóa tất cả các hàng trong DataGridView của từng bảng
            NgayChamCong1.Rows.Clear();
            NgayChamCong2.Rows.Clear();
            NgayChamCong3.Rows.Clear();
            NgayChamCong4.Rows.Clear();
            NgayChamCong5.Rows.Clear();
        }

        private DataGridView GetAttendanceTableByIndex(int index)
        {
            switch (index)
            {
                case 1:
                    return NgayChamCong1;
                case 2:
                    return NgayChamCong2;
                case 3:
                    return NgayChamCong3;
                case 4:
                    return NgayChamCong4;
                case 5:
                    return NgayChamCong5;
                default:
                    throw new ArgumentException("Invalid table index");
            }
        }

        public List<Dictionary<string, object>> GetDetailedAttendance(int employeeId, int month, int year)
        {
            // Tạo chuỗi định dạng tháng/năm (MM/yyyy)
            string monthYear = $"{month:D2}/{year:D4}";
            Debug.WriteLine($"Fetching detailed attendance for Employee ID: {employeeId}, Month/Year: {monthYear}");

            return GetDetailedAttendanceByEmployeeAndMonth(employeeId, monthYear);
        }

        public List<Dictionary<string, object>> GetDetailedAttendanceByEmployeeAndMonth(int employeeId, string monthYear)
        {
            List<Dictionary<string, object>> detailedAttendance = new List<Dictionary<string, object>>();

            string sql = @"
    SELECT employee_id, DATE_FORMAT(day, '%d/%m/%Y') AS day, status 
    FROM attendances 
    WHERE employee_id = @employeeId AND DATE_FORMAT(day, '%m/%Y') = @monthYear 
    ORDER BY day";

            try
            {
                Debug.WriteLine($"SQL Query: {sql}");

                using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    Debug.WriteLine("Created MySQL connection.");
                    Debug.WriteLine($"Connection state before opening: {conn.State}");

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                        Debug.WriteLine("Database connection established.");
                    }
                    else
                    {
                        Debug.WriteLine("Connection was already open.");
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", employeeId);
                        cmd.Parameters.AddWithValue("@monthYear", monthYear);

                        Debug.WriteLine("Command created and parameters added.");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            Debug.WriteLine("Executing query and reading data...");
                            while (reader.Read())
                            {
                                var attendance = new Dictionary<string, object>
                        {
                            { "employee_id", reader.GetInt32("employee_id") },
                            { "day", reader.GetString("day") },
                            { "status", reader.GetString("status") }
                        };

                                detailedAttendance.Add(attendance);
                            }
                        }
                    }

                    Debug.WriteLine($"Connection state after query: {conn.State}");
                }
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine($"MySQL error: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unexpected error: {ex.Message}");
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return detailedAttendance;
        }




        private void displayAttendance()
        {
            // Lấy danh sách chấm công (tương đương AttendanceData trong Java)
            List<Dictionary<string, object>> attendanceList = AttendanceData();

            // Cập nhật DataGridView với kết quả
            UpdateTableWithResults(attendanceList);
        }

        private void UpdateTableWithResults(List<Dictionary<string, object>> results)
        {
            DataGridView dataGridView = jtbChamCong;  // giả sử dgvBangChamCong là DataGridView của bạn
            dataGridView.Rows.Clear();  // Xóa tất cả các dòng hiện tại trong DataGridView

            int stt = 1;
            foreach (var row in results)
            {
                dataGridView.Rows.Add(
                    stt++,
                    row["employee_id"],
                    row["month"],
                    row["dayOff"],
                    row["dayWork"]
                );
            }
        }

        private List<Dictionary<string, object>> AttendanceData()
        {
            List<Dictionary<string, object>> attendanceList = new List<Dictionary<string, object>>();

            string sql = @"
    SELECT 
    employee_id, 
    DATE_FORMAT(day, '%m/%Y') AS month, 
    SUM(CASE WHEN status = 'Nghỉ' THEN 1 ELSE 0 END) AS dayOff, 
    SUM(CASE WHEN status = 'Đi Làm' THEN 1 ELSE 0 END) AS dayWork
    FROM attendances
    GROUP BY employee_id, DATE_FORMAT(day, '%m/%Y')";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                try
                {
                    Debug.WriteLine("Created MySQL connection.");
                    Debug.WriteLine($"Connection state before opening: {conn.State}");

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                        Debug.WriteLine("Database connection established.");
                    }
                    else
                    {
                        Debug.WriteLine("Connection was already open.");
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var row = new Dictionary<string, object>
                        {
                            { "employee_id", reader.GetInt32("employee_id") },
                            { "month", reader.GetString("month") },
                            { "dayOff", reader.GetInt32("dayOff") },
                            { "dayWork", reader.GetInt32("dayWork") }
                        };

                                attendanceList.Add(row);
                            }
                        }
                    }

                    Debug.WriteLine($"Connection state after query: {conn.State}");

                    if (conn.State != ConnectionState.Closed)
                    {
                        Debug.WriteLine("Closing connection manually.");
                        conn.Close();
                    }
                    else
                    {
                        Debug.WriteLine("Connection was already closed.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn cơ sở dữ liệu: " + ex.Message);
                }
            }

            return attendanceList;
        }


        public int GetDayOffForEmployee(int employeeId, string monthYear)
        {
            // Tách monthYear thành tháng và năm
            string[] parts = monthYear.Split('/');
            if (parts.Length != 2)
            {
                return 0; // Thoát nếu định dạng không hợp lệ
            }

            int month;
            int year;
            if (!int.TryParse(parts[0], out month) || !int.TryParse(parts[1], out year))
            {
                return 0; // Thoát nếu có lỗi khi chuyển đổi
            }

            foreach (DataGridViewRow row in jtbChamCong.Rows)
            {
                // Lấy giá trị tháng và năm từ cột monthYear
                string monthYearValue = row.Cells[2].Value.ToString();
                string[] monthYearParts = monthYearValue.Split('/');

                if (monthYearParts.Length == 2)
                {
                    int rowMonth = int.Parse(monthYearParts[0]); // Lấy tháng
                    int rowYear = int.Parse(monthYearParts[1]); // Lấy năm

                    // Kiểm tra employeeId, month và year có khớp không
                    if (row.Cells[1].Value.ToString() == employeeId.ToString() && rowMonth == month && rowYear == year)
                    {
                        int dayOff = int.Parse(row.Cells[3].Value.ToString()); // Cột Day Off
                        return dayOff;
                    }
                }
            }

            // Trả về 0 nếu không tìm thấy
            return 0;
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            displayAttendance();
        }

        private void btnChamcong_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("btnChamcong_Click started.");

            // Kiểm tra chỉ số hàng đã chọn từ bảng
            int selectedRow = jtbChamCong.SelectedCells[0].RowIndex;
            Debug.WriteLine($"Selected row index: {selectedRow}");

            // Kiểm tra xem có hàng nào được chọn không
            if (selectedRow >= 0)
            {
                try
                {
                    // Lấy thông tin nhân viên và tháng/năm từ bảng
                    int employeeId = Convert.ToInt32(jtbChamCong.Rows[selectedRow].Cells[1].Value);
                    string monthYear = jtbChamCong.Rows[selectedRow].Cells[2].Value.ToString();

                    Debug.WriteLine($"Employee ID: {employeeId}, Month/Year: {monthYear}");

                    // Chia tháng và năm từ chuỗi monthYear
                    string[] parts = monthYear.Split('/');
                    int month = int.Parse(parts[0]);
                    int year = int.Parse(parts[1]);

                    Debug.WriteLine($"Parsed Month: {month}, Year: {year}");

                    // Tìm form cha của form hiện tại
                    Form parentForm = this.FindForm();
                    Debug.WriteLine($"Parent Form: {parentForm.Name}");

                    // Tạo và hiển thị dialog FormNgayChamCong
                    Debug.WriteLine("Creating FormNgayChamCong dialog...");
                    FormNgayChamCong dialog = new FormNgayChamCong(parentForm, employeeId, month, year);
                    dialog.StartPosition = FormStartPosition.CenterParent;

                    Debug.WriteLine("Showing dialog...");
                    dialog.ShowDialog();

                    // Gọi phương thức hiển thị lại danh sách chấm công sau khi đóng dialog
                    Debug.WriteLine("Refreshing attendance display...");
                    displayAttendance();
                }
                catch (Exception ex)
                {
                    // Lỗi xảy ra trong quá trình thực hiện
                    Debug.WriteLine($"Error in btnChamcong_Click: {ex.Message}");
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Trường hợp không có hàng nào được chọn
                Debug.WriteLine("No row selected.");
                MessageBox.Show("Vui lòng chọn nhân viên cần chấm công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




    }
}
