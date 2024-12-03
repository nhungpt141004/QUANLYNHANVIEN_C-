using MySql.Data.MySqlClient;
using QUANLYNHANVIEN_1.database;
using Syncfusion.WinForms.Input;
using Syncfusion.WinForms.Input.Events;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace QUANLYNHANVIEN_1
{
    public partial class FormNgayChamCong : Form
    {
        // Lưu trạng thái của từng ngày (Map -> Dictionary trong C#)
        private Dictionary<int, string> dayStatus = new Dictionary<int, string>();

        // Danh sách các ngày nghỉ (List trong C#)
        private List<int> offDays = new List<int>();

        // Lưu trạng thái cho từng tháng (Map trong C# -> Dictionary)
        private Dictionary<string, Dictionary<int, string>> monthDayStatus = new Dictionary<string, Dictionary<int, string>>();

        // Khai báo id nhân viên
        private int employeeId;

        // Khai báo đối tượng SalaryViews
        private FormTinhluong salaryViews;


        public FormNgayChamCong(Form parent, int employeeId, int month, int year)
        {
            // Gọi constructor của Form (tương đương với super(parent, true) trong Java)
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;

            InitializeComponent(); // Gọi hàm khởi tạo giao diện

            this.employeeId = employeeId; // Gán employeeId từ tham số
            monthDayStatus.Clear(); // Xóa trạng thái cũ
            offDays.Clear(); // Xóa danh sách ngày nghỉ cũ

            // Cập nhật tháng và năm cho SfCalendar
            sfCalendar1.SelectedDate = new DateTime(year, month, 1);




            // Tải dữ liệu theo employeeId và các năm chỉ định
            LoadDataFromDatabase(2022, 2024);

            // Thêm sự kiện nhấp chuột vào ngày
            //AddCalendarMouseListener();

            // Khởi tạo trạng thái mặc định cho các ngày
            InitializeDayStatuses(month, year);
        }

        // Constructor không có tháng và năm, sử dụng tháng và năm hiện tại
        public FormNgayChamCong(Form parent, int employeeId)
            : this(parent, employeeId, DateTime.Now.Month, DateTime.Now.Year) { }

        // Constructor với employeeId và SalaryViews
        public FormNgayChamCong(int employeeId, FormTinhluong salaryViews)
        {
            this.employeeId = employeeId;
            this.salaryViews = salaryViews; // Gán đối tượng SalaryViews
        }

        private void sfCalendar1_Click(object sender, EventArgs e)
        {
            // Lấy ngày hiện tại được chọn
            DateTime selectedDate = sfCalendar1.SelectedDate.Value;
            int day = selectedDate.Day;
            int month = selectedDate.Month;
            int year = selectedDate.Year;
            string monthYearKey = $"{month}/{year}";

            // Khởi tạo nếu tháng/chưa tồn tại
            if (!monthDayStatus.ContainsKey(monthYearKey))
            {
                monthDayStatus[monthYearKey] = new Dictionary<int, string>();
            }

            // Lấy trạng thái hiện tại của ngày
            var dayStatus = monthDayStatus[monthYearKey];
            string status = dayStatus.ContainsKey(day) ? dayStatus[day] : "Đi Làm";

            // Thay đổi trạng thái ngày (Đi Làm <-> Nghỉ)
            if (status == "Đi Làm")
            {
                dayStatus[day] = "Nghỉ";
                if (!offDays.Contains(day))
                {
                    offDays.Add(day);
                }
            }
            else
            {
                dayStatus[day] = "Đi Làm";
                offDays.Remove(day);
            }


            // Yêu cầu vẽ lại lịch
            sfCalendar1.Refresh();
        }

        private void SfCalendar1_DrawCell(SfCalendar sender, DrawCellEventArgs e)
        {
            // Lấy thông tin ngày hiện tại
            DateTime date = e.Value.Value; // Sử dụng e.Value thay cho e.Date
            int day = date.Day;
            int month = date.Month;
            int year = date.Year;
            string monthYearKey = $"{month}/{year}";

            // Kiểm tra nếu ngày là ngày Chủ nhật (Sunday)
            //if (date.DayOfWeek == DayOfWeek.Sunday)
            //{
            //    // Đánh dấu là ngày nghỉ
            //    if (!monthDayStatus.ContainsKey(monthYearKey))
            //    {
            //        monthDayStatus[monthYearKey] = new Dictionary<int, string>();
            //    }
            //    monthDayStatus[monthYearKey][day] = "Nghỉ";
            //}

            // Kiểm tra trạng thái ngày (nếu đã có thông tin về ngày này)
            if (monthDayStatus.ContainsKey(monthYearKey) && monthDayStatus[monthYearKey].ContainsKey(day))
            {
                string status = monthDayStatus[monthYearKey][day];

                // Nếu ngày là ngày nghỉ
                if (status == "Nghỉ")
                {
                    // Tô màu nền đỏ nhạt cho ngày nghỉ
                    e.BackColor = Color.LightCoral;
                    e.ForeColor = Color.White;
                }
                else
                {
                    // Nếu ngày không phải ngày nghỉ, tô lại với màu nền mặc định
                    e.BackColor = Color.White;
                    e.ForeColor = Color.Black;
                }
            }
            else
            {
                // Nếu không có trạng thái ngày (chưa có thông tin về ngày), tô lại với màu nền mặc định
                e.BackColor = Color.White;
                e.ForeColor = Color.Black;
            }
            // Vẽ số ngày trong ô
            if (!e.Handled)  // Nếu chưa xử lý bởi các điều kiện đặc biệt
            {
                TextRenderer.DrawText(e.Graphics, day.ToString(), new Font("Segoe UI", 10), e.CellBounds, e.ForeColor);
            }
        }

        private void Thêm_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem SelectedDate có null không
            if (!sfCalendar1.SelectedDate.HasValue)
            {
                MessageBox.Show("Chưa chọn ngày", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mở kết nối cơ sở dữ liệu trong using block để đảm bảo đóng tự động
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                var calendar = sfCalendar1.SelectedDate.Value;  // Sử dụng SelectedDate
                int month = calendar.Month;
                int year = calendar.Year;
                string monthYearKey = $"{month}/{year}";

                if (!monthDayStatus.ContainsKey(monthYearKey))
                {
                    InitializeDayStatuses(month, year);
                }

                var dayStatus = monthDayStatus[monthYearKey];

                try
                {
                    for (int day = 1; day <= 31; day++)
                    {
                        if (IsDateValid(year, month, day))
                        {
                            string status = dayStatus.ContainsKey(day) ? dayStatus[day] : "Đi Làm";

                            // Kiểm tra xem ngày đã tồn tại trong bảng attendances chưa
                            string checkQuery = "SELECT COUNT(*) AS count FROM attendances WHERE DAY(day) = @day AND MONTH(day) = @month AND YEAR(day) = @year AND employee_id = @employeeId";
                            using (var checkCmd = new MySqlCommand(checkQuery, conn))
                            {
                                checkCmd.Parameters.AddWithValue("@day", day);
                                checkCmd.Parameters.AddWithValue("@month", month);
                                checkCmd.Parameters.AddWithValue("@year", year);
                                checkCmd.Parameters.AddWithValue("@employeeId", this.employeeId);

                                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                                if (count == 0)
                                {
                                    // Thêm mới
                                    string insertQuery = "INSERT INTO attendances (day, status, employee_id) VALUES (@day, @status, @employeeId)";
                                    using (var insertCmd = new MySqlCommand(insertQuery, conn))
                                    {
                                        insertCmd.Parameters.AddWithValue("@day", new DateTime(year, month, day));
                                        insertCmd.Parameters.AddWithValue("@status", status);
                                        insertCmd.Parameters.AddWithValue("@employeeId", this.employeeId);

                                        insertCmd.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    // Cập nhật trạng thái nếu đã tồn tại
                                    string updateQuery = "UPDATE attendances SET status = @status WHERE DAY(day) = @day AND MONTH(day) = @month AND YEAR(day) = @year AND employee_id = @employeeId";
                                    using (var updateCmd = new MySqlCommand(updateQuery, conn))
                                    {
                                        updateCmd.Parameters.AddWithValue("@status", status);
                                        updateCmd.Parameters.AddWithValue("@day", day);
                                        updateCmd.Parameters.AddWithValue("@month", month);
                                        updateCmd.Parameters.AddWithValue("@year", year);
                                        updateCmd.Parameters.AddWithValue("@employeeId", this.employeeId);

                                        updateCmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                    }

                    // Cập nhật bảng salaries sau khi lưu trạng thái chấm công
                    string monthYear = $"{month}/{year}";
                    InsertIntoSalary(this.employeeId, monthYear);

                    MessageBox.Show("Đã lưu trạng thái chấm công cho nhân viên " + this.employeeId + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Lỗi khi lưu trạng thái chấm công: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } // Kết thúc using, conn sẽ tự động đóng tại đây
        }





        // Method to initialize default attendance statuses for the days in the given month
        private void InitializeDayStatuses(int month, int year)
        {
            string monthYearKey = $"{month}/{year}"; // Create a unique key for the month-year combination

            if (!monthDayStatus.ContainsKey(monthYearKey))
            {
                var dayStatus = new Dictionary<int, string>(); // Initialize a dictionary for the day's status

                // Create a DateTime object for the first day of the month
                DateTime firstDayOfMonth = new DateTime(year, month, 1);

                // Get the number of days in the month
                int daysInMonth = DateTime.DaysInMonth(year, month);

                // Loop through all days of the month and assign default status as "Đi Làm"
                for (int day = 1; day <= daysInMonth; day++)
                {
                    dayStatus[day] = "Đi Làm"; // Assign default status
                }

                // Store the status for this month-year combination in the dictionary
                monthDayStatus[monthYearKey] = dayStatus;
            }
        }
        // Method to check if the given date is valid
        private bool IsDateValid(int year, int month, int day)
        {
            try
            {
                // Create a DateTime object with the provided year, month, and day
                DateTime date = new DateTime(year, month, day);

                // If the date is valid, return true
                return (date.Year == year && date.Month == month && date.Day == day);
            }
            catch (ArgumentOutOfRangeException)
            {
                // If the DateTime constructor throws an exception, the date is invalid
                return false;
            }
        }
        private void InsertIntoSalary(int employeeId, string monthYear)
        {
            // Split the monthYear string into month and year
            string[] parts = monthYear.Split('/');
            if (parts.Length != 2)
            {
                return;
            }

            int month = int.Parse(parts[0]);
            int year = int.Parse(parts[1]);

            // Insert into the salaries table
            string sql = "INSERT INTO salaries (employee_id, salary_month, salary_year) VALUES (@employeeId, @month, @year)";
            try
            {
                using (var conn = new DatabaseConnection().GetConnection())  // Assuming you have a GetConnection method that returns a MySqlConnection
                {

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", employeeId);
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@year", year);

                        // Execute the SQL command
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle exception (optional logging or displaying error message)
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        private void LoadDataFromDatabase(int startYear, int endYear)
        {
            string query = "SELECT DAY(day) AS day, MONTH(day) AS month, YEAR(day) AS year, status " +
                           "FROM attendances WHERE employee_id = @employeeId AND YEAR(day) BETWEEN @startYear AND @endYear";

            offDays.Clear(); // Clear the list of off days before adding new ones

            try
            {
                // Use 'using' to ensure the connection is properly disposed of
                using (MySqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    // Debug: Check connection state before opening
                    Debug.WriteLine("Connection state before opening: " + conn.State);

                    // Check if the connection is already open, if so, close it
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                        Debug.WriteLine("Connection was already open, now closed.");
                    }

                    // Create the command inside 'using' block to ensure it's disposed of properly
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", this.employeeId);  // Use employeeId from the class
                        cmd.Parameters.AddWithValue("@startYear", startYear);
                        cmd.Parameters.AddWithValue("@endYear", endYear);

                        conn.Open();

                        // Debug: Check connection state after opening
                        Debug.WriteLine("Connection state after opening: " + conn.State);

                        // Use 'using' for MySqlDataReader to ensure it's disposed of properly
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int day = reader.GetInt32("day");
                                int month = reader.GetInt32("month");
                                int year = reader.GetInt32("year");
                                string status = reader.GetString("status");

                                // Create the key for month/year to differentiate statuses for each day
                                string monthYearKey = $"{month}/{year}";

                                // Ensure initialization if status map for this month/year doesn't exist
                                if (!monthDayStatus.ContainsKey(monthYearKey))
                                {
                                    monthDayStatus[monthYearKey] = new Dictionary<int, string>();
                                }

                                // Get the map for the specific month/year
                                var dayStatus = monthDayStatus[monthYearKey];

                                // Update the status for the specific day
                                dayStatus[day] = status;

                                // Add to offDays list if the status is "Nghỉ"
                                if (status == "Nghỉ")
                                {
                                    offDays.Add(day);
                                }
                            }
                        }

                        // Debug: Check connection state after reading
                        Debug.WriteLine("Connection state after reading: " + conn.State);
                    }

                    // Debug: Check connection state after using block (closed)
                    Debug.WriteLine("Connection state after using block (closed): " + conn.State);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Update the color for off days in the calendar (Assuming jcldAttendenceDate is a calendar control)
            //UpdateOffDaysColor(jcldAttendenceDate.DayChooser.DayPanel.Controls);
        }


        private void UpdateOffDaysColor()
        {
            // Kiểm tra nếu SelectedDate không phải null
            if (sfCalendar1.SelectedDate.HasValue)
            {
                // Lấy tháng và năm từ control SfCalendar
                DateTime selectedDate = sfCalendar1.SelectedDate.Value;
                int month = selectedDate.Month;
                int year = selectedDate.Year;
                string monthYearKey = $"{month}/{year}";

                // Debug: Kiểm tra giá trị tháng/năm được chọn
                Debug.WriteLine($"Selected Date: {selectedDate.ToShortDateString()}");
                Debug.WriteLine($"Month/Year Key: {monthYearKey}");

                // Kiểm tra xem có trạng thái cho tháng/năm này không
                if (monthDayStatus.ContainsKey(monthYearKey))
                {
                    var dayStatus = monthDayStatus[monthYearKey];

                    // Debug: Kiểm tra các trạng thái ngày trong tháng/năm
                    Debug.WriteLine($"Found day status for {monthYearKey}: {dayStatus.Count} days");

                    // Xử lý vẽ ngày nghỉ trong control sfCalendar1
                    sfCalendar1.DrawCell -= SfCalendar1_DrawCell; // Remove previous handlers to avoid multiple event handlers
                    sfCalendar1.DrawCell += SfCalendar1_DrawCell; // Add the event handler for drawing cells

                    // Debug: Xác nhận đã thêm handler vẽ lại cells
                    Debug.WriteLine("Event handler for DrawCell has been added.");
                }
                else
                {
                    // Debug: Nếu không tìm thấy dữ liệu trạng thái cho tháng/năm
                    Debug.WriteLine($"No day status found for {monthYearKey}. Skipping.");
                }
            }
            else
            {
                // Debug: Nếu không có SelectedDate
                Debug.WriteLine("No selected date found in SfCalendar.");
            }
        }

        private void btnHienThiNgayNghi_Click(object sender, EventArgs e)
        {
            UpdateOffDaysColor();
        }
    }
}
