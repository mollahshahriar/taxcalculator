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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (((float.Parse(textBox1.Text)) * (float.Parse(textBox2.Text)) / 100)).ToString();
            double FirstNumber = Convert.ToDouble(textBox3.Text);
            double SecondNumber = Convert.ToDouble(textBox4.Text);
            double Answer = SecondNumber * FirstNumber;
            textBox5.Text = Convert.ToString(Answer);

           
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
