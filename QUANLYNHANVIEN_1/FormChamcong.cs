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
    public partial class FormChamcong : Form
    {
        public FormChamcong()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMain FormMain = new FormMain();
            FormMain.Show();
            this.Hide();
        }
    }
}
