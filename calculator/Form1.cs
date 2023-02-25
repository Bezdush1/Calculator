using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public string lastActivity;
        public string dialedNumber;
        public bool flagSecondNumber;
        public Form1()
        {
            flagSecondNumber = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            //button ,
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //button =
            double firstNumber, secondNumber, result;
            result = 0;
            firstNumber = Convert.ToDouble(dialedNumber);
            secondNumber = Convert.ToDouble(textBox1.Text);
            if (lastActivity == "+")
            {
                result = firstNumber + secondNumber;
            }
            if (lastActivity == "-")
            {
                result = firstNumber - secondNumber;
            }
            if (lastActivity == "X")
            {
                result = firstNumber * secondNumber;
            }
            if (lastActivity == "/")
            {
                result = firstNumber / secondNumber;
            }
            if (lastActivity == "%")
            {
                result = firstNumber * secondNumber / 100;
            }
            lastActivity = "=";
            flagSecondNumber = true;
            textBox1.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //button √ 
            double number, result;
            number = Convert.ToDouble(textBox1.Text);
            result = Math.Sqrt(number);
            textBox1.Text = result.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //button x²
            double number, result;
            number = Convert.ToDouble(textBox1.Text);
            result = Math.Pow(number, 2);
            textBox1.Text = result.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //button 1/X
            double number, result;
            number = Convert.ToDouble(textBox1.Text);
            result = 1 / number;
            textBox1.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //button <-
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button C
            textBox1.Text = "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //button +/-
            double number, result;
            number = Convert.ToDouble(textBox1.Text);
            result = -number;
            textBox1.Text = result.ToString();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (flagSecondNumber)
            {
                flagSecondNumber = false;
                textBox1.Text = "0";
            }
            Button button = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = button.Text;
            else
                textBox1.Text = textBox1.Text + button.Text;
        }

        private void Form1_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            lastActivity = button.Text;
            dialedNumber = textBox1.Text;
            flagSecondNumber = true;
        }
    }
}
