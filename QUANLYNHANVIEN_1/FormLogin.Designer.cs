namespace QUANLYNHANVIEN_1
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            btnRegister = new Button();
            btnLogin = new Button();
            txtCheckpass = new CheckBox();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            label7 = new Label();
            label6 = new Label();
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
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-4, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 461);
            panel1.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(0, 102, 104);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(123, 363);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(137, 52);
            btnRegister.TabIndex = 15;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 102, 104);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(578, 363);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(137, 52);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtCheckpass
            // 
            txtCheckpass.AutoSize = true;
            txtCheckpass.Location = new Point(678, 273);
            txtCheckpass.Name = "txtCheckpass";
            txtCheckpass.Size = new Size(104, 29);
            txtCheckpass.TabIndex = 13;
            txtCheckpass.Text = "Hiển thị ";
            txtCheckpass.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(218, 271);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(410, 31);
            txtPassword.TabIndex = 10;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(218, 195);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(410, 31);
            txtUser.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 102, 104);
            label7.Location = new Point(53, 271);
            label7.Name = "label7";
            label7.Size = new Size(102, 28);
            label7.TabIndex = 5;
            label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 102, 104);
            label6.Location = new Point(53, 195);
            label6.Name = "label6";
            label6.Size = new Size(109, 28);
            label6.TabIndex = 4;
            label6.Text = "Tài khoản ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 102, 104);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(7, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(815, 158);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(428, 79);
            label2.Name = "label2";
            label2.Size = new Size(226, 38);
            label2.TabIndex = 2;
            label2.Text = "- ĐĂNG NHẬP -";
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
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 458);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "FormLogin";
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
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
        private TextBox txtUser;
        private TextBox txtPassword;
        private CheckBox txtCheckpass;
        private Button btnLogin;
        private Button btnRegister;
    }
}