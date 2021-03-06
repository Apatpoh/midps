﻿using System;
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
            this.KeyDown += Calculator_KeyDown;
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                text_box.Text += "0";
            }

            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                text_box.Text += "1";
            }

            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                text_box.Text += "2";
            }

            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                text_box.Text += "3";
            }

            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                text_box.Text += "4";
            }

            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                text_box.Text += "5";
            }

            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                text_box.Text += "6";
            }

            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                text_box.Text += "7";
            }

            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                text_box.Text += "8";
            }

            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                text_box.Text += "9";
            }

            if (e.KeyCode == Keys.Multiply)
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

            if (e.KeyCode == Keys.Divide)
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

            if (e.KeyCode == Keys.Add)
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

            if (e.KeyCode == Keys.Subtract)
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

            if (e.KeyCode == Keys.Decimal)
            {
                text_box2.Text += "*";
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (text_box.Text == string.Empty)
                {
                    text_box.Text = "0";
                }
                n2 = text_box.Text;
                text_box.Text = "";
                a = Convert.ToDouble(n1);
                b = Convert.ToDouble(n2);
                text_box2.Text = "=";
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
                    case 6:
                        c = Math.Pow(a, 1 / b);
                        text_box.Text = Convert.ToString(c);
                        break;
                }
            }

            if (e.KeyCode == Keys.Back && text_box.Text != string.Empty)
            {
                text_box.Text = text_box.Text.Remove(text_box.Text.Length - 1);
                if (text_box2.Text != string.Empty)
                    text_box2.Text = string.Empty;
            }

            if (e.KeyCode == Keys.Delete)
            {
                text_box.Text = "";
                text_box2.Text = "";
            }
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
            double temp;
            temp = Convert.ToDouble(text_box.Text);
            temp = temp * (-1);
            text_box.Text = Convert.ToString(temp);

        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            if (text_box.Text == string.Empty)
            {
                text_box.Text = "0";
                n1 = text_box.Text;
            }
            if (!text_box.Text.Contains("."))
                {
                    text_box.Text += ".";
                }
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

        private void button_delete_Click(object sender, EventArgs e)
        {
            text_box.Text = text_box.Text.Remove(text_box.Text.Length - 1);
            if (text_box2.Text != string.Empty)
                text_box2.Text = string.Empty;
        }

        private void button_rad_Click(object sender, EventArgs e)
        {
            if (text_box.Text == string.Empty)
            {
                text_box.Text = "0";
                n1 = text_box.Text;
                text_box.Text = "";
                text_box2.Text = "√";
                sign = 6;
            }
            else
            {
                n1 = text_box.Text;
                text_box.Text = "";
                text_box2.Text = "√";
                sign = 6;
            }
        }

        private void button_egal_Click(object sender, EventArgs e)
        {
            if (text_box.Text == string.Empty)
            {
                text_box.Text = "0";
            }
            n2 = text_box.Text;
            text_box.Text = "";
            a = Convert.ToDouble(n1);
            b = Convert.ToDouble(n2);
            text_box2.Text = "=";
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
                case 6:
                    c = Math.Pow(a, 1 / b);
                    text_box.Text = Convert.ToString(c);
                    break;
            }
        }
    }
}
