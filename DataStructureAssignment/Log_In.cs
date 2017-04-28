using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace DataStructureAssignment
{
    public partial class Log_In : Form
    {
        OleDbConnection access = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;data source=C:\\Users\\George\\Documents\\datastructureassignment.accdb");
        OleDbCommand command;
        public Log_In()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                passWord.PasswordChar = '\0';
            }
            else
            {
                passWord.PasswordChar = '*';
            }
                
        }
        private void button1_Click(object sender, EventArgs e)
        {
            access.Open();
            command = new OleDbCommand("SELECT * FROM tbl_UserInfo Where UserName='" + userName.Text + "';", access);
            OleDbDataReader user = command.ExecuteReader();
            if (user.Read() == true)
            {
                string passW = EncriptAndDecript.Encript(passWord.Text);
                command = new OleDbCommand("SELECT * FROM tbl_UserInfo Where UserName='" + userName.Text + "' AND [Password]='" + passW + "';", access);
                user = command.ExecuteReader();
                if (user.Read() == true)
                {
                    OleDbCommand command = new OleDbCommand("SELECT Staff_ID FROM tbl_UserInfo WHERE [UserName]='"+userName.Text+"';", access);
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string text =  reader["Staff_ID"].ToString();
                        using (StreamWriter files = new StreamWriter(@"C:\Users\George\Desktop\test.txt", false))
                        {
                            files.WriteLine(text);
                        }
                    }
                    this.Hide();
                    MainForm fm = new MainForm();
                    fm.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Password is incorrect.");
                    passWord.Focus();
                    passWord.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("There is not this username.");
                userName.Focus();
                userName.SelectAll();
            }
            access.Close();
        }
        int i = 1;
        private void checkBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(System.ConsoleKey.Enter))
            {
                if (i % 2 != 0)
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }
                i++;
            }
            
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(System.ConsoleKey.Enter))
            {
                button1_Click(sender, e);
            }
        }

        private void userName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(System.ConsoleKey.Enter))
            {
                passWord.Focus();
            }
        }

        private void passWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            button1_KeyPress(sender, e);
        }
    }
}
