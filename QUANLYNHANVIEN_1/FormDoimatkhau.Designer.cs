namespace QUANLYNHANVIEN_1
{
    partial class FormDoimatkhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoimatkhau));
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPassOld = new TextBox();
            txtPassNew = new TextBox();
            txtConfirmPass = new TextBox();
            txtConfirmCode = new TextBox();
            txtCheckpass = new CheckBox();
            btnGetcode = new Button();
            btnBack = new Button();
            btnChangePass = new Button();
            txtOldPass = new TextBox();
            txtNewPass = new TextBox();
            txtPassCode = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 102, 104);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(2, 1);
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
            label2.Location = new Point(327, 63);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(228, 32);
            label2.TabIndex = 2;
            label2.Text = "- ĐỔI MẬT KHẨU -";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 102, 104);
            label3.Location = new Point(29, 158);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(151, 23);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu hiện tại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 102, 104);
            label4.Location = new Point(29, 203);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(123, 23);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 102, 104);
            label5.Location = new Point(29, 254);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(163, 23);
            label5.TabIndex = 4;
            label5.Text = "Xác nhận mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 102, 104);
            label6.Location = new Point(29, 304);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 23);
            label6.TabIndex = 5;
            label6.Text = "Mã xác nhận";
            // 
            // txtPassOld
            // 
            txtPassOld.Location = new Point(0, 0);
            txtPassOld.Name = "txtPassOld";
            txtPassOld.Size = new Size(100, 27);
            txtPassOld.TabIndex = 20;
            // 
            // txtPassNew
            // 
            txtPassNew.Location = new Point(0, 0);
            txtPassNew.Name = "txtPassNew";
            txtPassNew.Size = new Size(100, 27);
            txtPassNew.TabIndex = 19;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(196, 256);
            txtConfirmPass.Margin = new Padding(2);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(320, 27);
            txtConfirmPass.TabIndex = 8;
            txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // txtConfirmCode
            // 
            txtConfirmCode.Location = new Point(0, 0);
            txtConfirmCode.Name = "txtConfirmCode";
            txtConfirmCode.Size = new Size(100, 27);
            txtConfirmCode.TabIndex = 18;
            // 
            // txtCheckpass
            // 
            txtCheckpass.AutoSize = true;
            txtCheckpass.Location = new Point(551, 256);
            txtCheckpass.Margin = new Padding(2);
            txtCheckpass.Name = "txtCheckpass";
            txtCheckpass.Size = new Size(87, 24);
            txtCheckpass.TabIndex = 13;
            txtCheckpass.Text = "Hiển thị ";
            txtCheckpass.UseVisualStyleBackColor = true;
            txtCheckpass.CheckedChanged += txtCheckpass_CheckedChanged;
            // 
            // btnGetcode
            // 
            btnGetcode.BackColor = Color.FromArgb(0, 102, 104);
            btnGetcode.ForeColor = Color.White;
            btnGetcode.Location = new Point(548, 296);
            btnGetcode.Margin = new Padding(2);
            btnGetcode.Name = "btnGetcode";
            btnGetcode.Size = new Size(90, 31);
            btnGetcode.TabIndex = 15;
            btnGetcode.Text = "Nhận mã";
            btnGetcode.UseVisualStyleBackColor = false;
            btnGetcode.Click += btnGetcode_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(0, 102, 104);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(104, 368);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(110, 42);
            btnBack.TabIndex = 16;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnChangePass
            // 
            btnChangePass.BackColor = Color.FromArgb(0, 102, 104);
            btnChangePass.ForeColor = Color.White;
            btnChangePass.Location = new Point(430, 368);
            btnChangePass.Margin = new Padding(2);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(110, 42);
            btnChangePass.TabIndex = 17;
            btnChangePass.Text = "Đổi mật khẩu";
            btnChangePass.UseVisualStyleBackColor = false;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(196, 154);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(320, 27);
            txtOldPass.TabIndex = 21;
            txtOldPass.UseSystemPasswordChar = true;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(196, 203);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(320, 27);
            txtNewPass.TabIndex = 22;
            txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtPassCode
            // 
            txtPassCode.Location = new Point(196, 300);
            txtPassCode.Name = "txtPassCode";
            txtPassCode.Size = new Size(320, 27);
            txtPassCode.TabIndex = 23;
            // 
            // FormDoimatkhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(654, 441);
            Controls.Add(txtPassCode);
            Controls.Add(txtNewPass);
            Controls.Add(txtOldPass);
            Controls.Add(btnChangePass);
            Controls.Add(btnBack);
            Controls.Add(btnGetcode);
            Controls.Add(txtCheckpass);
            Controls.Add(txtConfirmCode);
            Controls.Add(txtConfirmPass);
            Controls.Add(txtPassNew);
            Controls.Add(txtPassOld);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Margin = new Padding(2);
            Name = "FormDoimatkhau";
            Text = "FormDoimatkhau";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPassOld;
        private TextBox txtPassNew;
        private TextBox txtConfirmPass;
        private TextBox txtConfirmCode;
        private CheckBox txtCheckpass;
        private Button btnGetcode;
        private Button btnBack;
        private Button btnChangePass;
        private TextBox txtOldPass;
        private TextBox txtNewPass;
        private TextBox txtPassCode;
    }
}