using System;
using System.Numerics;
using System.Windows.Forms;

namespace NetworkingCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region a
        private void button1_Click(object sender, EventArgs e)
        {
            ulong n;
            bool check = ulong.TryParse(textBox1.Text, out n);
            if (check == true)
            {
                if (n < 3)
                {
                    MessageAlert("លោកអ្នកបានបញ្ចូលស្វ័យគុណ​ n តូចជាង​ 3!​សូមបញ្ចូលស្វ័យគុណ n​ ម្ដងទៀត។", textBox1);
                }
                else
                {
                    outPutOne.Text = SumPowerofTwo(3, n).ToString();
                    BigInteger Number = new BigInteger(SumPowerofTwo(3, n));
                    textBox3.Text = Number.ToString();
                }
                    
            }


            else if (check == false)
            {
                if (textBox1.Text.Trim() == "")
                {
                    MessageAlert("អ្នកមិនបានបញ្ចូលស្វ័យគុណ​​ n ឡើយ​។​ សូមបញ្ចូលម្ដងទៀត៕", textBox1);
                }
                else
                {
                    MessageAlert("អ្នកបញ្ចូលលេខមិនត្រឹមត្រូវឡើយ​។​ សូមបញ្ចូលម្ដងទៀត៕", textBox1);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ulong n;
            bool check = ulong.TryParse(textBox2.Text, out n);
            if (check == true)
            {
                if (n <= 0)
                {
                    MessageAlert("លោកអ្នកបានបញ្ចូលចំនួនតួ n តូចជាង​ 1!​សូមបញ្ចូលស្វ័យគុណ n​ ម្ដងទៀត។", textBox2);
                }
                else
                {
                    
                    double sum = 0;
                    for (double i = 0; i < n; i++)
                    {
                        sum = sum + Math.Pow(2, i) * Math.Pow(3, n - 1 - i);
                    }
                    nuMeraTor.Text = sum.ToString();
                    deNoMinaTor.Size = new System.Drawing.Size(nuMeraTor.Size.Width, nuMeraTor.Size.Height);
                    deNoMinaTor.Text = Math.Pow(3, n - 1).ToString();
                    outPutTwo.Text = " " + (sum / Math.Pow(3, n - 1)).ToString();

                }

            }


            else if (check == false)
            {
                if (textBox1.Text.Trim() == "")
                    MessageAlert("អ្នកមិនបានបញ្ចូលចំនួនតួ​​ n ឡើយ​។​ សូមបញ្ចូលម្ដងទៀត៕", textBox2);
                else
                    MessageAlert("អ្នកបញ្ចូលលេខមិនត្រឹមត្រូវឡើយ​។​ សូមបញ្ចូលម្ដងទៀត៕", textBox2);
            }
        }

        private double SumPowerofTwo(double start, decimal lenght)
        {
            double SumofPowerofTwo = 0;
            do
            {
                SumofPowerofTwo = SumofPowerofTwo + Math.Pow(2, start);
                ++start;
            } while ((decimal)start <= lenght);
            return SumofPowerofTwo;
        }
        private void MessageAlert(string Message, TextBox textbox)
        {
            MessageBox.Show(Message);
            textbox.Clear();
            textbox.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            button2_Click(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ulong n;
            bool check = ulong.TryParse(textBox1.Text, out n);
            if (check == true)
            {
                if (n < 3)
                {
                    MessageAlert("លោកអ្នកបានបញ្ចូលស្វ័យគុណ​ n តូចជាង​ 3!​សូមបញ្ចូលស្វ័យគុណ n​ ម្ដងទៀត។", textBox1);
                }
                else
                {
                    outPutOne.Text = SumPowerofTwo(3, n).ToString();
                    BigInteger Number = new BigInteger(SumPowerofTwo(3, n));
                    textBox3.Text = Number.ToString();
                }

            }


            else if (check == false)
            {
                if (textBox1.Text.Trim() == "")
                {
                    MessageAlert("អ្នកមិនបានបញ្ចូលស្វ័យគុណ​​ n ឡើយ​។​ សូមបញ្ចូលម្ដងទៀត៕", textBox1);
                }
                else
                {
                    MessageAlert("អ្នកបញ្ចូលលេខមិនត្រឹមត្រូវឡើយ​។​ សូមបញ្ចូលម្ដងទៀត៕", textBox1);
                }
            }
        }
    }

    #endregion
}
