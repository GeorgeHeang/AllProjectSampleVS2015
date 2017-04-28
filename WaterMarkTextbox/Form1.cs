using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterMarkTextbox
{
    public partial class LoginandSignup : Form
    {
        //Array of textbox value
        string[] firstNamelist = {"George" };
        string[] lastNamelist = {"Heang" };
        string[] passwordList = {"kaynavin" };
        string[] emailList = {"khunsokheang@gmail.com" };
        string[] addressList = {"Phnom Penh" };
        string[] usernameList = {"George" };
        string[] dayofbirthList = {"27" };
        string[] monthofbirthList = { "March" };
        string[] yearofbirthList = { "1997" };


        // textbox variable        
        string firstnameValue;
        string lastnameValue;
        string addressValue;
        string signuppasswordValue;
        string loginpasswordValue;
        string signupusernameValue;
        string loginusernameValue;
        string emailValue;
        string monthValue;
        string dayValue;
        string yearValue;

        // Toolbox
        public LoginandSignup()
        {
            InitializeComponent();
        }
        // This is the process of program//
        #region sign_up
        #region firstnameTextbox
        private void enterfirstname(object sender, EventArgs e)
        {
            if (firstName.Text == "Enter your first name")
            {
                firstName.ForeColor = Color.Black;
                firstName.Text = "";
            }
        }

        private void leavefirstname(object sender, EventArgs e)
        {
            if (firstName.Text == "")
            {
                firstName.ForeColor = SystemColors.GrayText;
                firstName.Text = "Enter your first name";
            }
            else if (firstName.Text != "Enter your first name")
            {
                firstnameValue = firstName.Text;
            }
        }
        #endregion
        #region lastnameTextbox
        private void enterlastName(object sender, EventArgs e)
        {
            if (lastName.Text == "Enter your last name")
            {
                lastName.ForeColor = Color.Black;
                lastName.Text = "";
            }
        }

        private void leavelastName(object sender, EventArgs e)
        {
            if (lastName.Text == "")
            {
                lastName.ForeColor = SystemColors.GrayText;
                lastName.Text = "Enter your last name";
            }
            else if (lastName.Text != "Enter your last name")
            {
                lastnameValue = lastName.Text;
            }
        }
        #endregion
        #region addressTextbox
        private void addressEnter(object sender, EventArgs e)
        {
            if (addRess.Text == "Enter you address")
            {
                addRess.ForeColor = Color.Black;
                addRess.Text = "";
            }
        }

        private void addressLeave(object sender, EventArgs e)
        {
            if (addRess.Text == "")
            {
                addRess.ForeColor = SystemColors.GrayText; ;
                addRess.Text = "Enter you address";
            }
            else if (addRess.Text != "Enter you address")
            {
                addressValue = addRess.Text;
            }
        }
        #endregion
        #region Email
        private void EmailEnter(object sender, EventArgs e)
        {
            if (emAil.Text == "Enter your Email")
            {
                emAil.ForeColor = Color.Black;
                emAil.Text = "";
            }
        }

        private void EmailLeave(object sender, EventArgs e)
        {
            if (emAil.Text == "")
            {
                emAil.ForeColor = SystemColors.GrayText;
                emAil.Text = "Enter your Email";
            }
            else if (emAil.Text != "Enter your Email")
            {
                emailValue = emAil.Text; ;
            }
        }
        #endregion
        #region signupusernameTextbox
        private void enterUsername(object sender, EventArgs e)
        {
            if (signupUsername.Text == "Enter username")
            {
                signupUsername.ForeColor = Color.Black;
                signupUsername.Text = "";
            }
        }

        private void leaveUsername(object sender, EventArgs e)
        {
            if (signupUsername.Text == "")
            {
                signupUsername.ForeColor = SystemColors.GrayText; ;
                signupUsername.Text = "Enter username";
            }
            else if (emAil.Text != "Enter username")
            {
                signupusernameValue = signupUsername.Text;
            }
        }
        #endregion
        #region signuppasswordTextbox
        private void entersignupPassword(object sender, EventArgs e)
        {
            if (signupPassword.Text == "Enter password")
            {
                signupPassword.ForeColor = Color.Black;
                signupPassword.Text = "";
            }
        }

        private void leavesignupPassword(object sender, EventArgs e)
        {
            if (signupPassword.Text == "")
            {
                signupPassword.ForeColor = SystemColors.GrayText; ;
                signupPassword.Text = "Enter password";
            }
            else if (signupPassword.Text != "Enter password")
            {

                signuppasswordValue = signupPassword.Text;
            }
        }
        private void signupPassword_TextChanged(object sender, EventArgs e)
        {
            if (signupPassword.TextLength > 10 && signupPassword.Text != "Enter password")
            {
                MessageBox.Show("10 character only");
                string a = signupPassword.Text.Remove(10, 1);
                signupPassword.Text = a;
                signupPassword.SelectAll();
            }
        }
        #endregion
        #region loginusernameTextbox
        private void enterloginUsername(object sender, EventArgs e)
        {
            if (loginUsername.Text == "Enter your username")
            {
                loginUsername.ForeColor = Color.Black;
                loginUsername.Text = "";
            }
        }

        private void leaveloginUsername(object sender, EventArgs e)
        {
            if (loginUsername.Text == "")
            {
                loginUsername.ForeColor = SystemColors.GrayText; ;
                loginUsername.Text = "Enter your username";
            }
            else if (loginUsername.Text != "Enter your username")
            {
                loginusernameValue = loginUsername.Text;
            }

        }
        #endregion
        #region loginpasswordTextbox
        private void enterloginPassword(object sender, EventArgs e)
        {
            if (loginPassword.Text == "Enter your password")
            {
                loginPassword.ForeColor = Color.Black;

                loginPassword.Font = new Font(loginPassword.Font, FontStyle.Bold);
                loginPassword.PasswordChar = '*';
                loginPassword.Text = "";
            }
        }

        private void leaveloginPassword(object sender, EventArgs e)
        {
            if (loginPassword.Text == "")
            {
                loginPassword.ForeColor = SystemColors.GrayText;
                loginPassword.Font = new Font(loginPassword.Font, FontStyle.Regular);
                loginPassword.PasswordChar = '\0';
                loginPassword.Text = "Enter your password";
            }
            else if (loginPassword.Text != "Enter your password")
            {
                loginpasswordValue = loginPassword.Text;
            }
        }


        #endregion

        #endregion

        private void LoginandSignup_Load(object sender, EventArgs e)
        {
            System.DateTime a  = System.DateTime.Today;
            int y=a.Year;
            for (int i = 1980; i <(y+1) ; i++)
            {
                YearBox.Items.Add(i);
            }          
        }

        private void YearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YearBox.Text!="Year")
            {
                YearBox.ForeColor = Color.Black;
            }
        }

        private void YearLeave(object sender, EventArgs e)
        {
           
        }

        private void MonthLeave(object sender, EventArgs e)
        {

        }
    }
}
