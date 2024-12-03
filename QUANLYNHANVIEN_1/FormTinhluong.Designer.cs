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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(29, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(933, 225);
            dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "STT";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
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
            Column3.Width = 80;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ngày nghỉ";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 130;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column5.HeaderText = "Lương cơ bản";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 158;
            // 
            // Column6
            // 
            Column6.HeaderText = "Thưởng";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "Tổng lương";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 150;
            // 
            // FormTinhluong
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
            Name = "FormTinhluong";
            Text = "FormTinhluong";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ListSearch;
        private TextBox txtSearch;
        private Button btnSearch;
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}