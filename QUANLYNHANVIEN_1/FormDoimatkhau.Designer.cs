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
            panel2.Name = "panel2";
            panel2.Size = new Size(815, 158);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(409, 79);
            label2.Name = "label2";
            label2.Size = new Size(264, 38);
            label2.TabIndex = 2;
            label2.Text = "- ĐỔI MẬT KHẨU -";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 102, 104);
            label3.Location = new Point(36, 198);
            label3.Name = "label3";
            label3.Size = new Size(180, 28);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu hiện tại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 102, 104);
            label4.Location = new Point(36, 254);
            label4.Name = "label4";
            label4.Size = new Size(145, 28);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 102, 104);
            label5.Location = new Point(36, 318);
            label5.Name = "label5";
            label5.Size = new Size(194, 28);
            label5.TabIndex = 4;
            label5.Text = "Xác nhận mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 102, 104);
            label6.Location = new Point(36, 380);
            label6.Name = "label6";
            label6.Size = new Size(133, 28);
            label6.TabIndex = 5;
            label6.Text = "Mã xác nhận";
            // 
            // txtPassOld
            // 
            txtPassOld.Location = new Point(250, 198);
            txtPassOld.Name = "txtPassOld";
            txtPassOld.Size = new Size(399, 31);
            txtPassOld.TabIndex = 6;
            txtPassOld.TextChanged += textBox1_TextChanged;
            // 
            // txtPassNew
            // 
            txtPassNew.Location = new Point(250, 254);
            txtPassNew.Name = "txtPassNew";
            txtPassNew.Size = new Size(399, 31);
            txtPassNew.TabIndex = 7;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(250, 318);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(399, 31);
            txtConfirmPass.TabIndex = 8;
            // 
            // txtConfirmCode
            // 
            txtConfirmCode.Location = new Point(250, 380);
            txtConfirmCode.Name = "txtConfirmCode";
            txtConfirmCode.Size = new Size(399, 31);
            txtConfirmCode.TabIndex = 9;
            txtConfirmCode.TextChanged += textBox4_TextChanged;
            // 
            // txtCheckpass
            // 
            txtCheckpass.AutoSize = true;
            txtCheckpass.Location = new Point(689, 320);
            txtCheckpass.Name = "txtCheckpass";
            txtCheckpass.Size = new Size(104, 29);
            txtCheckpass.TabIndex = 13;
            txtCheckpass.Text = "Hiển thị ";
            txtCheckpass.UseVisualStyleBackColor = true;
            txtCheckpass.CheckedChanged += txtCheckpass_CheckedChanged;
            // 
            // btnGetcode
            // 
            btnGetcode.BackColor = Color.FromArgb(0, 102, 104);
            btnGetcode.ForeColor = Color.White;
            btnGetcode.Location = new Point(680, 376);
            btnGetcode.Name = "btnGetcode";
            btnGetcode.Size = new Size(113, 39);
            btnGetcode.TabIndex = 15;
            btnGetcode.Text = "Nhận mã";
            btnGetcode.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(0, 102, 104);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(130, 460);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(137, 52);
            btnBack.TabIndex = 16;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnChangePass
            // 
            btnChangePass.BackColor = Color.FromArgb(0, 102, 104);
            btnChangePass.ForeColor = Color.White;
            btnChangePass.Location = new Point(538, 460);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(137, 52);
            btnChangePass.TabIndex = 17;
            btnChangePass.Text = "Đổi mật khẩu";
            btnChangePass.UseVisualStyleBackColor = false;
            // 
            // FormDoimatkhau
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(818, 551);
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
    }
}