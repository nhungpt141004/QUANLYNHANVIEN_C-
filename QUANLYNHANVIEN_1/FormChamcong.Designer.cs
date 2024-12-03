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
            btnBack = new Button();
            btnUpdateData = new Button();
            btnChamcong = new Button();
            tbStatus5 = new TableLayoutPanel();
            label14 = new Label();
            label15 = new Label();
            tbStatus4 = new TableLayoutPanel();
            label12 = new Label();
            label13 = new Label();
            tbstatus3 = new TableLayoutPanel();
            label5 = new Label();
            label11 = new Label();
            tbStatus2 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            tbStatus1 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tbStatus5.SuspendLayout();
            tbStatus4.SuspendLayout();
            tbstatus3.SuspendLayout();
            tbStatus2.SuspendLayout();
            tbStatus1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ListSearch
            // 
            ListSearch.BackColor = Color.FromArgb(0, 102, 104);
            ListSearch.ForeColor = Color.White;
            ListSearch.FormattingEnabled = true;
            ListSearch.Items.AddRange(new object[] { "STT", "Mã nhân viên", "Tháng", "Ngày nghỉ", "Ngày làm việc" });
            ListSearch.Location = new Point(44, 28);
            ListSearch.Margin = new Padding(2);
            ListSearch.Name = "ListSearch";
            ListSearch.Size = new Size(182, 33);
            ListSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(298, 29);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(476, 31);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 102, 104);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(828, 22);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(126, 42);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 102, 104);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnUpdateData);
            panel1.Controls.Add(btnChamcong);
            panel1.Controls.Add(tbStatus5);
            panel1.Controls.Add(tbStatus4);
            panel1.Controls.Add(tbstatus3);
            panel1.Controls.Add(tbStatus2);
            panel1.Controls.Add(tbStatus1);
            panel1.Location = new Point(4, 348);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 262);
            panel1.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.ForeColor = Color.FromArgb(0, 102, 104);
            btnBack.Location = new Point(24, 215);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(95, 34);
            btnBack.TabIndex = 13;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpdateData
            // 
            btnUpdateData.ForeColor = Color.FromArgb(0, 102, 104);
            btnUpdateData.Location = new Point(790, 215);
            btnUpdateData.Margin = new Padding(2);
            btnUpdateData.Name = "btnUpdateData";
            btnUpdateData.Size = new Size(174, 34);
            btnUpdateData.TabIndex = 12;
            btnUpdateData.Text = "Cập nhật dữ liệu";
            btnUpdateData.UseVisualStyleBackColor = true;
            // 
            // btnChamcong
            // 
            btnChamcong.ForeColor = Color.FromArgb(0, 102, 104);
            btnChamcong.Location = new Point(621, 215);
            btnChamcong.Margin = new Padding(2);
            btnChamcong.Name = "btnChamcong";
            btnChamcong.Size = new Size(134, 34);
            btnChamcong.TabIndex = 11;
            btnChamcong.Text = "Chấm công";
            btnChamcong.UseVisualStyleBackColor = true;
            // 
            // tbStatus5
            // 
            tbStatus5.BackColor = Color.White;
            tbStatus5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tbStatus5.ColumnCount = 2;
            tbStatus5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.1015244F));
            tbStatus5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.8984756F));
            tbStatus5.Controls.Add(label14, 1, 0);
            tbStatus5.Controls.Add(label15, 0, 0);
            tbStatus5.ForeColor = Color.Black;
            tbStatus5.Location = new Point(800, 15);
            tbStatus5.Margin = new Padding(2);
            tbStatus5.Name = "tbStatus5";
            tbStatus5.RowCount = 2;
            tbStatus5.RowStyles.Add(new RowStyle(SizeType.Percent, 26.8456383F));
            tbStatus5.RowStyles.Add(new RowStyle(SizeType.Percent, 73.1543655F));
            tbStatus5.Size = new Size(164, 179);
            tbStatus5.TabIndex = 10;
            // 
            // label14
            // 
            label14.Location = new Point(68, 1);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.RightToLeft = RightToLeft.No;
            label14.Size = new Size(91, 39);
            label14.TabIndex = 6;
            label14.Text = "Trạng thái";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Location = new Point(3, 1);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.RightToLeft = RightToLeft.No;
            label15.Size = new Size(58, 39);
            label15.TabIndex = 5;
            label15.Text = "Ngày";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbStatus4
            // 
            tbStatus4.BackColor = Color.White;
            tbStatus4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tbStatus4.ColumnCount = 2;
            tbStatus4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.1015244F));
            tbStatus4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.8984756F));
            tbStatus4.Controls.Add(label12, 1, 0);
            tbStatus4.Controls.Add(label13, 0, 0);
            tbStatus4.ForeColor = Color.Black;
            tbStatus4.Location = new Point(605, 15);
            tbStatus4.Margin = new Padding(2);
            tbStatus4.Name = "tbStatus4";
            tbStatus4.RowCount = 2;
            tbStatus4.RowStyles.Add(new RowStyle(SizeType.Percent, 26.8456383F));
            tbStatus4.RowStyles.Add(new RowStyle(SizeType.Percent, 73.1543655F));
            tbStatus4.Size = new Size(164, 179);
            tbStatus4.TabIndex = 9;
            // 
            // label12
            // 
            label12.Location = new Point(68, 1);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(91, 40);
            label12.TabIndex = 6;
            label12.Text = "Trạng thái";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Location = new Point(3, 1);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.No;
            label13.Size = new Size(58, 39);
            label13.TabIndex = 5;
            label13.Text = "Ngày";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbstatus3
            // 
            tbstatus3.BackColor = Color.White;
            tbstatus3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tbstatus3.ColumnCount = 2;
            tbstatus3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.1015244F));
            tbstatus3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.8984756F));
            tbstatus3.Controls.Add(label5, 1, 0);
            tbstatus3.Controls.Add(label11, 0, 0);
            tbstatus3.ForeColor = Color.Black;
            tbstatus3.Location = new Point(411, 15);
            tbstatus3.Margin = new Padding(2);
            tbstatus3.Name = "tbstatus3";
            tbstatus3.RowCount = 2;
            tbstatus3.RowStyles.Add(new RowStyle(SizeType.Percent, 26.8456383F));
            tbstatus3.RowStyles.Add(new RowStyle(SizeType.Percent, 73.1543655F));
            tbstatus3.Size = new Size(164, 179);
            tbstatus3.TabIndex = 8;
            // 
            // label5
            // 
            label5.Location = new Point(68, 1);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(91, 39);
            label5.TabIndex = 6;
            label5.Text = "Trạng thái";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Location = new Point(3, 1);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.No;
            label11.Size = new Size(58, 39);
            label11.TabIndex = 5;
            label11.Text = "Ngày";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbStatus2
            // 
            tbStatus2.BackColor = Color.White;
            tbStatus2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tbStatus2.ColumnCount = 2;
            tbStatus2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.1015244F));
            tbStatus2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.8984756F));
            tbStatus2.Controls.Add(label3, 1, 0);
            tbStatus2.Controls.Add(label4, 0, 0);
            tbStatus2.ForeColor = Color.Black;
            tbStatus2.Location = new Point(218, 16);
            tbStatus2.Margin = new Padding(2);
            tbStatus2.Name = "tbStatus2";
            tbStatus2.RowCount = 2;
            tbStatus2.RowStyles.Add(new RowStyle(SizeType.Percent, 26.8456383F));
            tbStatus2.RowStyles.Add(new RowStyle(SizeType.Percent, 73.1543655F));
            tbStatus2.Size = new Size(164, 179);
            tbStatus2.TabIndex = 7;
            // 
            // label3
            // 
            label3.Location = new Point(68, 1);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(91, 39);
            label3.TabIndex = 6;
            label3.Text = "Trạng thái";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(3, 1);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(58, 39);
            label4.TabIndex = 5;
            label4.Text = "Ngày";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbStatus1
            // 
            tbStatus1.BackColor = Color.White;
            tbStatus1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tbStatus1.ColumnCount = 2;
            tbStatus1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.036808F));
            tbStatus1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.963192F));
            tbStatus1.Controls.Add(label2, 1, 0);
            tbStatus1.Controls.Add(label1, 0, 0);
            tbStatus1.ForeColor = Color.Black;
            tbStatus1.Location = new Point(24, 15);
            tbStatus1.Margin = new Padding(2);
            tbStatus1.Name = "tbStatus1";
            tbStatus1.RowCount = 2;
            tbStatus1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.8456383F));
            tbStatus1.RowStyles.Add(new RowStyle(SizeType.Percent, 73.1543655F));
            tbStatus1.Size = new Size(164, 179);
            tbStatus1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(65, 1);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(94, 39);
            label2.TabIndex = 6;
            label2.Text = "Trạng thái";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(3, 1);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(55, 39);
            label1.TabIndex = 5;
            label1.Text = "Ngày";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(102, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(775, 225);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "STT";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column2.HeaderText = "Mã nhân viên";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 154;
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
            Column5.Width = 159;
            // 
            // FormChamcong
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(994, 609);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(ListSearch);
            Margin = new Padding(2);
            Name = "FormChamcong";
            Text = "FormChamcong";
            panel1.ResumeLayout(false);
            tbStatus5.ResumeLayout(false);
            tbStatus4.ResumeLayout(false);
            tbstatus3.ResumeLayout(false);
            tbStatus2.ResumeLayout(false);
            tbStatus1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ListSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Panel panel1;
        private TableLayoutPanel tbStatus1;
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
        private Label label2;
        private Label label1;
        private Button btnBack;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}