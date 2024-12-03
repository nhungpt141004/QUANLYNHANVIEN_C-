namespace QUANLYNHANVIEN_1
{
    partial class FormMain1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain1));
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnEmployee = new Button();
            btnChamcong = new Button();
            btnTinhluong = new Button();
            btnThongtin = new Button();
            btnDangxuat = new Button();
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
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(370, 64);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 2;
            label2.Text = "- MENU -";
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
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(0, 102, 104);
            btnEmployee.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployee.ForeColor = Color.White;
            btnEmployee.Location = new Point(99, 170);
            btnEmployee.Margin = new Padding(2);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(139, 68);
            btnEmployee.TabIndex = 3;
            btnEmployee.Text = "NHÂN VIÊN";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnChamcong
            // 
            btnChamcong.BackColor = Color.FromArgb(0, 102, 104);
            btnChamcong.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChamcong.ForeColor = Color.White;
            btnChamcong.Location = new Point(398, 170);
            btnChamcong.Margin = new Padding(2);
            btnChamcong.Name = "btnChamcong";
            btnChamcong.Size = new Size(139, 68);
            btnChamcong.TabIndex = 4;
            btnChamcong.Text = "CHẤM CÔNG";
            btnChamcong.UseVisualStyleBackColor = false;
            btnChamcong.Click += btnChamcong_Click;
            // 
            // btnTinhluong
            // 
            btnTinhluong.BackColor = Color.FromArgb(0, 102, 104);
            btnTinhluong.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTinhluong.ForeColor = Color.White;
            btnTinhluong.Location = new Point(99, 286);
            btnTinhluong.Margin = new Padding(2);
            btnTinhluong.Name = "btnTinhluong";
            btnTinhluong.Size = new Size(139, 68);
            btnTinhluong.TabIndex = 5;
            btnTinhluong.Text = "TÍNH LƯƠNG";
            btnTinhluong.UseVisualStyleBackColor = false;
            btnTinhluong.Click += btnTinhluong_Click;
            // 
            // btnThongtin
            // 
            btnThongtin.BackColor = Color.FromArgb(0, 102, 104);
            btnThongtin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThongtin.ForeColor = Color.White;
            btnThongtin.Location = new Point(398, 286);
            btnThongtin.Margin = new Padding(2);
            btnThongtin.Name = "btnThongtin";
            btnThongtin.Size = new Size(139, 68);
            btnThongtin.TabIndex = 6;
            btnThongtin.Text = "THÔNG TIN";
            btnThongtin.UseVisualStyleBackColor = false;
            btnThongtin.Click += btnThongtin_Click;
            // 
            // btnDangxuat
            // 
            btnDangxuat.BackColor = Color.FromArgb(0, 102, 104);
            btnDangxuat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangxuat.ForeColor = Color.White;
            btnDangxuat.Location = new Point(262, 380);
            btnDangxuat.Margin = new Padding(2);
            btnDangxuat.Name = "btnDangxuat";
            btnDangxuat.Size = new Size(106, 39);
            btnDangxuat.TabIndex = 14;
            btnDangxuat.Text = "Đăng xuất";
            btnDangxuat.UseVisualStyleBackColor = false;
            btnDangxuat.Click += btnDangxuat_Click;
            // 
            // FormMain1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(654, 429);
            Controls.Add(btnDangxuat);
            Controls.Add(btnThongtin);
            Controls.Add(btnTinhluong);
            Controls.Add(btnChamcong);
            Controls.Add(btnEmployee);
            Controls.Add(panel2);
            Margin = new Padding(2);
            Name = "FormMain1";
            Text = "ForMain1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnEmployee;
        private Button btnChamcong;
        private Button btnTinhluong;
        private Button btnThongtin;
        private Button btnDangxuat;
    }
}