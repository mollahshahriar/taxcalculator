using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
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

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = (((float.Parse(textBox2.Text)) * (float.Parse(textBox3.Text)) / 100)).ToString();
            double FirstNumber = Convert.ToDouble(textBox1.Text) ;
            double SecondNumber= Convert.ToDouble(textBox2.Text);
            double Answer = SecondNumber - FirstNumber ;
            textBox4.Text = Convert.ToString(Answer);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
