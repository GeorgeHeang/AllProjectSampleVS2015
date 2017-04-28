using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Typing
{
    public partial class Form1 : Form
    {
        string declareText = "A Typing.";
        string subText;
        int textIndex = 0;
        int correct = 0;
        int error = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbtext.BackColor = Color.LightGreen;
            lbError.BackColor = Color.LightPink;
            lbtext.Text =declareText ;
            subText = lbtext.Text.Substring(0, 1);
            lbSubstring.TextAlign = ContentAlignment.MiddleCenter;
            lbSubstring.Text = subText;
            lbError.Text = string.Format("Correct={0} Error={1}", correct, error);
            //change picture box color
            ChangePictureBoxColor(Convert.ToChar(subText));
            
        }
        private void ChangePictureBoxColor(char Text)
        {
            #region switch
            switch (Text)
            {
                case 'A':
                case 'a':
                    PictureBoxColor(pictureBox1, Color.Red);
                    break;
                case 'B':
                case 'b':
                    PictureBoxColor(pictureBox4, Color.Red);
                    break;
                case 'C':
                case 'c':
                    PictureBoxColor(pictureBox3, Color.Red);
                    break;
                case 'D':
                case 'd':
                    PictureBoxColor(pictureBox3, Color.Red);
                    break;
                case 'E':
                case 'e':
                    PictureBoxColor(pictureBox3, Color.Red);
                    break;
                case 'F':
                case 'f':
                    PictureBoxColor(pictureBox4, Color.Red);
                    break;
                case 'G':
                case 'g':
                    PictureBoxColor(pictureBox4, Color.Red);
                    break;
                case 'H':
                case 'h':
                    PictureBoxColor(pictureBox6, Color.Red);
                    break;
                case 'I':
                case 'i':
                    PictureBoxColor(pictureBox7, Color.Red);
                    break;
                case 'J':
                case 'j':
                    PictureBoxColor(pictureBox6, Color.Red);
                    break;
                case 'K':
                case 'k':
                    PictureBoxColor(pictureBox6, Color.Red);
                    break;
                case 'L':
                case 'l':
                    PictureBoxColor(pictureBox7, Color.Red);
                    break;
                case 'M':
                case 'm':
                    PictureBoxColor(pictureBox7, Color.Red);
                    break;
                case 'N':
                case 'n':
                    PictureBoxColor(pictureBox6, Color.Red);
                    break;
                case 'O':
                case 'o':
                    PictureBoxColor(pictureBox7, Color.Red);
                    break;
                case 'P':
                case 'p':
                    PictureBoxColor(pictureBox8, Color.Red);
                    break;
                case 'Q':
                case 'q':
                    PictureBoxColor(pictureBox1, Color.Red);
                    break;
                case 'R':
                case 'r':
                    PictureBoxColor(pictureBox4, Color.Red);
                    break;
                case 'S':
                case 's':
                    PictureBoxColor(pictureBox2, Color.Red);
                    break;
                case 'T':
                case 't':
                    PictureBoxColor(pictureBox4, Color.Red);
                    break;
                case 'U':
                case 'u':
                    PictureBoxColor(pictureBox6, Color.Red);
                    break;
                case 'V':
                case 'v':
                    PictureBoxColor(pictureBox4, Color.Red);
                    break;
                case 'W':
                case 'w':
                    PictureBoxColor(pictureBox2, Color.Red);
                    break;
                case 'X':
                case 'x':
                    PictureBoxColor(pictureBox2, Color.Red);
                    break;
                case 'Y':
                case 'y':
                    PictureBoxColor(pictureBox6, Color.Red);
                    break;
                case 'Z':
                case 'z':
                    PictureBoxColor(pictureBox1, Color.Red);
                    break;
                case ',':
                case '<':
                    PictureBoxColor(pictureBox7, Color.Red);
                    break;
                case '.':
                case '>':
                    PictureBoxColor(pictureBox8, Color.Red);
                    break;
                case '/':
                case '?':
                    PictureBoxColor(pictureBox9, Color.Red);
                    break;
                case '\'':
                case '\"':
                    PictureBoxColor(pictureBox9, Color.Red);
                    break;
                case ';':
                case ':':
                    PictureBoxColor(pictureBox8, Color.Red);
                    break;
                case '\\':
                case '|':
                    PictureBoxColor(pictureBox9, Color.Red);
                    break;
                case ']':
                case '}':
                    PictureBoxColor(pictureBox9, Color.Red);
                    break;
                case '[':
                case '{':
                    PictureBoxColor(pictureBox8, Color.Red);
                    break;
                case '=':
                case '+':
                    PictureBoxColor(pictureBox8, Color.Red);
                    break;
                case '-':
                case '_':
                    PictureBoxColor(pictureBox8, Color.Red);
                    break;
                case '0':
                case ')':
                    PictureBoxColor(pictureBox7, Color.Red);
                    break;
                case '9':
                case '(':
                    PictureBoxColor(pictureBox7, Color.Red);
                    break;
                case '8':
                case '*':
                    PictureBoxColor(pictureBox6, Color.Red);
                    break;
                case '7':
                case '&':
                    PictureBoxColor(pictureBox6, Color.Red);
                    break;
                case '6':
                case '^':
                    PictureBoxColor(pictureBox4, Color.Red);
                    break;
                case '5':
                case '%':
                    PictureBoxColor(pictureBox4, Color.Red);
                    break;
                case '4':
                case '$':
                    PictureBoxColor(pictureBox3, Color.Red);
                    break;
                case '3':
                case '#':
                    PictureBoxColor(pictureBox2, Color.Red);
                    break;
                case '2':
                case '@':
                    PictureBoxColor(pictureBox2, Color.Red);
                    break;
                case '1':
                case '!':
                    PictureBoxColor(pictureBox1, Color.Red);
                    break;
                case '`':
                case '~':
                    PictureBoxColor(pictureBox1, Color.Red);
                    break;
                case ' ':
                    PictureBoxColor(pictureBox5, Color.Red);
                    break;
                default:
                    break;
            }
            #endregion
        }
        private void PictureBoxColor(PictureBox picBox, Color color)
        {
            switch (picBox.Name)
            {
                case "pictureBox1":
                    pictureBox1.BackColor = color;
                    pictureBox2.BackColor = Color.LightBlue;
                    pictureBox3.BackColor = Color.LightBlue;
                    pictureBox4.BackColor = Color.LightBlue;
                    pictureBox5.BackColor = Color.LightBlue;
                    pictureBox6.BackColor = Color.LightBlue;
                    pictureBox7.BackColor = Color.LightBlue;
                    pictureBox8.BackColor = Color.LightBlue;
                    pictureBox9.BackColor = Color.LightBlue;
                    break;
                case "pictureBox2":
                    pictureBox1.BackColor = Color.LightBlue;
                    pictureBox2.BackColor = color;
                    pictureBox3.BackColor = Color.LightBlue;
                    pictureBox4.BackColor = Color.LightBlue;
                    pictureBox5.BackColor = Color.LightBlue;
                    pictureBox6.BackColor = Color.LightBlue;
                    pictureBox7.BackColor = Color.LightBlue;
                    pictureBox8.BackColor = Color.LightBlue;
                    pictureBox9.BackColor = Color.LightBlue;
                    break;
                case "pictureBox3":
                    pictureBox1.BackColor = Color.LightBlue;
                    pictureBox2.BackColor = Color.LightBlue;
                    pictureBox3.BackColor = color;
                    pictureBox4.BackColor = Color.LightBlue;
                    pictureBox5.BackColor = Color.LightBlue;
                    pictureBox6.BackColor = Color.LightBlue;
                    pictureBox7.BackColor = Color.LightBlue;
                    pictureBox8.BackColor = Color.LightBlue;
                    pictureBox9.BackColor = Color.LightBlue;
                    break;
                case "pictureBox4":
                    pictureBox1.BackColor = Color.LightBlue;
                    pictureBox2.BackColor = Color.LightBlue;
                    pictureBox3.BackColor = Color.LightBlue;
                    pictureBox4.BackColor = color;
                    pictureBox5.BackColor = Color.LightBlue;
                    pictureBox6.BackColor = Color.LightBlue;
                    pictureBox7.BackColor = Color.LightBlue;
                    pictureBox8.BackColor = Color.LightBlue;
                    pictureBox9.BackColor = Color.LightBlue;
                    break;
                case "pictureBox5":
                    pictureBox1.BackColor = Color.LightBlue;
                    pictureBox2.BackColor = Color.LightBlue;
                    pictureBox3.BackColor = Color.LightBlue;
                    pictureBox4.BackColor = Color.LightBlue;
                    pictureBox5.BackColor = color;
                    pictureBox6.BackColor = Color.LightBlue;
                    pictureBox7.BackColor = Color.LightBlue;
                    pictureBox8.BackColor = Color.LightBlue;
                    pictureBox9.BackColor = Color.LightBlue;
                    break;
                case "pictureBox6":
                    pictureBox1.BackColor = Color.LightBlue;
                    pictureBox2.BackColor = Color.LightBlue;
                    pictureBox3.BackColor = Color.LightBlue;
                    pictureBox4.BackColor = Color.LightBlue;
                    pictureBox5.BackColor = Color.LightBlue;
                    pictureBox6.BackColor = color;
                    pictureBox7.BackColor = Color.LightBlue;
                    pictureBox8.BackColor = Color.LightBlue;
                    pictureBox9.BackColor = Color.LightBlue;
                    break;
                case "pictureBox7":
                    pictureBox1.BackColor = Color.LightBlue;
                    pictureBox2.BackColor = Color.LightBlue;
                    pictureBox3.BackColor = Color.LightBlue;
                    pictureBox4.BackColor = Color.LightBlue;
                    pictureBox5.BackColor = Color.LightBlue;
                    pictureBox6.BackColor = Color.LightBlue;
                    pictureBox7.BackColor = color;
                    pictureBox8.BackColor = Color.LightBlue;
                    pictureBox9.BackColor = Color.LightBlue;
                    break;
                case "pictureBox8":
                    pictureBox1.BackColor = Color.LightBlue;
                    pictureBox2.BackColor = Color.LightBlue;
                    pictureBox3.BackColor = Color.LightBlue;
                    pictureBox4.BackColor = Color.LightBlue;
                    pictureBox5.BackColor = Color.LightBlue;
                    pictureBox6.BackColor = Color.LightBlue;
                    pictureBox7.BackColor = Color.LightBlue;
                    pictureBox8.BackColor = color;
                    pictureBox9.BackColor = Color.LightBlue;
                    break;
                case "pictureBox9":
                    pictureBox1.BackColor = Color.LightBlue;
                    pictureBox2.BackColor = Color.LightBlue;
                    pictureBox3.BackColor = Color.LightBlue;
                    pictureBox4.BackColor = Color.LightBlue;
                    pictureBox5.BackColor = Color.LightBlue;
                    pictureBox6.BackColor = Color.LightBlue;
                    pictureBox7.BackColor = Color.LightBlue;
                    pictureBox8.BackColor = Color.LightBlue;
                    pictureBox9.BackColor = color;
                    break;
                default:
                    break;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(subText))
            {
                if (textIndex<=lbtext.Text.Length-2)
                {
                    textIndex++;
                    correct++;
                    lbSubstring.Text = lbtext.Text.Substring(textIndex, 1);
                }
                else
                {
                    MessageBox.Show("You done your correct is " +correct.ToString() +" and error is "+error.ToString());
                    this.Close();
                }
                lbError.Text = string.Format("Correct={0} Error={1}", correct, error);
            }
            else
            {
                error++;
                lbError.Text = string.Format("Correct={0} Error={1}", correct, error);
            }
        }

        private void lbSubstring_TextChanged(object sender, EventArgs e)
        {
                subText = lbSubstring.Text;
                ChangePictureBoxColor(Convert.ToChar(subText));                        
        }
    }
}
