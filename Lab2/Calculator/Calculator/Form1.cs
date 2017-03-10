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
    public partial class Calculator : Form
    {
        double a, b, c;
        string n1;
        string n2;
        int sign;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            text_box.Text += "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            text_box.Text += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            text_box.Text += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            text_box.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            text_box.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            text_box.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            text_box.Text += "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            text_box.Text += "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            text_box.Text += "9";
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            text_box.Text += "0";
        }

        private void button_ch_sg_Click(object sender, EventArgs e)
        {
            
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
                text_box.Text += ".";
        }

        private void button_imp_Click(object sender, EventArgs e)
        {
            if (text_box.Text == string.Empty)
            {
                text_box.Text = "0";
                n1 = text_box.Text;
                text_box.Text = "";
                text_box2.Text = "/";
                sign = 4;
            }
            else
            {
                n1 = text_box.Text;
                text_box.Text = "";
                text_box2.Text = "/";
                sign = 4;
            }
        }

        private void button_inm_Click(object sender, EventArgs e)
        {
            if (text_box.Text == string.Empty)
            {
                text_box.Text = "0";
                n1 = text_box.Text;
                text_box.Text = "";
                text_box2.Text = "x";
                sign = 3;
            }
            else
            {
                n1 = text_box.Text;
                text_box.Text = "";
                text_box2.Text = "x";
                sign = 3;
            }
        }

        private void button_min_Click(object sender, EventArgs e)
        {
            if (text_box.Text == string.Empty)
            {
                text_box.Text = "0";
                n1 = text_box.Text;
                text_box.Text = "";
                text_box2.Text = "-";
                sign = 2;
            }
            else
            {
                n1 = text_box.Text;
                text_box.Text = "";
                text_box2.Text = "-";
                sign = 2;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (text_box.Text == string.Empty)
            {
                text_box.Text = "0";
                n1 = text_box.Text;
                text_box.Text = "";
                text_box2.Text = "+";
                sign = 1;
            }
            else
            {
                n1 = text_box.Text;
                text_box.Text = "";
                text_box2.Text = "+";
                sign = 1;
            }
        }

        private void button_pw_Click(object sender, EventArgs e)
        {
            if (text_box.Text == string.Empty)
            {
                text_box.Text = "0";
                n1 = text_box.Text;
                text_box.Text = "";
                text_box2.Text = "^";
                sign = 5;
            }
            else
            {
                n1 = text_box.Text;
                text_box.Text = "";
                text_box2.Text = "^";
                sign = 5;
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            text_box.Text = "";
            text_box2.Text = "";
        }

        private void button_rad_Click(object sender, EventArgs e)
        {
            text_box.Text += "√";
        }

        private void button_egal_Click(object sender, EventArgs e)
        {
            n2 = text_box.Text;
            text_box.Text = "";
            a = Convert.ToDouble(n1);
            b = Convert.ToDouble(n2);
            switch (sign)
            {
                case 1:
                    c = a + b;
                    text_box.Text = Convert.ToString(c);
                    break;
                case 2:
                    c = a - b;
                    text_box.Text = Convert.ToString(c);
                    break;
                case 3:
                    c = a * b;
                    text_box.Text = Convert.ToString(c);
                    break;
                case 4:
                    c = a / b;
                    text_box.Text = Convert.ToString(c);
                    break;
                case 5:
                    int i = 1;
                    c = a;
                    while (i < b)
                    {
                        c = c * a;
                        i++;
                    }
                    text_box.Text = Convert.ToString(c);
                    break;
            }
        }
    }
}
