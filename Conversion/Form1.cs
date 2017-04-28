using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class Form1 : Form
    {
        #region listBoxItem
        string[] listBoxLenghtItem = { "Km", "Hm", "Dkm", "M", "Dm", "Cm", "Mm", "Foot", "Mile", "Inch" };
        string[] listBoxAreaItem = { "Square Km", "Square Hm", "Square Dkm", "Square M", "Square Dm", "Square Cm", "Square Mm", "Square Foot", "Square Mile", "Square Inch" };
        string[] listBoxWeightItem = { "Pound", "Kg", "Gram" };
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        // water mark textbox
        #region firstTextBox
        private void firstTextboxEnter(object sender, EventArgs e)
        {
            if (firstTextbox.Text == "Enter value")
            {
                firstTextbox.ForeColor = Color.Black;
                firstTextbox.Text = "";
            }
            if (ConversionType.Text == null || ConversionType.Text == "Select conversion type")
                MessageBox.Show("Please select the conversion type first.");
            else
            {
                if (firstListbox.Text == null || firstListbox.Text == "Conversion")
                {
                    MessageBox.Show("Select the conversion");
                }
            }
        }

        private void firstTextboxLeave(object sender, EventArgs e)
        {
            if (firstTextbox.Text == "")
            {
                firstTextbox.ForeColor = Color.Gray;
                firstTextbox.Text = "Enter value";
            }
            firstListbox.ForeColor = Color.White;
        }
        #endregion
        #region secondtextbox
        private void secondTextboxEnter(object sender, EventArgs e)
        {
            if (secondTextbox.Text == "Enter value")
            {
                secondTextbox.ForeColor = Color.Black;
                secondTextbox.Text = "";
            }
        }

        private void secondTextboxLeave(object sender, EventArgs e)
        {
            if (secondTextbox.Text == "")
            {
                secondTextbox.ForeColor = Color.Gray;
                secondTextbox.Text = "Enter value";
            }
        }

        #endregion
        // end water mark

        // NumericTextBox
        private void KeyPresss(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
            if ((e.KeyChar != '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
  