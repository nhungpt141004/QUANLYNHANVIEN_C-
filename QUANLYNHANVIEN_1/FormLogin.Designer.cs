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
            jbtDangKy = new Button();
            btnDNhap = new Button();
            jcbAnHienMatKhau = new CheckBox();
            jtfMatKhau = new TextBox();
            jtfTaiKhoan = new TextBox();
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
            panel1.Controls.Add(jbtDangKy);
            panel1.Controls.Add(btnDNhap);
            panel1.Controls.Add(jcbAnHienMatKhau);
            panel1.Controls.Add(jtfMatKhau);
            panel1.Controls.Add(jtfTaiKhoan);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-3, 1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 369);
            panel1.TabIndex = 0;
            // 
            // jbtDangKy
            // 
            jbtDangKy.BackColor = Color.FromArgb(0, 102, 104);
            jbtDangKy.ForeColor = Color.White;
            jbtDangKy.Location = new Point(98, 290);
            jbtDangKy.Margin = new Padding(2);
            jbtDangKy.Name = "jbtDangKy";
            jbtDangKy.Size = new Size(110, 42);
            jbtDangKy.TabIndex = 15;
            jbtDangKy.Text = "Đăng ký";
            jbtDangKy.UseVisualStyleBackColor = false;
            jbtDangKy.Click += btnRegister_Click;
            // 
            // btnDNhap
            // 
            btnDNhap.BackColor = Color.FromArgb(0, 102, 104);
            btnDNhap.ForeColor = Color.White;
            btnDNhap.Location = new Point(462, 290);
            btnDNhap.Margin = new Padding(2);
            btnDNhap.Name = "btnDNhap";
            btnDNhap.Size = new Size(110, 42);
            btnDNhap.TabIndex = 14;
            btnDNhap.Text = "Đăng nhập";
            btnDNhap.UseVisualStyleBackColor = false;
            btnDNhap.Click += btnLogin_Click;
            // 
            // jcbAnHienMatKhau
            // 
            jcbAnHienMatKhau.AutoSize = true;
            jcbAnHienMatKhau.Location = new Point(542, 218);
            jcbAnHienMatKhau.Margin = new Padding(2);
            jcbAnHienMatKhau.Name = "jcbAnHienMatKhau";
            jcbAnHienMatKhau.Size = new Size(87, 24);
            jcbAnHienMatKhau.TabIndex = 13;
            jcbAnHienMatKhau.Text = "Hiển thị ";
            jcbAnHienMatKhau.UseVisualStyleBackColor = true;
            jcbAnHienMatKhau.CheckedChanged += jcbAnHienMatKhau_CheckedChanged;
            // 
            // jtfMatKhau
            // 
            jtfMatKhau.Location = new Point(174, 217);
            jtfMatKhau.Margin = new Padding(2);
            jtfMatKhau.Name = "jtfMatKhau";
            jtfMatKhau.Size = new Size(329, 27);
            jtfMatKhau.TabIndex = 10;
            jtfMatKhau.UseSystemPasswordChar = true;
            // 
            // jtfTaiKhoan
            // 
            jtfTaiKhoan.Location = new Point(174, 156);
            jtfTaiKhoan.Margin = new Padding(2);
            jtfTaiKhoan.Name = "jtfTaiKhoan";
            jtfTaiKhoan.Size = new Size(329, 27);
            jtfTaiKhoan.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 102, 104);
            label7.Location = new Point(42, 217);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 23);
            label7.TabIndex = 5;
            label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 102, 104);
            label6.Location = new Point(42, 156);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(92, 23);
            label6.TabIndex = 4;
            label6.Text = "Tài khoản ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 102, 104);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(6, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(652, 126);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(342, 63);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(195, 32);
            label2.TabIndex = 2;
            label2.Text = "- ĐĂNG NHẬP -";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(297, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(291, 37);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(17, 16);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 93);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 366);
            Controls.Add(panel1);
            Margin = new Padding(2);
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
        private TextBox jtfTaiKhoan;
        private CheckBox jcbAnHienMatKhau;
        private Button btnDNhap;
        private Button jbtDangKy;
        private TextBox jtfMatKhau;
    }
}