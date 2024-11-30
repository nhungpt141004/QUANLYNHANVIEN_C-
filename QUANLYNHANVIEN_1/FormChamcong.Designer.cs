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
            tbChamcong = new TableLayoutPanel();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
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
            tbChamcong.SuspendLayout();
            panel1.SuspendLayout();
            tbStatus5.SuspendLayout();
            tbStatus4.SuspendLayout();
            tbstatus3.SuspendLayout();
            tbStatus2.SuspendLayout();
            tbStatus1.SuspendLayout();
            SuspendLayout();
            // 
            // ListSearch
            // 
            ListSearch.BackColor = Color.FromArgb(0, 102, 104);
            ListSearch.ForeColor = Color.White;
            ListSearch.FormattingEnabled = true;
            ListSearch.Items.AddRange(new object[] { "STT", "Mã nhân viên", "Tháng", "Ngày nghỉ", "Ngày làm việc" });
            ListSearch.Location = new Point(44, 27);
            ListSearch.Name = "ListSearch";
            ListSearch.Size = new Size(182, 33);
            ListSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(297, 29);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(476, 31);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 102, 104);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(828, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(126, 42);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // tbChamcong
            // 
            tbChamcong.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tbChamcong.ColumnCount = 5;
            tbChamcong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.7017536F));
            tbChamcong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.29825F));
            tbChamcong.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 225F));
            tbChamcong.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 212F));
            tbChamcong.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 186F));
            tbChamcong.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tbChamcong.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            tbChamcong.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tbChamcong.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tbChamcong.Controls.Add(label10, 4, 0);
            tbChamcong.Controls.Add(label9, 3, 0);
            tbChamcong.Controls.Add(label7, 1, 0);
            tbChamcong.Controls.Add(label6, 0, 0);
            tbChamcong.Controls.Add(label8, 2, 0);
            tbChamcong.Location = new Point(44, 82);
            tbChamcong.Name = "tbChamcong";
            tbChamcong.RowCount = 2;
            tbChamcong.RowStyles.Add(new RowStyle(SizeType.Percent, 20.3571434F));
            tbChamcong.RowStyles.Add(new RowStyle(SizeType.Percent, 79.64286F));
            tbChamcong.Size = new Size(907, 247);
            tbChamcong.TabIndex = 4;
            // 
            // label10
            // 
            label10.Location = new Point(722, 1);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(181, 49);
            label10.TabIndex = 4;
            label10.Text = "Ngày làm việc";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Location = new Point(509, 1);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(206, 49);
            label9.TabIndex = 3;
            label9.Text = "Ngày nghỉ";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Location = new Point(90, 1);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(186, 49);
            label7.TabIndex = 1;
            label7.Text = "Mã nhân viên";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Location = new Point(4, 1);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(79, 49);
            label6.TabIndex = 0;
            label6.Text = "STT";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Location = new Point(283, 1);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(219, 49);
            label8.TabIndex = 2;
            label8.Text = "Tháng";
            label8.TextAlign = ContentAlignment.MiddleCenter;
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
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 262);
            panel1.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.ForeColor = Color.FromArgb(0, 102, 104);
            btnBack.Location = new Point(24, 215);
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
            tbStatus5.Name = "tbStatus5";
            tbStatus5.RowCount = 2;
            tbStatus5.RowStyles.Add(new RowStyle(SizeType.Percent, 26.8456383F));
            tbStatus5.RowStyles.Add(new RowStyle(SizeType.Percent, 73.1543655F));
            tbStatus5.Size = new Size(164, 179);
            tbStatus5.TabIndex = 10;
            // 
            // label14
            // 
            label14.Location = new Point(69, 1);
            label14.Name = "label14";
            label14.RightToLeft = RightToLeft.No;
            label14.Size = new Size(91, 39);
            label14.TabIndex = 6;
            label14.Text = "Trạng thái";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Location = new Point(4, 1);
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
            tbStatus4.Name = "tbStatus4";
            tbStatus4.RowCount = 2;
            tbStatus4.RowStyles.Add(new RowStyle(SizeType.Percent, 26.8456383F));
            tbStatus4.RowStyles.Add(new RowStyle(SizeType.Percent, 73.1543655F));
            tbStatus4.Size = new Size(164, 179);
            tbStatus4.TabIndex = 9;
            // 
            // label12
            // 
            label12.Location = new Point(69, 1);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(91, 39);
            label12.TabIndex = 6;
            label12.Text = "Trạng thái";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Location = new Point(4, 1);
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
            tbstatus3.Name = "tbstatus3";
            tbstatus3.RowCount = 2;
            tbstatus3.RowStyles.Add(new RowStyle(SizeType.Percent, 26.8456383F));
            tbstatus3.RowStyles.Add(new RowStyle(SizeType.Percent, 73.1543655F));
            tbstatus3.Size = new Size(164, 179);
            tbstatus3.TabIndex = 8;
            // 
            // label5
            // 
            label5.Location = new Point(69, 1);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(91, 39);
            label5.TabIndex = 6;
            label5.Text = "Trạng thái";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Location = new Point(4, 1);
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
            tbStatus2.Location = new Point(217, 16);
            tbStatus2.Name = "tbStatus2";
            tbStatus2.RowCount = 2;
            tbStatus2.RowStyles.Add(new RowStyle(SizeType.Percent, 26.8456383F));
            tbStatus2.RowStyles.Add(new RowStyle(SizeType.Percent, 73.1543655F));
            tbStatus2.Size = new Size(164, 179);
            tbStatus2.TabIndex = 7;
            // 
            // label3
            // 
            label3.Location = new Point(69, 1);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(91, 39);
            label3.TabIndex = 6;
            label3.Text = "Trạng thái";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(4, 1);
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
            tbStatus1.Name = "tbStatus1";
            tbStatus1.RowCount = 2;
            tbStatus1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.8456383F));
            tbStatus1.RowStyles.Add(new RowStyle(SizeType.Percent, 73.1543655F));
            tbStatus1.Size = new Size(164, 179);
            tbStatus1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(66, 1);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(94, 39);
            label2.TabIndex = 6;
            label2.Text = "Trạng thái";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(4, 1);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(55, 39);
            label1.TabIndex = 5;
            label1.Text = "Ngày";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormChamcong
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(994, 609);
            Controls.Add(panel1);
            Controls.Add(tbChamcong);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(ListSearch);
            Name = "FormChamcong";
            Text = "FormChamcong";
            tbChamcong.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tbStatus5.ResumeLayout(false);
            tbStatus4.ResumeLayout(false);
            tbstatus3.ResumeLayout(false);
            tbStatus2.ResumeLayout(false);
            tbStatus1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ListSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private TableLayoutPanel tbChamcong;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label8;
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
    }
}