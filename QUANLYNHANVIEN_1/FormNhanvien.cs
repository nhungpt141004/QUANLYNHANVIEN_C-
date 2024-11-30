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
    public partial class FormNhanvien : Form
    {
        public FormNhanvien()
        {
            InitializeComponent();
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
        }

        private void btnChamcong_Click(object sender, EventArgs e)
        {
            FormChamcong formChamcong = new FormChamcong();
            formChamcong.Show();
            this.Hide();
        }

        private void btnTinhluong_Click(object sender, EventArgs e)
        {
            FormTinhluong FormTinhluong = new FormTinhluong();
            FormTinhluong.Show();
            this.Hide();
        }

        private void btnThongtin_Click(object sender, EventArgs e)
        {
            FormThongtin FormThongtin = new FormThongtin();
            FormThongtin.Show();
            this.Hide();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
