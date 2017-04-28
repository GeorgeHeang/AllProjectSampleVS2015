using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace DataStructureAssignment
{
    public partial class StaffInfo : Form
    {
        OleDbConnection access = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;data source=C:\\Users\\George\\Documents\\datastructureassignment.accdb");
        OleDbCommand command;
        DataSet staffdataset;
        OleDbDataAdapter staffadapter;
        

        public StaffInfo()
        {
            InitializeComponent();
            access.Open();
            string[] item = { "Seller", "Manager", "Marketing","IT" };
            for (int i = 0; i < item.Length; i++)
            {
                comboBox1.Items.Add(item[i]);
            }

        }

        private void StaffInfo_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            browse.Visible = false;
            try
            {
                button2.Visible = false;
                groupBox1.Visible = false;
                checkOne.Checked = true;
                dataGridView1.Visible = true;
                browse.Visible = true;
                staffadapter = new OleDbDataAdapter("SELECT * FROM tbl_StaffInformation ;", access);
                staffdataset = new DataSet();
                staffadapter.Fill(staffdataset, "staff");
                dataGridView1.DataSource = staffdataset.Tables["staff"];
                access.Close();
                btnUpdate.Visible = false;
                button1.Visible = false;
                button5.Visible = false;
                button4.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);

            }
            access.Close();


        }
        //edit
        private void button2_Click(object sender, EventArgs e)
        {            
            dateTimePicker1.Text = dateofbirth.Text;
            browse.Visible = !true;
                tbstaffid.ReadOnly = false;
                tbstaffname.ReadOnly = false;
                phone.ReadOnly = false;
                position.Visible = false;
                sex.Visible = false;
                dateofbirth.Visible = false;
                textBox7.ReadOnly = false;
                placeofbirth.ReadOnly = false;
                currentaddress.ReadOnly = false;
                backgroundedu.ReadOnly = false;
                backgroundwork.ReadOnly = false;
                button1.Visible = true;
                save.Visible = false;
                btnUpdate.Visible = true;
                button5.Visible = true;
                button4.Visible = true;
                button2.Visible = false;
                browse.Visible = false;
            button4.Visible = true;
            comboBox1.Text = position.Text;




        }




        private void StaffInfo_SizeChanged(object sender, EventArgs e)
        {
            label11.Size = new System.Drawing.Size(1370, 53);
        }
        string img;
        //browse
        
        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Choose Image";
            openfile.Filter = "JPEG(*.jpg)|*.jpg|PNG(*.png)|*.png";
            if (openfile.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                img = openfile.FileName;
                pictureBox1.Image = System.Drawing.Image.FromFile(img);               
            }
        }

        //button save
        private void button3_Click(object sender, EventArgs e)
        {
            access.Open();
            

            int a;
            bool check = int.TryParse(tbstaffid.Text, out a);
            if (check)
            {

                command = new OleDbCommand("Select ID from tbl_StaffInformation where ID=" + a + ";", access);
                OleDbDataReader r = command.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("There is  this Product ID already.");
                    tbstaffid.Focus();
                }
                else
                {
                    if (comboBox1.Text != "")
                    {
                                                
                            command = new OleDbCommand(@"Insert into tbl_StaffInformation (ID,StaffName,sex,placeofbirth,backgroundwork,backgroundEducation,currentAddress) Values("+a+",'"+tbstaffname.Text+"','"+cbSex.SelectedItem+"','"+placeofbirth.Text+"','"+backgroundwork.Text+"','"+backgroundedu.Text+"','"+currentaddress.Text+"')", access);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Staff added!");
                            groupBox1.Visible = false;
                            StaffInfo_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Please provide a type to prooduct.");
                        comboBox1.Focus();
                    }


                }
                access.Close();
            }
            else
            {
                MessageBox.Show("Product ID is integer only!");
                tbstaffid.Focus();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Visible = false;
            browse.Visible = false;
            button2.Visible = true;
            dataGridView1.Visible = false;
            groupBox1.Visible = true;
            tbstaffid.ReadOnly = true;
            tbstaffname.ReadOnly = true;
            sex.ReadOnly = true;
            position.ReadOnly = true;
            placeofbirth.ReadOnly =true;
            dateofbirth.ReadOnly = true;
            currentaddress.ReadOnly = true;
            backgroundedu.ReadOnly = true;
            backgroundwork.ReadOnly = true;
            phone.ReadOnly = true;
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            tbstaffid.Text = row.Cells[0].Value.ToString();
            tbstaffname.Text = row.Cells[1].Value.ToString();
            sex.Text = row.Cells[2].Value.ToString();
            position.Text = row.Cells[3].Value.ToString();
            placeofbirth.Text = row.Cells[5].Value.ToString();
            dateofbirth.Text = row.Cells[4].Value.ToString();
            currentaddress.Text = row.Cells[6].Value.ToString();
            backgroundedu.Text = row.Cells[8].Value.ToString();
            backgroundwork.Text = row.Cells[9].Value.ToString();
         //   phone.Text = row.Cells[10].Value.ToString();
            comboBox1.Text = position.Text;
            cbSex.Text = sex.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffInfo_Load(sender, e);
            button1.Visible = false;
            button2.Visible = false;
            save.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            btnUpdate.Visible = false;
        }
//search
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (checkOne.Checked)
            {
                int s;
                bool a = int.TryParse(textBox7.Text, out s);
                if (textBox7.Text != "" && a)
                {
                    SearchFromCheckbox(textBox7, checkOne, "Select * from tbl_StaffInformation Where ID=" + s + "");
                    dataGridView1.DataSource = (staffdataset.Tables["staff"]);
                }
                else
                {
                    staffdataset.Tables["staff"].Clear();
                    staffadapter = new OleDbDataAdapter("Select * from tbl_StaffInformation", access);
                    staffadapter.Fill(staffdataset, "staff");
                }

            }
            if (checkTwo.Checked)
            {
                if (textBox7.Text != "")
                {
                    SearchFromCheckbox(textBox7, checkTwo, "Select * from tbl_staffInformation Where StaffName like'%" + textBox7.Text + "%'");
                    dataGridView1.DataSource = (staffdataset.Tables["staff"]);
                }
                else
                {
                    staffdataset.Tables["staff"].Clear();
                    staffadapter = new OleDbDataAdapter("Select * from tbl_StaffInformation", access);
                    staffadapter.Fill(staffdataset, "staff");
                }
            }
            if (checkThree.Checked)
            {
                if (textBox7.Text != "")
                {
                    SearchFromCheckbox(textBox7, checkThree, "Select * from tbl_staffinformation Where Phone like'%" + textBox7.Text + "%'");
                    dataGridView1.DataSource = (staffdataset.Tables["staff"]);
                }
                else
                {
                    staffdataset.Tables["staff"].Clear();
                    staffadapter = new OleDbDataAdapter("Select * from tbl_StaffInformation", access);
                    staffadapter.Fill(staffdataset, "staff");
                }
            }
        }
        private void SearchFromCheckbox(TextBox txt, RadioButton chb, string searchStatement)
        {
            if (chb.Checked == true)
            {
                try
                {
                    if (txt.Text != "")
                    {
                        staffdataset.Tables["staff"].Clear();
                        staffadapter = new OleDbDataAdapter(searchStatement, access);
                        staffadapter.Fill(staffdataset, "staff");
                    }
                    else
                    {
                        staffdataset.Tables["staff"].Clear();
                        staffadapter = new OleDbDataAdapter("Select * from tbl_StaffInformation", access);
                        staffadapter.Fill(staffdataset, "staff");
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            access.Open();
            int a;
            bool check = int.TryParse(tbstaffid.Text, out a);
            if (check)
            {
                
                command = new OleDbCommand("Select ID from tbl_StaffInformation where ID=" + a + ";", access);
                OleDbDataReader r = command.ExecuteReader();
                string us = "";
                if (r.Read())
                {
                    DialogResult result;
                    result = MessageBox.Show("Are you sure to update user \"" + us + "\"?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        var pic = File.ReadAllBytes(img);
                        command = new OleDbCommand("Update tbl_StaffInformation set ID=" + a + ",StaffName='" +tbstaffname.Text + "',Sex='"+cbSex.SelectedItem+" ',Position=" + comboBox1.SelectedIndex + ",placeofbirth='"+placeofbirth.Text+"',dateofbirth=='"+dateTimePicker1.Text+"',currentaddress='"+currentaddress.Text+"',backgroundEducation='"+backgroundedu+"',backgroundwork='"+backgroundwork.Text+"',phone='"+phone.Text+"' where ID=" + a + ";", access);
                        command.ExecuteNonQuery();
                        access.Close();
                        result = MessageBox.Show("Staff has updated!");
                        groupBox1.Visible = false;
                        StaffInfo_Load(sender, e);
                    }
                    access.Close();
   }
                else
                {
                    MessageBox.Show("There is not this Staff ID in Staff Information.");
                    tbstaffid.Focus();
                }
            }
            else
            {
                MessageBox.Show("Staff ID is integer only!");
                tbstaffid.Focus();
            }
        }
        //new
        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            save.Visible = true;
            btnUpdate.Visible = false;
            cbSex.Text = null;
            comboBox1.Text = null;
            button4.Visible = false;
            tbstaffid.Text = "";
            tbstaffname.Text = "";
            sex.Text = "";
            position.Text = "";
            placeofbirth.Text = "";
            dateTimePicker1.Text = DateTime.Today.ToShortDateString();
            currentaddress.Text = "";
            backgroundedu.Text = "";
            backgroundwork.Text = "";
            phone.Text = "";
        }
        //delete
        private void button4_Click(object sender, EventArgs e)
        {
            access.Open();
            int a;
            bool convert = int.TryParse(tbstaffid.Text, out a);
            if (convert)
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this staff?", "Confirm", MessageBoxButtons.YesNo);
                if (result==DialogResult.Yes)
                {
                    command = new OleDbCommand("Delete * from tbl_StaffInformation where ID=" + a + "",access);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Staff has deleted.");
                    StaffInfo_Load(sender, e);
                }
                
            }
            else
            {
                MessageBox.Show("Staff ID is in correct.");
            }
            access.Close();
        }
    }
}
