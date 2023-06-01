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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string y;
            int x;
            int z;

            y= Convert.ToString(t1.Text);
            x=int.Parse(t2.Text);   
            z=int.Parse(t3.Text);   

            if(x == z)
            {
                this.Hide();
                Form19 f = new Form19();
                f.Show();
            }
            else
            {
                MessageBox.Show("Enter same password");
            }
        }

        private void t3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form19 f = new Form19();
            f.Show();
        }
    }
}
