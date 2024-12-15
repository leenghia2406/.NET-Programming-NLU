using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH07_WinformApp
{
    public partial class PTBac2 : Form
    {
        public PTBac2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(numATxt.Text);
                double b = double.Parse(numBTxt.Text);
                double c = double.Parse(numCTxt.Text);

                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    resTxtBox.Text = "Phương trình vô nghiệm";
                }
                else if (delta == 0)
                {
                    double x = -b / (2 *a);
                    resTxtBox.Text = "Phương trình có nghiệm kép x1 = x2 = " + x;
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    resTxtBox.Text = "Phương trình có hai nghiệm phân biệt, x1 = " + x1 + " x2 = " + x2;
                }
            }
            catch
            {
                resTxtBox.Text = "Các hệ số nhập không hợp lệ";
                return;
            }

        }
    }
}
