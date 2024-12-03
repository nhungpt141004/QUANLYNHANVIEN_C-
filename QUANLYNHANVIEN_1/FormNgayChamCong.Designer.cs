namespace QUANLYNHANVIEN_1
{
    partial class FormNgayChamCong
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
            panel1 = new Panel();
            sfCalendar1 = new Syncfusion.WinForms.Input.SfCalendar();
            Thêm = new Button();
            btnHienThiNgayNghi = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(sfCalendar1);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 430);
            panel1.TabIndex = 1;
            // 
            // sfCalendar1
            // 
            sfCalendar1.Location = new Point(3, 0);
            sfCalendar1.Name = "sfCalendar1";
            sfCalendar1.Size = new Size(742, 427);
            sfCalendar1.TabIndex = 3;
            sfCalendar1.Text = "sfCalendar1";
            sfCalendar1.DrawCell += SfCalendar1_DrawCell;
            sfCalendar1.Click += sfCalendar1_Click;
            // 
            // Thêm
            // 
            Thêm.BackColor = Color.FromArgb(0, 104, 104);
            Thêm.ForeColor = Color.White;
            Thêm.Location = new Point(585, 469);
            Thêm.Name = "Thêm";
            Thêm.Size = new Size(94, 42);
            Thêm.TabIndex = 2;
            Thêm.Text = "Thêm";
            Thêm.UseVisualStyleBackColor = false;
            Thêm.Click += Thêm_Click;
            // 
            // btnHienThiNgayNghi
            // 
            btnHienThiNgayNghi.BackColor = Color.FromArgb(0, 104, 104);
            btnHienThiNgayNghi.ForeColor = Color.White;
            btnHienThiNgayNghi.Location = new Point(29, 469);
            btnHienThiNgayNghi.Name = "btnHienThiNgayNghi";
            btnHienThiNgayNghi.Size = new Size(139, 42);
            btnHienThiNgayNghi.TabIndex = 1;
            btnHienThiNgayNghi.Text = "Hiển thị ngày nghỉ";
            btnHienThiNgayNghi.UseVisualStyleBackColor = false;
            btnHienThiNgayNghi.Click += btnHienThiNgayNghi_Click;
            // 
            // FormNgayChamCong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 523);
            Controls.Add(panel1);
            Controls.Add(Thêm);
            Controls.Add(btnHienThiNgayNghi);
            Name = "FormNgayChamCong";
            Text = "FormNgayChamCong";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button Thêm;
        private Button btnHienThiNgayNghi;
        private Syncfusion.WinForms.Input.SfCalendar sfCalendar1;
    }
}