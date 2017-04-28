using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Two
{
    public partial class assgnment_two : Form
    {
        public assgnment_two()
        {
            InitializeComponent();
        }       
        string moNey, genDer, tiTle;

        private void tbfirstname_TextChanged(object sender, EventArgs e)
        {
            tbfirstname.Focus();
        }

        string spEech = ".\nYou pay ";
        private void btsubmit_Click(object sender, EventArgs e)
        {
         

            {
                switch (libbiketype.Text)
                {
                    
                    
                    case "Cube":
                        moNey = "$25";
                        break;
                    case "C125":
                        moNey = "$35";
                        break;
                    case "C250":
                        moNey = "$45";
                        break;
                    case "C600":
                        moNey = "$60";
                        break;
                    default:
                        break;
                }
                
                genDer = tbgender.Text.ToUpper();
                if (genDer == "M")
                {
                    tiTle = "Mr";
                    showOutput();
                }
                else if (genDer == "F")
                {
                    tiTle = "Ms";
                    showOutput();
                }
                else
                {
                    MessageBox.Show("You entered wrong gender. You can enter M or F only.");
                    tbgender.Clear();
                    tbgender.Focus();

                }

            }
        }
        // method
        public void showOutput()
        {
            outPut.Text = tiTle + " " + tbfirstname.Text.Substring(0, 1).ToUpper() + tbfirstname.Text.Remove(0, 1).ToLower() + " " + tblastname.Text.ToUpper() + spEech + moNey;
        }
    }
}
