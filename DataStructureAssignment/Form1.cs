using System;
using System.Collections.Generic;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DataStructureAssignment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StaffInfo st = new StaffInfo();
            st.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            pro.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User n = new User();
            n.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                string line;
                long StaffID = 0;
                System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\George\Desktop\test.txt");
                while ((line = file.ReadLine()) != null)
                {
                    StaffID = Convert.ToInt64(line);
                }
                OleDbConnection access = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;data source=C:\\Users\\George\\Documents\\datastructureassignment.accdb");
                OleDbCommand command = new OleDbCommand("SELECT StaffName FROM tbl_StaffInformation WHERE ID=" + StaffID + ";", access);
                access.Open();
                OleDbDataReader result = command.ExecuteReader();
                while (result.Read())
                {
                    logUser.Text = result["StaffName"].ToString();
                }
                string type="";
                command = new OleDbCommand("SELECT Type FROM tbl_UserInfo WHERE Staff_ID = " + StaffID + "; ", access);
                result = command.ExecuteReader();
                while(result.Read())
                {
                    type = result["Type"].ToString();
                }
                if (type != "Administrator")
                {
                    button3.Enabled = false;
                    label4.Enabled = false;
                }
                else
                {
                    button3.Enabled = true;
                    label4.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Source);
            }            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {            
                Form fm = Application.OpenForms["Log_In"];
            for (int i = 0; i<=3 ; i++)
            {
                if (fm != null)
                {
                    fm.Close();
                }
            }
            
   
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Product pro = new Product();
            pro.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
