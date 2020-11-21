using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace простой_калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(textBox3.Text);
            b = double.Parse(textBox2.Text);
            switch(comboBox1.Text)
            {
                case "+":
                    textBox1.Text = Convert.ToString(a + b);
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(a - b);
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(a * b);
                    break;
                case "/":
                    { if (b == 0)
                            textBox1.Text = "На ноль делить нельзя";
                        else
                            textBox1.Text = Convert.ToString(a / b);
                     break;
                     }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";


        }
    }
}
