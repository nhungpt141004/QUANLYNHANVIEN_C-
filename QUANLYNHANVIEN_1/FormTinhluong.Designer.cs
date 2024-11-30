namespace QUANLYNHANVIEN_1
{
    partial class FormTinhluong
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
            tbTinhluong = new TableLayoutPanel();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            label12 = new Label();
            panel1 = new Panel();
            btnBack = new Button();
            btnLoad = new Button();
            btnDelete = new Button();
            btnOuput = new Button();
            btbTinhluong = new Button();
            txtID = new TextBox();
            txtMonth = new TextBox();
            txtBonus = new TextBox();
            txtBaseSalary = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label13 = new Label();
            tbTinhluong.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ListSearch
            // 
            ListSearch.BackColor = Color.FromArgb(0, 102, 104);
            ListSearch.ForeColor = Color.White;
            ListSearch.FormattingEnabled = true;
            ListSearch.Items.AddRange(new object[] { "STT", "Mã nhân viên", "Tháng", "Ngày nghỉ", "Lương cơ bản", "Thưởng", "Lương tổng" });
            ListSearch.Location = new Point(43, 29);
            ListSearch.Name = "ListSearch";
            ListSearch.Size = new Size(182, 33);
            ListSearch.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(289, 31);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(476, 31);
            txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 102, 104);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(816, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(126, 42);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // tbTinhluong
            // 
            tbTinhluong.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tbTinhluong.ColumnCount = 7;
            tbTinhluong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.2417564F));
            tbTinhluong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.75824F));
            tbTinhluong.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 131F));
            tbTinhluong.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 141F));
            tbTinhluong.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 139F));
            tbTinhluong.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 136F));
            tbTinhluong.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 133F));
            tbTinhluong.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tbTinhluong.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tbTinhluong.Controls.Add(label11, 5, 0);
            tbTinhluong.Controls.Add(label10, 4, 0);
            tbTinhluong.Controls.Add(label9, 3, 0);
            tbTinhluong.Controls.Add(label7, 1, 0);
            tbTinhluong.Controls.Add(label6, 0, 0);
            tbTinhluong.Controls.Add(label8, 2, 0);
            tbTinhluong.Controls.Add(label12, 6, 0);
            tbTinhluong.Location = new Point(43, 92);
            tbTinhluong.Name = "tbTinhluong";
            tbTinhluong.RowCount = 2;
            tbTinhluong.RowStyles.Add(new RowStyle(SizeType.Percent, 20.3571434F));
            tbTinhluong.RowStyles.Add(new RowStyle(SizeType.Percent, 79.64286F));
            tbTinhluong.Size = new Size(899, 245);
            tbTinhluong.TabIndex = 5;
            // 
            // label11
            // 
            label11.Location = new Point(630, 1);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.No;
            label11.Size = new Size(130, 49);
            label11.TabIndex = 5;
            label11.Text = "Thưởng";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Location = new Point(490, 1);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(133, 49);
            label10.TabIndex = 4;
            label10.Text = "Lương cơ bản";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Location = new Point(348, 1);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(135, 49);
            label9.TabIndex = 3;
            label9.Text = "Ngày nghỉ";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Location = new Point(75, 1);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(134, 49);
            label7.TabIndex = 1;
            label7.Text = "Mã nhân viên";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Location = new Point(4, 1);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(64, 49);
            label6.TabIndex = 0;
            label6.Text = "STT";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Location = new Point(216, 1);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(125, 49);
            label8.TabIndex = 2;
            label8.Text = "Tháng";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Location = new Point(767, 1);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(128, 49);
            label12.TabIndex = 6;
            label12.Text = "Lương tổng";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 102, 104);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnOuput);
            panel1.Controls.Add(btbTinhluong);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(txtMonth);
            panel1.Controls.Add(txtBonus);
            panel1.Controls.Add(txtBaseSalary);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label13);
            panel1.Location = new Point(1, 361);
            panel1.Name = "panel1";
            panel1.Size = new Size(996, 250);
            panel1.TabIndex = 6;
            // 
            // btnBack
            // 
            btnBack.ForeColor = Color.FromArgb(0, 102, 104);
            btnBack.Location = new Point(877, 195);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(95, 34);
            btnBack.TabIndex = 16;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnLoad
            // 
            btnLoad.ForeColor = Color.FromArgb(0, 102, 104);
            btnLoad.Location = new Point(716, 195);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(134, 34);
            btnLoad.TabIndex = 15;
            btnLoad.Text = "Làm mới";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.FromArgb(0, 102, 104);
            btnDelete.Location = new Point(716, 132);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 34);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnOuput
            // 
            btnOuput.ForeColor = Color.FromArgb(0, 102, 104);
            btnOuput.Location = new Point(716, 77);
            btnOuput.Name = "btnOuput";
            btnOuput.Size = new Size(134, 34);
            btnOuput.TabIndex = 13;
            btnOuput.Text = "Xuất EXEL";
            btnOuput.UseVisualStyleBackColor = true;
            // 
            // btbTinhluong
            // 
            btbTinhluong.ForeColor = Color.FromArgb(0, 102, 104);
            btbTinhluong.Location = new Point(716, 19);
            btbTinhluong.Name = "btbTinhluong";
            btbTinhluong.Size = new Size(134, 34);
            btbTinhluong.TabIndex = 12;
            btbTinhluong.Text = "Tính lương";
            btbTinhluong.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            txtID.Location = new Point(196, 21);
            txtID.Name = "txtID";
            txtID.Size = new Size(454, 31);
            txtID.TabIndex = 8;
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(196, 79);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(454, 31);
            txtMonth.TabIndex = 7;
            // 
            // txtBonus
            // 
            txtBonus.Location = new Point(196, 197);
            txtBonus.Name = "txtBonus";
            txtBonus.Size = new Size(454, 31);
            txtBonus.TabIndex = 6;
            // 
            // txtBaseSalary
            // 
            txtBaseSalary.Location = new Point(196, 134);
            txtBaseSalary.Name = "txtBaseSalary";
            txtBaseSalary.Size = new Size(454, 31);
            txtBaseSalary.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(42, 200);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 4;
            label3.Text = "Thưởng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(42, 137);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 3;
            label2.Text = "Lương cơ bản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 82);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 2;
            label1.Text = "Tháng";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(42, 24);
            label13.Name = "label13";
            label13.Size = new Size(118, 25);
            label13.TabIndex = 1;
            label13.Text = "Mã nhân viên";
            // 
            // FormTinhluong
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(994, 609);
            Controls.Add(panel1);
            Controls.Add(tbTinhluong);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(ListSearch);
            Name = "FormTinhluong";
            Text = "FormTinhluong";
            tbTinhluong.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ListSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private TableLayoutPanel tbTinhluong;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label8;
        private Panel panel1;
        private TextBox txtID;
        private TextBox txtMonth;
        private TextBox txtBonus;
        private TextBox txtBaseSalary;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label13;
        private Button btnDelete;
        private Button btnOuput;
        private Button btbTinhluong;
        private Button btnLoad;
        private Button btnBack;
    }
}