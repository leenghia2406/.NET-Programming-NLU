using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH07_Formater
{
    public partial class Formater : Form
    {
        public Formater()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            txtNhapTen.Focus();
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            txtLapTrinh.Text = txtNhapTen.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                txtLapTrinh.ForeColor = Color.Red;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                txtLapTrinh.ForeColor = Color.Green;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                txtLapTrinh.ForeColor= Color.Blue;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                txtLapTrinh.ForeColor= Color.Black;
            }

        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle style = FontStyle.Regular; 

            if (chkBold.Checked)
                style |= FontStyle.Bold; 

            if (chkItalic.Checked)
                style |= FontStyle.Italic; 
            if (chkUnderline.Checked)
                style |= FontStyle.Underline;

            txtLapTrinh.Font = new Font(txtLapTrinh.Font, style);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle style = FontStyle.Regular;

            if (chkBold.Checked)
                style |= FontStyle.Bold;

            if (chkItalic.Checked)
                style |= FontStyle.Italic;
            if (chkUnderline.Checked)
                style |= FontStyle.Underline;

            txtLapTrinh.Font = new Font(txtLapTrinh.Font, style);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle style = FontStyle.Regular;

            if (chkBold.Checked)
                style |= FontStyle.Bold;

            if (chkItalic.Checked)
                style |= FontStyle.Italic;
            if (chkUnderline.Checked)
                style |= FontStyle.Underline;

            txtLapTrinh.Font = new Font(txtLapTrinh.Font, style);
        }
    }
}
