using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {
        //button values
        int zero = 0;
        int one = 1;
        int two = 2;
        int three = 3;
        int four = 4;
        int five = 5;
        int six = 6;
        int seven = 7;
        int eight = 8;
        int nine = 9;

        //result and current value variables
        int current_value = 0;
        int result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void compute()
        {
            result = result + current_value;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            current_value = zero;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            result = result + current_value;
            txtInput.Text = result.ToString();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtInput.Text = result.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            current_value = 1;
            txtInput.Text = txtInput.Text + current_value.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            current_value = two;
            txtInput.Text = current_value.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            current_value = three;
            txtInput.Text = current_value.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            current_value = four;
            txtInput.Text = current_value.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            current_value = five;
            txtInput.Text = current_value.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            current_value = six;
            txtInput.Text = current_value.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            current_value = seven;
            txtInput.Text = current_value.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            current_value = eight;
            txtInput.Text = current_value.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            current_value = nine;
            txtInput.Text = current_value.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            result = result - current_value;
            txtInput.Text = result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            result = result * current_value;
            txtInput.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            result = result / current_value;
            txtInput.Text = result.ToString();
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            result = (current_value / result) * 100;
            txtInput.Text = result.ToString();
        }
    }
}
