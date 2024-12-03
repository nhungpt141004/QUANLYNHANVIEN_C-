namespace QUANLYNHANVIEN_1
{
    partial class FormThongtin
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            txtDateOfBirth = new TextBox();
            txtSalary = new TextBox();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            panel1 = new Panel();
            btnChangepass = new Button();
            btnXuatThongTin = new Button();
            btnDangxuat = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 102, 104);
            label2.Location = new Point(32, 59);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 102, 104);
            label3.Location = new Point(32, 106);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 102, 104);
            label4.Location = new Point(32, 162);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 102, 104);
            label5.Location = new Point(32, 218);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 102, 104);
            label6.Location = new Point(32, 274);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 23);
            label6.TabIndex = 5;
            label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 102, 104);
            label7.Location = new Point(32, 334);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(58, 23);
            label7.TabIndex = 6;
            label7.Text = "Lương";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(152, 162);
            txtPhoneNumber.Margin = new Padding(2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(361, 27);
            txtPhoneNumber.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(152, 218);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(361, 27);
            txtAddress.TabIndex = 8;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(152, 274);
            txtDateOfBirth.Margin = new Padding(2);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.ReadOnly = true;
            txtDateOfBirth.Size = new Size(361, 27);
            txtDateOfBirth.TabIndex = 9;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(152, 334);
            txtSalary.Margin = new Padding(2);
            txtSalary.Name = "txtSalary";
            txtSalary.ReadOnly = true;
            txtSalary.Size = new Size(361, 27);
            txtSalary.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(152, 106);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(361, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(152, 59);
            txtFullName.Margin = new Padding(2);
            txtFullName.Name = "txtFullName";
            txtFullName.ReadOnly = true;
            txtFullName.Size = new Size(361, 27);
            txtFullName.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 102, 104);
            panel1.Controls.Add(btnChangepass);
            panel1.Controls.Add(btnXuatThongTin);
            panel1.Controls.Add(btnDangxuat);
            panel1.Location = new Point(0, 392);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 107);
            panel1.TabIndex = 13;
            // 
            // btnChangepass
            // 
            btnChangepass.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChangepass.ForeColor = Color.FromArgb(0, 102, 104);
            btnChangepass.Location = new Point(32, 38);
            btnChangepass.Margin = new Padding(2);
            btnChangepass.Name = "btnChangepass";
            btnChangepass.Size = new Size(141, 33);
            btnChangepass.TabIndex = 3;
            btnChangepass.Text = "Đổi mật khẩu";
            btnChangepass.UseVisualStyleBackColor = true;
            btnChangepass.Click += btnChangepass_Click;
            // 
            // btnXuatThongTin
            // 
            btnXuatThongTin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXuatThongTin.ForeColor = Color.FromArgb(0, 102, 104);
            btnXuatThongTin.Location = new Point(213, 38);
            btnXuatThongTin.Margin = new Padding(2);
            btnXuatThongTin.Name = "btnXuatThongTin";
            btnXuatThongTin.Size = new Size(144, 33);
            btnXuatThongTin.TabIndex = 1;
            btnXuatThongTin.Text = "Xuất thông tin";
            btnXuatThongTin.UseVisualStyleBackColor = true;
            btnXuatThongTin.Click += btnXuatThongTin_Click;
            // 
            // btnDangxuat
            // 
            btnDangxuat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangxuat.ForeColor = Color.FromArgb(0, 102, 104);
            btnDangxuat.Location = new Point(399, 38);
            btnDangxuat.Margin = new Padding(2);
            btnDangxuat.Name = "btnDangxuat";
            btnDangxuat.Size = new Size(126, 33);
            btnDangxuat.TabIndex = 0;
            btnDangxuat.Text = "Đăng xuất";
            btnDangxuat.UseVisualStyleBackColor = true;
            btnDangxuat.Click += btnDangxuat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 102, 104);
            label1.Location = new Point(213, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 31);
            label1.TabIndex = 14;
            label1.Text = "Thông tin nhân viên";
            // 
            // FormThongtin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(576, 498);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(txtFullName);
            Controls.Add(txtEmail);
            Controls.Add(txtSalary);
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(2);
            Name = "FormThongtin";
            Text = "FormNhanvien";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private TextBox txtDateOfBirth;
        private TextBox txtSalary;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private Panel panel1;
        private Button btnChangepass;
        private Button btnXuatThongTin;
        private Button btnDangxuat;
        private Label label1;
    }
}