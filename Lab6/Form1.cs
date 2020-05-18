using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        float a, b;
        bool sign = true;
        char action;
        string msg_divide_null = "Деление на 0 невозможно";
        bool isAfterEqual = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void equals_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && label1.Text != "")
            {
                b = float.Parse(textBox1.Text);
                label1.Text = "";
                switch (action)
                {
                    case '+':
                        a += b;
                        break;
                    case '-':
                        a -= b;
                        break;
                    case '*':
                        a *= b;
                        break;
                    case '/':
                        if (b != 0)
                        {
                            a /= b;
                        }
                        else
                        {
                            textBox1.Text = msg_divide_null;
                            label1.Text = "";
                        }
                        break;
                }
                if (textBox1.Text != msg_divide_null)
                {
                    textBox1.Text = a.ToString();
                    isAfterEqual = true;
                    Clipboard.SetText(a.ToString());
                    if (a < 0)
                    {
                        sign = false;
                    }
                }
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == msg_divide_null)
            {
                textBox1.Text = "";
            }
            if (label1.Text == "" && textBox1.Text != "")
            {
                a = float.Parse(textBox1.Text);
                textBox1.Text = "";
                label1.Text = a.ToString() + " + ";
                sign = true;
            }
            else if (label1.Text != "" && textBox1.Text == "")
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 2);
                label1.Text += "+ ";
            }
            else if (label1.Text != "" && textBox1.Text != "")
            {
                if (label1.Text.Contains("/ ") && textBox1.Text == "0")
                {
                    label1.Text = "";
                    textBox1.Text = msg_divide_null;
                }
                else
                {
                    equals_Click(sender, e);
                    a = float.Parse(textBox1.Text);
                    textBox1.Text = "";
                    label1.Text = a.ToString() + " + ";
                    sign = true;
                }
            }
            action = '+';
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == msg_divide_null)
            {
                textBox1.Text = "";
            }
            if (textBox1.Text != "" && !textBox1.Text.Contains(','))
            {
                textBox1.Text += ",";
            }
        }
        private void minus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == msg_divide_null)
            {
                textBox1.Text = "";
            }
            if (label1.Text == "" && textBox1.Text != "")
            {
                a = float.Parse(textBox1.Text);
                textBox1.Text = "";
                label1.Text = a.ToString() + " - ";
                sign = true;
            }
            else if (label1.Text != "" && textBox1.Text == "")
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 2);
                label1.Text += "- ";
            }
            else if (label1.Text != "" && textBox1.Text != "")
            {
                if (label1.Text.Contains("/ ") && textBox1.Text == "0")
                {
                    label1.Text = "";
                    textBox1.Text = msg_divide_null;
                }
                else
                {
                    equals_Click(sender, e);
                    a = float.Parse(textBox1.Text);
                    textBox1.Text = "";
                    label1.Text = a.ToString() + " - ";
                    sign = true;
                }
            }
            action = '-';
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == msg_divide_null)
            {
                textBox1.Text = "";
            }
            if (label1.Text == "" && textBox1.Text != "")
            {
                a = float.Parse(textBox1.Text);
                textBox1.Text = "";
                label1.Text = a.ToString() + " * ";
                sign = true;
            }
            else if (label1.Text != "" && textBox1.Text == "")
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 2);
                label1.Text += "* ";
            }
            else if (label1.Text != "" && textBox1.Text != "")
            {
                if (label1.Text.Contains("/ ") && textBox1.Text == "0")
                {
                    label1.Text = "";
                    textBox1.Text = msg_divide_null;
                }
                else
                {
                    equals_Click(sender, e);
                    a = float.Parse(textBox1.Text);
                    textBox1.Text = "";
                    label1.Text = a.ToString() + " * ";
                    sign = true;
                }
            }
            action = '*';
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == msg_divide_null)
            {
                textBox1.Text = "";
            }
            if (label1.Text == "" && textBox1.Text != "")
            {
                a = float.Parse(textBox1.Text);
                textBox1.Text = "";
                label1.Text = a.ToString() + " / ";
                sign = true;
            }
            else if (label1.Text != "" && textBox1.Text == "")
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 2);
                label1.Text += "/ ";
            }
            else if (label1.Text != "" && textBox1.Text != "")
            {
                if (label1.Text.Contains("/ ") && textBox1.Text == "0")
                {
                    label1.Text = "";
                    textBox1.Text = msg_divide_null;
                }
                else
                {
                    equals_Click(sender, e);
                    a = float.Parse(textBox1.Text);
                    textBox1.Text = "";
                    label1.Text = a.ToString() + " / ";
                    sign = true;
                }
            }
            action = '/';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sign_of_number_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == msg_divide_null)
            {
                textBox1.Text = "";
            }
            if (sign == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                sign = false;
            }
            else
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                sign = true;
            }
        }

        private void erase_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == msg_divide_null || isAfterEqual)
            {
                textBox1.Text = "";
            }
            if (textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    digit_null_Click(sender, e);
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    digit_one_Click(sender, e);
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    digit_two_Click(sender, e);
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    digit_three_Click(sender, e);
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    digit_four_Click(sender, e);
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    digit_five_Click(sender, e);
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    digit_six_Click(sender, e);
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    digit_seven_Click(sender, e);
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    digit_eight_Click(sender, e);
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    digit_nine_Click(sender, e);
                    break;
                case Keys.Add:
                    plus_Click(sender, e);
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    minus_Click(sender, e);
                    break;
                case Keys.Multiply:

                    multiply_Click(sender, e);
                    break;
                case Keys.Divide:
                case Keys.OemQuestion:
                    divide_Click(sender, e);
                    break;
                case Keys.Back:
                    erase_Click(sender, e);
                    break;
                case Keys.Enter:
                case Keys.Oemplus:
                    equals_Click(sender, e);
                    break;
                case Keys.Delete:
                case Keys.Escape:
                    CE_Click(sender, e);
                    break;
                case Keys.Decimal:
                case Keys.Oemcomma:
                case Keys.OemPeriod:
                    dot_Click(sender, e);
                    break;
            }
        }
        private void digit_null_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == msg_divide_null)
            {
                textBox1.Text = "";
            }
            if (textBox1.Text != "0" && !isAfterEqual)
            {
                textBox1.Text += 0;
            }
            isAfterEqual = false;
        }

        private void digit_one_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == msg_divide_null)
            {
                textBox1.Text = "";
            }
            if (textBox1.Text != "0" && !isAfterEqual)
            {
                textBox1.Text += 1;
            }
            else
            {
                textBox1.Text = "1";
            }
            isAfterEqual = false;
        }

        private void digit_two_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == msg_divide_null)
            {
                textBox1.Text = "";
            }
            if (textBox1.Text != "0" && !isAfterEqual)
            {
                textBox1.Text += 2;
            }
            else
            {
                textBox1.Text = "2";
            }
            isAfterEqual = false;
        }

        private void digit_three_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == msg_divide_null)
            {
                textBox1.Text = "";
            }
            if (textBox1.Text != "0" && !isAfterEqual)
            {
                textBox1.Text += 3;
            }
            else
            {
                textBox1.Text = "3";
            }
            isAfterEqual = false;
        }

        private void digit_four_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == msg_divide_null)
            {
                textBox1.Text = "";
            }
            if (textBox1.Text != "0" && !isAfterEqual)
            {
                textBox1.Text += 4;
            }
            else
            {
                textBox1.Text = "4";
            }
            isAfterEqual = false;
        }

        private void digit_five_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == msg_divide_null)
            {
                textBox1.Text = "";
            }
            if (textBox1.Text != "0" && !isAfterEqual)
            {
                textBox1.Text += 5;
            }
            else
            {
                textBox1.Text = "5";
            }
            isAfterEqual = false;
        }

        private void digit_six_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == msg_divide_null)
            {
                textBox1.Text = "";
            }
            if (textBox1.Text != "0" && !isAfterEqual)
            {
                textBox1.Text += 6;
            }
            else
            {
                textBox1.Text = "6";
            }
            isAfterEqual = false;
        }
        private void digit_seven__Click(object sender, EventArgs e)
        {
            if (textBox1.Text == msg_divide_null)
            {
                textBox1.Text = "";
            }
            if (textBox1.Text != "0" && !isAfterEqual)
            {
                textBox1.Text += 7;
            }
            else
            {
                textBox1.Text = "7";
            }
            isAfterEqual = false;
        }
        private void digit_seven_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == msg_divide_null)
            {
                textBox1.Text = "";
            }
            if (textBox1.Text != "0" && !isAfterEqual)
            {
                textBox1.Text += 7;
            }
            else
            {
                textBox1.Text = "7";
            }
            isAfterEqual = false;
        }
        private void digit_eight_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == msg_divide_null)
            {
                textBox1.Text = "";
            }
            if (textBox1.Text != "0" && !isAfterEqual)
            {
                textBox1.Text += 8;
            }
            else
            {
                textBox1.Text = "8";
            }
            isAfterEqual = false;
        }
        private void digit_nine_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == msg_divide_null)
            {
                textBox1.Text = "";
            }
            if (textBox1.Text != "0" && !isAfterEqual)
            {
                textBox1.Text += 9;
            }
            else
            {
                textBox1.Text = "9";
            }
            isAfterEqual = false;
        }
    }
}
