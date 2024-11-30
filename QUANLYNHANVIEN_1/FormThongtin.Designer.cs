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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPhone = new TextBox();
            txtAdress = new TextBox();
            txtDateofMonth = new TextBox();
            txtSalary = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            panel1 = new Panel();
            btnDangxuat = new Button();
            btnXuatThongTin = new Button();
            btnLichsuchamcong = new Button();
            btnChangepass = new Button();
            btnback = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 102, 104);
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 32);
            label1.TabIndex = 0;
            label1.Text = "Thông tin nhân viên";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 102, 104);
            label2.Location = new Point(40, 74);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 102, 104);
            label3.Location = new Point(40, 133);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 102, 104);
            label4.Location = new Point(40, 203);
            label4.Name = "label4";
            label4.Size = new Size(128, 28);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 102, 104);
            label5.Location = new Point(40, 272);
            label5.Name = "label5";
            label5.Size = new Size(71, 28);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 102, 104);
            label6.Location = new Point(40, 343);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 5;
            label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 102, 104);
            label7.Location = new Point(40, 417);
            label7.Name = "label7";
            label7.Size = new Size(68, 28);
            label7.TabIndex = 6;
            label7.Text = "Lương";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(190, 203);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(450, 31);
            txtPhone.TabIndex = 7;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(190, 272);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(450, 31);
            txtAdress.TabIndex = 8;
            // 
            // txtDateofMonth
            // 
            txtDateofMonth.Location = new Point(190, 343);
            txtDateofMonth.Name = "txtDateofMonth";
            txtDateofMonth.Size = new Size(450, 31);
            txtDateofMonth.TabIndex = 9;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(190, 417);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(450, 31);
            txtSalary.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(190, 133);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(450, 31);
            txtEmail.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(190, 74);
            txtName.Name = "txtName";
            txtName.Size = new Size(450, 31);
            txtName.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 102, 104);
            panel1.Controls.Add(btnback);
            panel1.Controls.Add(btnChangepass);
            panel1.Controls.Add(btnLichsuchamcong);
            panel1.Controls.Add(btnXuatThongTin);
            panel1.Controls.Add(btnDangxuat);
            panel1.Location = new Point(0, 490);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 134);
            panel1.TabIndex = 13;
            // 
            // btnDangxuat
            // 
            btnDangxuat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangxuat.ForeColor = Color.FromArgb(0, 102, 104);
            btnDangxuat.Location = new Point(203, 19);
            btnDangxuat.Name = "btnDangxuat";
            btnDangxuat.Size = new Size(112, 41);
            btnDangxuat.TabIndex = 0;
            btnDangxuat.Text = "Đăng xuất";
            btnDangxuat.UseVisualStyleBackColor = true;
            // 
            // btnXuatThongTin
            // 
            btnXuatThongTin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXuatThongTin.ForeColor = Color.FromArgb(0, 102, 104);
            btnXuatThongTin.Location = new Point(401, 19);
            btnXuatThongTin.Name = "btnXuatThongTin";
            btnXuatThongTin.Size = new Size(157, 41);
            btnXuatThongTin.TabIndex = 1;
            btnXuatThongTin.Text = "Xuất thông tin";
            btnXuatThongTin.UseVisualStyleBackColor = true;
            // 
            // btnLichsuchamcong
            // 
            btnLichsuchamcong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLichsuchamcong.ForeColor = Color.FromArgb(0, 102, 104);
            btnLichsuchamcong.Location = new Point(91, 80);
            btnLichsuchamcong.Name = "btnLichsuchamcong";
            btnLichsuchamcong.Size = new Size(184, 41);
            btnLichsuchamcong.TabIndex = 2;
            btnLichsuchamcong.Text = "Lịch sử chấm công";
            btnLichsuchamcong.UseVisualStyleBackColor = true;
            btnLichsuchamcong.Click += button3_Click;
            // 
            // btnChangepass
            // 
            btnChangepass.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChangepass.ForeColor = Color.FromArgb(0, 102, 104);
            btnChangepass.Location = new Point(340, 80);
            btnChangepass.Name = "btnChangepass";
            btnChangepass.Size = new Size(144, 41);
            btnChangepass.TabIndex = 3;
            btnChangepass.Text = "Đổi mật khẩu";
            btnChangepass.UseVisualStyleBackColor = true;
            // 
            // btnback
            // 
            btnback.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnback.ForeColor = Color.FromArgb(0, 102, 104);
            btnback.Location = new Point(547, 80);
            btnback.Name = "btnback";
            btnback.Size = new Size(106, 41);
            btnback.TabIndex = 4;
            btnback.Text = "Quay lại";
            btnback.UseVisualStyleBackColor = true;
            // 
            // FormNhanvien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(720, 623);
            Controls.Add(panel1);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtSalary);
            Controls.Add(txtDateofMonth);
            Controls.Add(txtAdress);
            Controls.Add(txtPhone);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormNhanvien";
            Text = "FormNhanvien";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPhone;
        private TextBox txtAdress;
        private TextBox txtDateofMonth;
        private TextBox txtSalary;
        private TextBox txtEmail;
        private TextBox txtName;
        private Panel panel1;
        private Button btnChangepass;
        private Button btnLichsuchamcong;
        private Button btnXuatThongTin;
        private Button btnDangxuat;
        private Button btnback;
    }
}