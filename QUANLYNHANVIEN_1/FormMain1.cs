using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHANVIEN_1
{
    public partial class FormMain1 : Form
    {
        public FormMain1()
        {
            InitializeComponent();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            FormNhanvien formNhanvien = new FormNhanvien();
            formNhanvien.ShowDialog();
            this.Hide();
        }

        private void btnChamcong_Click(object sender, EventArgs e)
        {
            FormChamcong formChamcong = new FormChamcong();
            formChamcong.ShowDialog();
            this.Hide();
        }

        private void btnThongtin_Click(object sender, EventArgs e)
        {
            About formAbout = new About();
            formAbout.ShowDialog();
            this.Hide();
        }

        private void btnTinhluong_Click(object sender, EventArgs e)
        {
            FormTinhluong formtinhluong= new FormTinhluong();
            formtinhluong.ShowDialog();
            this.Hide();
        }

    }
}
