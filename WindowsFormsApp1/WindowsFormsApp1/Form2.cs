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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void btnlaptop_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 l= new Form4();
            l.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            watches f1 =new watches();
            f1.Show();  
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
            Form8 f = new Form8();
            f.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
            Form8 f = new Form8();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form13 pho = new Form13();
            pho.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            Form17 f =new  Form17();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form19 F = new Form19();
            F.Show();
        }
    }
}
