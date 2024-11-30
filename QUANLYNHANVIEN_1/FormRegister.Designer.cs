namespace QUANLYNHANVIEN_1
{
    partial class FormRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            panel1 = new Panel();
            btnRegister = new Button();
            btnLogin = new Button();
            txtCheckpass = new CheckBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            txtRePassword = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtCheckpass);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtRePassword);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 659);
            panel1.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(0, 102, 104);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(553, 584);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(137, 52);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 102, 104);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(123, 584);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(137, 52);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtCheckpass
            // 
            txtCheckpass.AutoSize = true;
            txtCheckpass.Location = new Point(677, 444);
            txtCheckpass.Name = "txtCheckpass";
            txtCheckpass.Size = new Size(120, 32);
            txtCheckpass.TabIndex = 12;
            txtCheckpass.Text = "Hiển thị ";
            txtCheckpass.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(238, 186);
            txtName.Name = "txtName";
            txtName.Size = new Size(410, 34);
            txtName.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(238, 245);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(410, 34);
            txtEmail.TabIndex = 10;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(238, 309);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(410, 34);
            txtPhoneNumber.TabIndex = 9;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(238, 373);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(410, 34);
            txtUser.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(238, 441);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(410, 34);
            txtPassword.TabIndex = 7;
            // 
            // txtRePassword
            // 
            txtRePassword.Location = new Point(238, 505);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.Size = new Size(410, 34);
            txtRePassword.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 102, 104);
            label8.Location = new Point(24, 508);
            label8.Name = "label8";
            label8.Size = new Size(187, 28);
            label8.TabIndex = 5;
            label8.Text = "Nhập lại mật khẩu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 102, 104);
            label7.Location = new Point(24, 444);
            label7.Name = "label7";
            label7.Size = new Size(102, 28);
            label7.TabIndex = 4;
            label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 102, 104);
            label6.Location = new Point(24, 376);
            label6.Name = "label6";
            label6.Size = new Size(109, 28);
            label6.TabIndex = 3;
            label6.Text = "Tài khoản ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 102, 104);
            label5.Location = new Point(24, 312);
            label5.Name = "label5";
            label5.Size = new Size(138, 28);
            label5.TabIndex = 2;
            label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 102, 104);
            label4.Location = new Point(24, 248);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 1;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 102, 104);
            label3.Location = new Point(24, 189);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 0;
            label3.Text = "Họ và tên";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 102, 104);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(815, 158);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(445, 79);
            label2.Name = "label2";
            label2.Size = new Size(181, 38);
            label2.TabIndex = 2;
            label2.Text = "- ĐĂNG KÝ -";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(371, 20);
            label1.Name = "label1";
            label1.Size = new Size(346, 45);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(21, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 116);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 664);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormRegister";
            Text = "FormRegister";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private CheckBox txtCheckpass;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtUser;
        private TextBox txtPassword;
        private TextBox txtRePassword;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnRegister;
    }
}
