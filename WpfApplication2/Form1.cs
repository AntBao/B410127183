using System;
using System.Windows.Forms;

namespace WpfApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imageList1.Images.Count > 0)
            {
                pictureBox1.Image = imageList1.Images[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imageList1.Images.Count > 1)
            {
                pictureBox1.Image = imageList1.Images[1];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (imageList1.Images.Count > 2)
            {
                pictureBox1.Image = imageList1.Images[2];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (imageList1.Images.Count > 3)
            {
                pictureBox1.Image = imageList1.Images[3];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (imageList1.Images.Count > 4)
            {
                pictureBox1.Image = imageList1.Images[4]; ;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            imageList1.Images.Clear();
        }
    }
}
