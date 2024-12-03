namespace QUANLYNHANVIEN_1
{
    partial class FormNhanvien
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
            panel7 = new Panel();
            tbEmployee = new DataGridView();
            employee_id = new DataGridViewTextBoxColumn();
            full_name = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            phone_number = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            date_of_birth = new DataGridViewTextBoxColumn();
            role_id = new DataGridViewTextBoxColumn();
            panel8 = new Panel();
            dtpDateofBirth = new DateTimePicker();
            btnBack = new Button();
            btnLoad = new Button();
            btnOutput = new Button();
            btnInput = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            ListSearch = new ComboBox();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbEmployee).BeginInit();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(ListSearch);
            panel7.Controls.Add(tbEmployee);
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(btnSearch);
            panel7.Controls.Add(txtSearch);
            panel7.Location = new Point(0, 2);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(942, 538);
            panel7.TabIndex = 1;
            // 
            // tbEmployee
            // 
            tbEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbEmployee.Columns.AddRange(new DataGridViewColumn[] { employee_id, full_name, email, phone_number, address, date_of_birth, role_id });
            tbEmployee.Location = new Point(10, 58);
            tbEmployee.Name = "tbEmployee";
            tbEmployee.RowHeadersWidth = 51;
            tbEmployee.Size = new Size(919, 237);
            tbEmployee.TabIndex = 5;
            tbEmployee.CellContentClick += tbEmployee_CellContentClick;
            // 
            // employee_id
            // 
            employee_id.DataPropertyName = "employee_id";
            employee_id.HeaderText = "ID";
            employee_id.MinimumWidth = 6;
            employee_id.Name = "employee_id";
            employee_id.Width = 50;
            // 
            // full_name
            // 
            full_name.DataPropertyName = "full_name";
            full_name.HeaderText = "Họ tên";
            full_name.MinimumWidth = 6;
            full_name.Name = "full_name";
            full_name.Width = 150;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.Width = 150;
            // 
            // phone_number
            // 
            phone_number.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            phone_number.DataPropertyName = "phone_number";
            phone_number.HeaderText = "Số điện thoại";
            phone_number.MinimumWidth = 6;
            phone_number.Name = "phone_number";
            phone_number.Width = 126;
            // 
            // address
            // 
            address.DataPropertyName = "address";
            address.HeaderText = "Địa chỉ";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.Width = 140;
            // 
            // date_of_birth
            // 
            date_of_birth.DataPropertyName = "date_of_birth";
            date_of_birth.HeaderText = "Ngày sinh";
            date_of_birth.MinimumWidth = 6;
            date_of_birth.Name = "date_of_birth";
            date_of_birth.Width = 125;
            // 
            // role_id
            // 
            role_id.DataPropertyName = "role_id";
            role_id.HeaderText = "Chức vụ";
            role_id.MinimumWidth = 6;
            role_id.Name = "role_id";
            role_id.Width = 125;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 102, 104);
            panel8.Controls.Add(dtpDateofBirth);
            panel8.Controls.Add(btnBack);
            panel8.Controls.Add(btnLoad);
            panel8.Controls.Add(btnOutput);
            panel8.Controls.Add(btnInput);
            panel8.Controls.Add(btnDelete);
            panel8.Controls.Add(btnUpdate);
            panel8.Controls.Add(btnAdd);
            panel8.Controls.Add(txtAddress);
            panel8.Controls.Add(txtPhone);
            panel8.Controls.Add(txtEmail);
            panel8.Controls.Add(txtName);
            panel8.Controls.Add(txtID);
            panel8.Controls.Add(label18);
            panel8.Controls.Add(label17);
            panel8.Controls.Add(label16);
            panel8.Controls.Add(label15);
            panel8.Controls.Add(label14);
            panel8.Controls.Add(label13);
            panel8.Location = new Point(2, 318);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(927, 220);
            panel8.TabIndex = 4;
            // 
            // dtpDateofBirth
            // 
            dtpDateofBirth.Location = new Point(712, 90);
            dtpDateofBirth.Name = "dtpDateofBirth";
            dtpDateofBirth.Size = new Size(202, 27);
            dtpDateofBirth.TabIndex = 21;
            dtpDateofBirth.Value = new DateTime(2024, 12, 18, 0, 0, 0, 0);
            // 
            // btnBack
            // 
            btnBack.ForeColor = Color.FromArgb(0, 102, 104);
            btnBack.Location = new Point(824, 172);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 27);
            btnBack.TabIndex = 20;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnLoad
            // 
            btnLoad.ForeColor = Color.FromArgb(0, 102, 104);
            btnLoad.Location = new Point(703, 172);
            btnLoad.Margin = new Padding(2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(90, 27);
            btnLoad.TabIndex = 19;
            btnLoad.Text = "Làm mới";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnOutput
            // 
            btnOutput.ForeColor = Color.FromArgb(0, 102, 104);
            btnOutput.Location = new Point(577, 172);
            btnOutput.Margin = new Padding(2);
            btnOutput.Name = "btnOutput";
            btnOutput.Size = new Size(90, 27);
            btnOutput.TabIndex = 18;
            btnOutput.Text = "Xuất EXEL";
            btnOutput.UseVisualStyleBackColor = true;
            btnOutput.Click += btnOutput_Click;
            // 
            // btnInput
            // 
            btnInput.ForeColor = Color.FromArgb(0, 102, 104);
            btnInput.Location = new Point(437, 172);
            btnInput.Margin = new Padding(2);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(90, 27);
            btnInput.TabIndex = 17;
            btnInput.Text = "Nhập EXEL";
            btnInput.UseVisualStyleBackColor = true;
            btnInput.Click += btnInput_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.FromArgb(0, 102, 104);
            btnDelete.Location = new Point(296, 172);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 27);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = Color.FromArgb(0, 102, 104);
            btnUpdate.Location = new Point(157, 172);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 27);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.FromArgb(0, 102, 104);
            btnAdd.Location = new Point(19, 172);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 27);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(712, 51);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(202, 27);
            txtAddress.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(712, 14);
            txtPhone.Margin = new Padding(2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(202, 27);
            txtPhone.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(142, 90);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(142, 52);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(214, 27);
            txtName.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.Location = new Point(142, 17);
            txtID.Margin = new Padding(2);
            txtID.Name = "txtID";
            txtID.Size = new Size(214, 27);
            txtID.TabIndex = 7;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.White;
            label18.Location = new Point(593, 90);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(74, 20);
            label18.TabIndex = 5;
            label18.Text = "Ngày sinh";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.White;
            label17.Location = new Point(593, 51);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(55, 20);
            label17.TabIndex = 4;
            label17.Text = "Địa chỉ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.White;
            label16.Location = new Point(593, 17);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(97, 20);
            label16.TabIndex = 3;
            label16.Text = "Số điện thoại";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.White;
            label15.Location = new Point(36, 90);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(46, 20);
            label15.TabIndex = 2;
            label15.Text = "Email";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.White;
            label14.Location = new Point(36, 52);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(73, 20);
            label14.TabIndex = 1;
            label14.Text = "Họ và tên";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(36, 17);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(97, 20);
            label13.TabIndex = 0;
            label13.Text = "Mã nhân viên";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 102, 104);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(826, 12);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(298, 19);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(392, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // ListSearch
            // 
            ListSearch.BackColor = Color.FromArgb(0, 102, 104);
            ListSearch.ForeColor = Color.White;
            ListSearch.FormattingEnabled = true;
            ListSearch.Items.AddRange(new object[] { "ID", "Họ Tên", "Email", "Số điện thoại", "Địa chỉ", "Ngày sinh" });
            ListSearch.Location = new Point(11, 18);
            ListSearch.Margin = new Padding(2);
            ListSearch.Name = "ListSearch";
            ListSearch.Size = new Size(168, 28);
            ListSearch.TabIndex = 6;
            // 
            // FormNhanvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 538);
            Controls.Add(panel7);
            Margin = new Padding(2);
            Name = "FormNhanvien";
            Text = "FormMain";
            Load += FormNhanvien_Load;
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbEmployee).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel lbDangxuat;
        private Label label5;
        private Panel lbThongtin;
        private Label label4;
        private Panel lbTinhluong;
        private Label label3;
        private Panel lbChamcong;
        private Label label2;
        private Panel panel7;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel8;
        private Label label13;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtID;
        private Button btnLoad;
        private Button btnOutput;
        private Button btnInput;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnBack;
        private DataGridView tbEmployee;
        private DataGridViewTextBoxColumn Column1;
        private DateTimePicker dtpDateofBirth;
        private DataGridViewTextBoxColumn employee_id;
        private DataGridViewTextBoxColumn full_name;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn phone_number;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn date_of_birth;
        private DataGridViewTextBoxColumn role_id;
        private ComboBox ListSearch;
    }
}