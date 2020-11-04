using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Project
{
    public partial class Form1 : Form
    {
        float firstNum;
        float secondNum;
        String operation;
        float ans;
       
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button23_Click_1(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = "";

            if (b.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + b.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + b.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            firstNum = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Text=operation;
            textBox1.Focus();
            
        }

        private void button25_Click(object sender, EventArgs e)
        {

            switch (operation)
            {
                case "+":
                    ans = firstNum+ float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case "-":
                    ans = firstNum - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case "/":
                    ans = firstNum / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case "*":
                    ans = firstNum * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case "%":
                    ans = firstNum * float.Parse(textBox1.Text)/ 100;
                    textBox1.Text = ans.ToString();
                    break;

            }
        }
    }
}
