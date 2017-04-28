using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operator_sign = "";
        bool operator_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((Result.Text == "0")||(operator_pressed))
                Result.Clear();
            Button button = (Button)sender;
            Result.Text = Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operator_sign = button.Text;
            value = double.Parse(Result.Text);
            operator_pressed = true;
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch(operator_sign)
            {
                case "+":Result.Text=(value+double.Parse(Result.Text)).ToString();
                    break;
                case "-":
                    Result.Text = (value - double.Parse(Result.Text)).ToString();
                    break;
                case "*":
                    Result.Text = (value * double.Parse(Result.Text)).ToString();
                    break;
                case "/":
                    Result.Text =(value / double.Parse(Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            operator_pressed = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Result.Text = Result.Text.Remove(0,1);
            if (Result.Text == "")
            {
                Result.Text = "0";
            }  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void keypress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)Keys.D9 || e.KeyChar < (char)Keys.D0) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            //Edit: Alternative
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        
    }
    }
}
