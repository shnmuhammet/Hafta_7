using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                MessageBox.Show("Evli");
            }
            else
                MessageBox.Show("Bekar");
        }


        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Font = new Font("Times New Roman",hScrollBar1.Value);
            this.Text = "Yazı tipinin büyüklüğü =" + hScrollBar1.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollBar1.Minimum = 8;
            hScrollBar1.Maximum = 120;
            hScrollBar1.SmallChange = 3;
            hScrollBar1.LargeChange = 9;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.Text = vScrollBar1.Value.ToString() + "-" + vScrollBar2.Value.ToString() + "-" + vScrollBar3.Value.ToString();
            int r = vScrollBar1.Value;
            int g = vScrollBar2.Value;
            int b = vScrollBar3.Value;
            this.BackColor = Color.FromArgb(r, g, b);
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            this.Text = vScrollBar1.Value.ToString() + "-" + vScrollBar2.Value.ToString() + "-" + vScrollBar3.Value.ToString();
            int r = vScrollBar1.Value;
            int g = vScrollBar2.Value;
            int b = vScrollBar3.Value;
            this.BackColor = Color.FromArgb(r, g, b);
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            this.Text = vScrollBar1.Value.ToString() + "-" + vScrollBar2.Value.ToString() + "-" + vScrollBar3.Value.ToString();
            int r = vScrollBar1.Value;
            int g = vScrollBar2.Value;
            int b = vScrollBar3.Value;
            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
