using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Calc
{
    public partial class Form1 : Form
    {
        public float a, b, c, res;
        public string znak;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button17_Click(object sender, EventArgs e)
        {  
            if (textBox1.Text == "")
            {
                textBox1.Text += "0,";
            }

            else if (!textBox1.Text.EndsWith(","))
            {
                textBox1.Text += ",";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e) // "/"
        {
            if (textBox1.Text == "" || Convert.ToSingle(textBox1.Text) == 0)
            {
                a = 0;
                label1.Text = "";
                label1.Text += "0 /";
                znak = "/";
                textBox1.Clear();
            }

            else
            {
                a = Convert.ToSingle(textBox1.Text);
                label1.Text = "";
                label1.Text += $"{a} /";
                znak = "/";
                textBox1.Clear();
            }
        }

        private void button13_Click(object sender, EventArgs e) // "*"
        {
            if (textBox1.Text == "" || Convert.ToSingle(textBox1.Text) == 0)
            {
                a = 0;
                label1.Text = "";
                label1.Text += "0 *";
                znak = "*";
                textBox1.Clear();
            }

            else
            {
                a = Convert.ToSingle(textBox1.Text);
                label1.Text = "";
                label1.Text += $"{a} *";
                znak = "*";
                textBox1.Clear();
            }
        }

        private void button14_Click(object sender, EventArgs e) // "-"
        {
            if (textBox1.Text == "" || Convert.ToSingle(textBox1.Text) == 0)
            {
                a = 0;
                label1.Text = "";
                label1.Text += "0 -";
                znak = "-";
                textBox1.Clear();
            }

            else
            {
                a = Convert.ToSingle(textBox1.Text);
                label1.Text = "";
                label1.Text += $"{a} -";
                znak = "-";
                textBox1.Clear();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.PI).ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || Convert.ToSingle(textBox1.Text) == 0)
            {
                textBox1.Text = "Нельзя делить на 0!";
            }
            else
            {
                textBox1.Text = (1 / Convert.ToSingle(textBox1.Text)).ToString();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || Convert.ToSingle(textBox1.Text) == 0)
            {
                textBox1.Text = Math.Pow(0, 2).ToString();
            }
            else
            {
                c = Convert.ToSingle(textBox1.Text);
                textBox1.Text = Math.Pow(c, 2).ToString();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || Convert.ToSingle(textBox1.Text) == 0)
            {
                textBox1.Text = Math.Sqrt(0).ToString();
            }
            else
            {
                c = Convert.ToSingle(textBox1.Text);
                textBox1.Text = Math.Sqrt(c).ToString();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || Convert.ToSingle(textBox1.Text) == 0)
            {
                a = 0;
                label1.Text = "0 ^";
                znak = "^";
                textBox1.Clear();
            }
            else
            {
                a = Convert.ToSingle(textBox1.Text);
                label1.Text = $"{a} ^";
                znak = "^";
                textBox1.Clear();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || Convert.ToSingle(textBox1.Text) == 0)
            {
                textBox1.Text = Math.Pow(10, 0).ToString();
            }
            else
            {
                c = Convert.ToSingle(textBox1.Text);
                textBox1.Text = Math.Pow(10, c).ToString();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || Convert.ToSingle(textBox1.Text) == 0)
            {
                textBox1.Text = Math.Abs(0).ToString();
            }
            else
            {
                c = Convert.ToSingle(textBox1.Text);
                textBox1.Text = Math.Abs(c).ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e) // "+"
        {
            if (textBox1.Text == "" || Convert.ToSingle(textBox1.Text) == 0)
            {
                a = 0;
                label1.Text = "0 +";
                znak = "+";
                textBox1.Clear();
            }

            else
            {
                a = Convert.ToSingle(textBox1.Text);
                label1.Text = "";
                label1.Text += $"{a} +";
                znak = "+";
                textBox1.Clear();
            }
        }

        private void button16_Click(object sender, EventArgs e) // "="
        {
            if (textBox1.Text == "" || Convert.ToSingle(textBox1.Text) == 0)
            {
                b = 0;
            }
            else
            {
                b = Convert.ToSingle(textBox1.Text);
            }
            if (znak.EndsWith("/"))
            {
                label1.Text = "";
                res = a / b;
                textBox1.Text = res.ToString();
            }

            else if (znak.EndsWith("*"))
            {
                label1.Text = "";
                res = a * b;
                textBox1.Text = res.ToString();
            }

            else if (znak.EndsWith("-"))
            {
                label1.Text = "";
                res = a - b;
                textBox1.Text = res.ToString();
            }

            else if (znak.EndsWith("+"))
            {
                label1.Text = "";
                res = a + b;
                textBox1.Text = res.ToString();
            }

            else if (znak.EndsWith("^"))
            {
                label1.Text = "";
                res = Convert.ToSingle(Math.Pow(Convert.ToDouble(a), Convert.ToDouble(b)));
                textBox1.Text = res.ToString();
            }
        }
    }
}
