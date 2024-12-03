namespace QUANLYNHANVIEN_1
{
    partial class FormChamcong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListSearch = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            panel1 = new Panel();
            NgayChamCong5 = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            NgayChamCong4 = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            NgayChamCong3 = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            NgayChamCong2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            NgayChamCong1 = new DataGridView();
            Day = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnBack = new Button();
            btnUpdateData = new Button();
            btnChamcong = new Button();
            jtbChamCong = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NgayChamCong5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NgayChamCong4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NgayChamCong3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NgayChamCong2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NgayChamCong1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jtbChamCong).BeginInit();
            SuspendLayout();
            // 
            // ListSearch
            // 
            ListSearch.BackColor = Color.FromArgb(0, 102, 104);
            ListSearch.ForeColor = Color.White;
            ListSearch.FormattingEnabled = true;
            ListSearch.Items.AddRange(new object[] { "STT", "Mã nhân viên", "Tháng", "Ngày nghỉ", "Ngày làm việc" });
            ListSearch.Location = new Point(566, 26);
            ListSearch.Margin = new Padding(2);
            ListSearch.Name = "ListSearch";
            ListSearch.Size = new Size(146, 28);
            ListSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(736, 26);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(382, 27);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 102, 104);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1139, 22);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 34);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 102, 104);
            panel1.Controls.Add(NgayChamCong5);
            panel1.Controls.Add(NgayChamCong4);
            panel1.Controls.Add(NgayChamCong3);
            panel1.Controls.Add(NgayChamCong2);
            panel1.Controls.Add(NgayChamCong1);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnUpdateData);
            panel1.Controls.Add(btnChamcong);
            panel1.Location = new Point(3, 278);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1272, 381);
            panel1.TabIndex = 5;
            // 
            // NgayChamCong5
            // 
            NgayChamCong5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NgayChamCong5.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            NgayChamCong5.Location = new Point(1015, 13);
            NgayChamCong5.Name = "NgayChamCong5";
            NgayChamCong5.RowHeadersWidth = 51;
            NgayChamCong5.Size = new Size(243, 289);
            NgayChamCong5.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Ngày";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Trạng thái";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 110;
            // 
            // NgayChamCong4
            // 
            NgayChamCong4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NgayChamCong4.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            NgayChamCong4.Location = new Point(766, 13);
            NgayChamCong4.Name = "NgayChamCong4";
            NgayChamCong4.RowHeadersWidth = 51;
            NgayChamCong4.Size = new Size(243, 289);
            NgayChamCong4.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Ngày";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Trạng thái";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 110;
            // 
            // NgayChamCong3
            // 
            NgayChamCong3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NgayChamCong3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            NgayChamCong3.Location = new Point(517, 13);
            NgayChamCong3.Name = "NgayChamCong3";
            NgayChamCong3.RowHeadersWidth = 51;
            NgayChamCong3.Size = new Size(243, 289);
            NgayChamCong3.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Ngày";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Trạng thái";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 110;
            // 
            // NgayChamCong2
            // 
            NgayChamCong2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NgayChamCong2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            NgayChamCong2.Location = new Point(268, 13);
            NgayChamCong2.Name = "NgayChamCong2";
            NgayChamCong2.RowHeadersWidth = 51;
            NgayChamCong2.Size = new Size(243, 289);
            NgayChamCong2.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Ngày";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Trạng thái";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 110;
            // 
            // NgayChamCong1
            // 
            NgayChamCong1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NgayChamCong1.Columns.AddRange(new DataGridViewColumn[] { Day, Status });
            NgayChamCong1.Location = new Point(19, 13);
            NgayChamCong1.Name = "NgayChamCong1";
            NgayChamCong1.RowHeadersWidth = 51;
            NgayChamCong1.Size = new Size(243, 289);
            NgayChamCong1.TabIndex = 14;
            // 
            // Day
            // 
            Day.HeaderText = "Ngày";
            Day.MinimumWidth = 6;
            Day.Name = "Day";
            Day.ReadOnly = true;
            Day.Width = 80;
            // 
            // Status
            // 
            Status.HeaderText = "Trạng thái";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 110;
            // 
            // btnBack
            // 
            btnBack.ForeColor = Color.FromArgb(0, 102, 104);
            btnBack.Location = new Point(19, 319);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 47);
            btnBack.TabIndex = 13;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpdateData
            // 
            btnUpdateData.ForeColor = Color.FromArgb(0, 102, 104);
            btnUpdateData.Location = new Point(1119, 319);
            btnUpdateData.Margin = new Padding(2);
            btnUpdateData.Name = "btnUpdateData";
            btnUpdateData.Size = new Size(139, 47);
            btnUpdateData.TabIndex = 12;
            btnUpdateData.Text = "Cập nhật dữ liệu";
            btnUpdateData.UseVisualStyleBackColor = true;
            btnUpdateData.Click += btnUpdateData_Click;
            // 
            // btnChamcong
            // 
            btnChamcong.ForeColor = Color.FromArgb(0, 102, 104);
            btnChamcong.Location = new Point(996, 319);
            btnChamcong.Margin = new Padding(2);
            btnChamcong.Name = "btnChamcong";
            btnChamcong.Size = new Size(107, 47);
            btnChamcong.TabIndex = 11;
            btnChamcong.Text = "Chấm công";
            btnChamcong.UseVisualStyleBackColor = true;
            btnChamcong.Click += btnChamcong_Click;
            // 
            // jtbChamCong
            // 
            jtbChamCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            jtbChamCong.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            jtbChamCong.Location = new Point(414, 82);
            jtbChamCong.Margin = new Padding(2);
            jtbChamCong.Name = "jtbChamCong";
            jtbChamCong.RowHeadersWidth = 62;
            jtbChamCong.Size = new Size(826, 180);
            jtbChamCong.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "STT";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column2.HeaderText = "Mã nhân viên";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 126;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tháng";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ngày nghỉ";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column5.HeaderText = "Ngày làm việc";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 132;
            // 
            // FormChamcong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1276, 670);
            Controls.Add(jtbChamCong);
            Controls.Add(panel1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(ListSearch);
            Margin = new Padding(2);
            Name = "FormChamcong";
            Text = "FormChamcong";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NgayChamCong5).EndInit();
            ((System.ComponentModel.ISupportInitialize)NgayChamCong4).EndInit();
            ((System.ComponentModel.ISupportInitialize)NgayChamCong3).EndInit();
            ((System.ComponentModel.ISupportInitialize)NgayChamCong2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NgayChamCong1).EndInit();
            ((System.ComponentModel.ISupportInitialize)jtbChamCong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ListSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Panel panel1;
        private Button btnUpdateData;
        private Button btnChamcong;
        private TableLayoutPanel tbStatus5;
        private Label label14;
        private Label label15;
        private TableLayoutPanel tbStatus4;
        private Label label12;
        private Label label13;
        private TableLayoutPanel tbstatus3;
        private Label label5;
        private Label label11;
        private TableLayoutPanel tbStatus2;
        private Label label3;
        private Label label4;
        private Button btnBack;
        private DataGridView jtbChamCong;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridView NgayChamCong1;
        private DataGridView NgayChamCong5;
        private DataGridView NgayChamCong4;
        private DataGridView NgayChamCong3;
        private DataGridView NgayChamCong2;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}