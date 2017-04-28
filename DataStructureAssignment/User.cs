using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructureAssignment
{
    public partial class User : Form
    {
        OleDbConnection access = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;data source=C:\\Users\\George\\Documents\\datastructureassignment.accdb");
        OleDbCommand command;
        DataSet dsa;
        OleDbDataAdapter adapter;
        
        public User()
        {
            InitializeComponent();
            access.Open();
            command = new OleDbCommand("Select Distinct Type from tbl_Userinfo", access);
            OleDbDataReader reader = command.ExecuteReader();
            string item = "";
            while (reader.Read())
            {
                item = reader["Type"].ToString();
                comboBox1.Items.Add(item);
            }
        }
//new user
        private void button4_Click(object sender, EventArgs e)
        {
            button6_Click(sender, e);
            textBox1.Text = "";
            tbPassword.Text = "";
            tbUserName.Text = "";
            button7Cancel2.Visible = true;
            comboBox1.SelectedItem =null;
        }
        void SearchFromCheckbox(TextBox txt, RadioButton chb, string searchStatement)
        {
            if (chb.Checked == true)
            {
                try
                {
                    if (txt.Text != "")
                    {
                        dsa.Tables["user"].Clear();
                        adapter = new OleDbDataAdapter(searchStatement, access);
                        adapter.Fill(dsa, "user");
                    }
                    else
                    {
                        dsa.Tables["user"].Clear();
                        adapter = new OleDbDataAdapter("Select * from tbl_UserInfo", access);
                        adapter.Fill(dsa, "user");
                    }
                    if (string.IsNullOrEmpty(txt.Text))
                    {
                        dsa.Tables["user"].Clear();
                        adapter = new OleDbDataAdapter("select * from tbl_UserInfo where Staff_ID = 0", access);
                        adapter.Fill(dsa, "user");

                    }


                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }

        }

        private void User_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            checkOne.Checked = true;
            adapter = new OleDbDataAdapter("SELECT * FROM tbl_UserInfo", access);
            dsa = new DataSet();
            adapter.Fill(dsa, "user");
            dataGridView1.DataSource = dsa.Tables["user"];
            access.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (checkOne.Checked)
            {
                int s;
                bool a = int.TryParse(textBox7.Text, out s);
                if (textBox7.Text != "" && a)
                {
                    SearchFromCheckbox(textBox7, checkOne, "Select * from tbl_UserInfo Where Staff_ID=" + s + "");
                    dataGridView1.DataSource = (dsa.Tables["user"]);
                }
                else
                {
                    dsa.Tables["user"].Clear();
                    adapter = new OleDbDataAdapter("Select * from tbl_UserInfo", access);
                    adapter.Fill(dsa, "user");
                }

            }
            if (checkTwo.Checked)
            {
                if (textBox7.Text != "")
                {
                    SearchFromCheckbox(textBox7, checkTwo, "Select * from tbl_UserInfo Where UserName like'%" + textBox7.Text + "%'");
                    dataGridView1.DataSource = (dsa.Tables["user"]);
                }
                else
                {
                    dsa.Tables["user"].Clear();
                    adapter = new OleDbDataAdapter("Select * from tbl_UserInfo", access);
                    adapter.Fill(dsa, "user");
                }
            }
        }

        //add user
        private void button6_Click(object sender, EventArgs e)
        {           
            panel2.Visible = false;
            panel1.Visible = true;
            button7Cancel2.Visible = true;
            panel1.BringToFront();
            textBox4.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            btnUpdate.Visible = false;
            button5cancel1.Visible = false;
            textBox1.Clear();
            tbPassword.Clear();
            tbUserName.Clear();
            comboBox1.Text=null;
            
        }

        //Save
        private void button2_Click(object sender, EventArgs e)
        {
            access.Close();
            if (textBox1.Text=="")
            {
                MessageBox.Show("Staff ID cannot null.");
                textBox1.Focus();
            }
            else
            {
                int a;
                bool convert = int.TryParse(textBox1.Text, out a);
                if (!convert)
                {
                    MessageBox.Show("Staff ID is integer only.");
                    textBox1.Clear();
                    textBox1.Focus();
                    access.Close();
                }
                else
                {
                    access.Open();
                    command = new OleDbCommand("Select ID from tbl_StaffInformation where ID=" + a + ";",access);
                    OleDbDataReader r = command.ExecuteReader();
                    if (r.Read())
                    {
                        command = new OleDbCommand("Select * from tbl_UserInfo where Staff_ID=" + a + ";", access);
                        OleDbDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("This Staff ID already has a user account.");
                            textBox1.Focus();
                            access.Close();
                        }
                        else
                        {
                            if (tbUserName.Text == "")
                            {
                                MessageBox.Show("You have to provide a username.");
                                tbUserName.Focus();
                            }
                            else
                            {
                                command = new OleDbCommand("Select * from tbl_UserInfo where UserName='" + tbUserName.Text + "'", access);
                                OleDbDataReader read = command.ExecuteReader();
                                if (read.Read())
                                {
                                    MessageBox.Show("Username is unavilable! Try another one.");
                                    tbUserName.Focus();
                                    access.Close();
                                }
                                else
                                {
                                  
                                    if (tbPassword.Text == "")
                                    {
                                        MessageBox.Show("You must provide a password for security");
                                        tbPassword.Focus();
                                    }
                                    else
                                    {
                                        if (comboBox1.SelectedItem == null)
                                        {
                                            MessageBox.Show("You must provide what type of username is.");
                                            comboBox1.Focus();
                                            access.Close();
                                        }
                                        else
                                        {
                                            command = new OleDbCommand("Insert into tbl_UserInfo (Staff_ID,[UserName],[Password],Type) Values(" + a + " , '" + tbUserName.Text + "','" + EncriptAndDecript.Encript(tbPassword.Text) + "','" + comboBox1.Text + "')", access);
                                            command.ExecuteNonQuery();
                                            MessageBox.Show("User has Created!");
                                            access.Close();
                                            User_Load(sender, e);
                                        }
                                    }
                                }
                            }
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("There is not this Staff ID in Staff Information.");
                        textBox1.Focus();
                        access.Close();
                    }
                }

            }
            
        }

        private void button7Cancel2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            User_Load(sender, e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;panel1.BringToFront();
            panel2.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button6.Visible = false;
            btnUpdate.Visible = false;
            button1.Visible = true;
            textBox4.Visible = true;
            comboBox1.Visible = false;
            button5cancel1.Visible = false;
            button7Cancel2.Visible = false;
            textBox1.ReadOnly = true;
            tbUserName.ReadOnly = true;
            tbPassword.ReadOnly = true;
            textBox4.ReadOnly = true;
            comboBox1.Enabled = false;
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            tbUserName.Text = row.Cells[1].Value.ToString();
            tbPassword.Text = EncriptAndDecript.Decript(row.Cells[2].Value.ToString());
            textBox4.Text = row.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button6.Visible = true;
            button1.Visible = false;
            btnUpdate.Visible = true;
            button5cancel1.Visible = true;
            button7Cancel2.Visible = false;
            textBox1.ReadOnly = false;
            tbUserName.ReadOnly = false;
            tbPassword.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox4.Visible = false;
            comboBox1.Enabled = true;
            comboBox1.Visible = true;
            comboBox1.Text= textBox4.Text;
            
            
        }
        //Delete
        private void button3_Click(object sender, EventArgs e)
        {
            int a;
            bool check = int.TryParse(textBox1.Text, out a);
            if (check==true)
            {
                access.Open();
                command = new OleDbCommand("Select [UserName] from tbl_UserInfo where Staff_ID=" + a + ";",access);
                OleDbDataReader r= command.ExecuteReader();
                string us="";
                while (r.Read())
                {
                    us = r[0].ToString();
                }         
                        
                DialogResult result= MessageBox.Show("Are you sure to delete user \""+us+"\"?","Confirm",MessageBoxButtons.YesNo);
                if(result==DialogResult.Yes)
                {

                    command = new OleDbCommand("Delete * from tbl_UserInfo where Staff_ID=" + a + ";", access);
                    command.ExecuteNonQuery();
                    MessageBox.Show("User has deleted!");
                    panel1.Visible = false;
                    User_Load(sender, e);
                    
                }
                access.Close();
            }
            else
            {
                MessageBox.Show("Please provide a Staff ID to delete");
            }
            
        }

        private void button5cancel1_Click(object sender, EventArgs e)
        {
            User_Load(sender, e);
        }
// update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            int a;
            bool check = int.TryParse(textBox1.Text, out a);
            if (check)
            {
                access.Open();
                command = new OleDbCommand("Select Staff_ID from tbl_UserInfo where Staff_ID=" + a + ";", access);
                OleDbDataReader r = command.ExecuteReader();
                string us = "";
                if (r.Read())
                {
                    
                    command = new OleDbCommand("Select [UserName] from tbl_UserInfo where Staff_ID=" + a + ";", access);
                    r = command.ExecuteReader();
                    while (r.Read())
                    {
                        us = r[0].ToString();
                    }
                    DialogResult result;
                    result=MessageBox.Show("Are you sure to update user \"" + us + "\"?","Confirm",MessageBoxButtons.YesNo);
                    if (result==DialogResult.Yes)
                    {
                        if (comboBox1.Text!="")
                        {
                            command = new OleDbCommand("Update tbl_UserInfo set Staff_ID=" + a + ",[UserName]='" + tbUserName.Text + "',[PassWord]='" + EncriptAndDecript.Encript(tbPassword.Text) + "',Type='" + comboBox1.SelectedItem + "' where Staff_ID=" + a + ";", access);
                            command.ExecuteNonQuery();
                            result = MessageBox.Show("User has updated!");
                            panel1.Visible = false;
                            User_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Please provide a type to user.");
                            comboBox1.Focus();
                        }
                        
                    }
                    access.Close();


                }
                else
                {
                    MessageBox.Show("There is not this Staff ID in Staff Information.");
                    textBox1.Focus();
                }
                access.Close();               
            }
            else
            {
                MessageBox.Show("Staff ID is integer only!");
                textBox1.Focus();
            }
        }

    }
}
