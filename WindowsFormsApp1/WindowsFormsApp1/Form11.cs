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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form10 f = new Form10();
            f.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
            Form10 f = new Form10();
            f.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
            Form12 f = new Form12();
            f.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
            Form12 f = new Form12();
            f.Show();
        }
    }
}
