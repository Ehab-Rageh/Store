using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vodafon Cash num :01015754604 \n send screen on watsapp when payment");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Etsalat Cash num :01125472698 \n send screen on watsapp when payment");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            p1.Visible = true;
           
            p3.Visible = true;
            l7.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            p1.Visible = false;
            
            p3.Visible = false;
            l7.Visible = false;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("60 LE");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("20 LE");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void r5_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("70 LE");
        }

        private void r6_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("55 LE");
        }

        private void r7_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("40 LE");
        }

        private void r9_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("100 LE");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
