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
        public Calculator()
        {
            InitializeComponent();
        }

        string tex, k;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            txt_1.Text = " ";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (txt_1.Text == "0" && txt_1.Text != null)
            {
                txt_1.Text = "1";
            }
            else
            {
                txt_1.Text = txt_1.Text + "1";
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (txt_1.Text == "0" && txt_1.Text != null)
            {
                txt_1.Text = "2";
            }
            else
            {
                txt_1.Text = txt_1.Text + "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (txt_1.Text == "0" && txt_1.Text != null)
            {
                txt_1.Text = "3";
            }
            else
            {
                txt_1.Text = txt_1.Text + "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (txt_1.Text == "0" && txt_1.Text != null)
            {
                txt_1.Text = "4";
            }
            else
            {
                txt_1.Text = txt_1.Text + "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {

            if (txt_1.Text == "0" && txt_1.Text != null)
            {
                txt_1.Text = "5";
            }
            else
            {
                txt_1.Text = txt_1.Text + "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (txt_1.Text == "0" && txt_1.Text != null)
            {
                txt_1.Text = "6";
            }
            else
            {
                txt_1.Text = txt_1.Text + "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (txt_1.Text == "0" && txt_1.Text != null)
            {
                txt_1.Text = "7";
            }
            else
            {
                txt_1.Text = txt_1.Text + "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (txt_1.Text == "0" && txt_1.Text != null)
            {
                txt_1.Text = "8";
            }
            else
            {
                txt_1.Text = txt_1.Text + "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (txt_1.Text == "0" && txt_1.Text != null)
            {
                txt_1.Text = "9";
            }
            else
            {
                txt_1.Text = txt_1.Text + "9";
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + "0";
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + ",";
        }
        private void btn_plus_Click(object sender, EventArgs e)
        {
            tex = txt_1.Text;
            txt_1.Text = "";
            k = "+";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            tex = txt_1.Text;
            txt_1.Text = "";
            k = "-";
        }

        private void btn_multiple_Click(object sender, EventArgs e)
        {
            tex = txt_1.Text;
            txt_1.Text = "";
            k = "*";
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            tex = txt_1.Text;
            txt_1.Text = "";
            k = "/";
        }

        private void btn_pow_Click(object sender, EventArgs e)
        {
            tex = txt_1.Text;
            txt_1.Text = "";
            k = "^";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            switch (k)
            {
                case "+":
                    txt_1.Text = Convert.ToString(Convert.ToDouble(tex) + Convert.ToDouble(txt_1.Text));
                    break;
                case "-":
                    txt_1.Text = Convert.ToString(Convert.ToDouble(tex) - Convert.ToDouble(txt_1.Text));
                    break;
                case "*":
                    txt_1.Text = Convert.ToString(Convert.ToDouble(tex) * Convert.ToDouble(txt_1.Text));
                    break;
                case "/":
                    txt_1.Text = Convert.ToString(Convert.ToDouble(tex) / Convert.ToDouble(txt_1.Text));
                    break;
                case "^":
                    txt_1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(tex), Convert.ToDouble(txt_1.Text)));
                    break;
                default:
                    break;
            }
        }
    }
}
