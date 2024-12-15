using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH07_HoTen
{
    public partial class BaiTapHoTen : Form
    {
        public BaiTapHoTen()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BaiTapHoTen_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHo_Click(object sender, EventArgs e)
        {
            String ho = txtHo.Text;
            lblHoTen.Text = ho;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            String ten = txtTen.Text;
            lblHoTen.Text = ten;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            String ho = txtHo.Text;
            String ten = txtTen.Text;
            lblHoTen.Text = ho + " " + ten;
        }

        private void lblHoTen_DoubleClick(object sender, EventArgs e)
        {
            lblHoTen.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
