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
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "9";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "0";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            function = 'D';
        }

        private void clear_Click(object sender, EventArgs e)
        {
            function = 'c';
        }

        private void dot_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += ".";
        }

        private void sum_Click(object sender, EventArgs e)
        {
            function = '+';
        }

        private void minus_Click(object sender, EventArgs e)
        {
            function = '-';
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            function = '*';
        }

        private void divide_Click(object sender, EventArgs e)
        {
            function = '/';
        }

        private void equals_Click(object sender, EventArgs e)
        {
            function = '=';
        }
    }
}
