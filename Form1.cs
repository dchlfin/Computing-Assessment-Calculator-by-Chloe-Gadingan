using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_8.Computing_SA1.Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "+";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label1.Text = "-";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label1.Text = "×";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                label1.Text = "÷";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
                label1.Text = "%";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(richTextBox1.Text);
            int b = int.Parse(richTextBox2.Text);
            int c; 
            if (radioButton1.Checked)
            {
                c = a + b;
                label2.Text = "The sum of " + a.ToString() + " and " + b.ToString() + " is " + c.ToString() + "!";
                label3.Text = c.ToString();
            }
            if (radioButton2.Checked)
            {
                c = a - b;
                label2.Text = "The difference between " + a.ToString() + " and " + b.ToString() + " is " + c.ToString() + "!";
                label4.Text = c.ToString();
            }
            if  (radioButton3.Checked)
            {
                c = a * b;
                label2.Text = "The product of " + a.ToString() + " and " + b.ToString() + " is " + c.ToString() + "!";
                label5.Text = c.ToString();
            }
            if (radioButton4.Checked)
            {
                c = a / b; 
                label2.Text = "The quotient of " + a.ToString() + " and " + b.ToString() + " is " + c.ToString() + "!";
                label6.Text = c.ToString();
            }
            if (radioButton5.Checked)
            {
                c = a % b;
                label2.Text = "The remainder of " + a.ToString() + " and " + b.ToString() + " is " + c.ToString() + "!";
                label7.Text = c.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
        }
    }
}
