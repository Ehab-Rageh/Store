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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 formhome= new Form4();
            formhome.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Close();
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();  
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 f = new Form3();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 f = new Form4();  
            f.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
            Form7 frm7 = new Form7();
            frm7.Show();

        }
    }
}
