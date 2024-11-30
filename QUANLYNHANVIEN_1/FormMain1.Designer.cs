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
            panel2.Name = "panel2";
            panel2.Size = new Size(815, 158);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(462, 80);
            label2.Name = "label2";
            label2.Size = new Size(139, 38);
            label2.TabIndex = 2;
            label2.Text = "- MENU -";
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
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(0, 102, 104);
            btnEmployee.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployee.ForeColor = Color.White;
            btnEmployee.Location = new Point(124, 212);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(174, 85);
            btnEmployee.TabIndex = 3;
            btnEmployee.Text = "NHÂN VIÊN";
            btnEmployee.UseVisualStyleBackColor = false;
            // 
            // btnChamcong
            // 
            btnChamcong.BackColor = Color.FromArgb(0, 102, 104);
            btnChamcong.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChamcong.ForeColor = Color.White;
            btnChamcong.Location = new Point(498, 212);
            btnChamcong.Name = "btnChamcong";
            btnChamcong.Size = new Size(174, 85);
            btnChamcong.TabIndex = 4;
            btnChamcong.Text = "CHẤM CÔNG";
            btnChamcong.UseVisualStyleBackColor = false;
            // 
            // btnTinhluong
            // 
            btnTinhluong.BackColor = Color.FromArgb(0, 102, 104);
            btnTinhluong.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTinhluong.ForeColor = Color.White;
            btnTinhluong.Location = new Point(124, 358);
            btnTinhluong.Name = "btnTinhluong";
            btnTinhluong.Size = new Size(174, 85);
            btnTinhluong.TabIndex = 5;
            btnTinhluong.Text = "TÍNH LƯƠNG";
            btnTinhluong.UseVisualStyleBackColor = false;
            // 
            // btnThongtin
            // 
            btnThongtin.BackColor = Color.FromArgb(0, 102, 104);
            btnThongtin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThongtin.ForeColor = Color.White;
            btnThongtin.Location = new Point(498, 358);
            btnThongtin.Name = "btnThongtin";
            btnThongtin.Size = new Size(174, 85);
            btnThongtin.TabIndex = 6;
            btnThongtin.Text = "THÔNG TIN";
            btnThongtin.UseVisualStyleBackColor = false;
            // 
            // btnDangxuat
            // 
            btnDangxuat.BackColor = Color.FromArgb(0, 102, 104);
            btnDangxuat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangxuat.ForeColor = Color.White;
            btnDangxuat.Location = new Point(328, 475);
            btnDangxuat.Name = "btnDangxuat";
            btnDangxuat.Size = new Size(132, 49);
            btnDangxuat.TabIndex = 14;
            btnDangxuat.Text = "Đăng xuất";
            btnDangxuat.UseVisualStyleBackColor = false;
            // 
            // FormMain1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(818, 536);
            Controls.Add(btnDangxuat);
            Controls.Add(btnThongtin);
            Controls.Add(btnTinhluong);
            Controls.Add(btnChamcong);
            Controls.Add(btnEmployee);
            Controls.Add(panel2);
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