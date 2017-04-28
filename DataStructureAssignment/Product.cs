using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DataStructureAssignment
{
    public partial class Product : Form
    {
        OleDbConnection access = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;data source=C:\\Users\\George\\Documents\\datastructureassignment.accdb");
        OleDbCommand command = new OleDbCommand();
        DataSet ds;
        OleDbDataAdapter dataAdapter;
        public Product()
        {
            InitializeComponent();
            access.Open();
            command = new OleDbCommand("Select type_id,type from tbl_type;", access);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Type"].ToString());
            }

        }

        private void Product_Load(object sender, EventArgs e)
        {
            panel2.Visible = true;
            checkOne.Checked = true;
            button1.Visible = true;
            dataGridPro.Visible = true;
            dataAdapter = new OleDbDataAdapter("Select pro_id,pro_name,price,tbl_type.type,quantityinstock from tbl_product inner join tbl_type on tbl_product.type = tbl_type.type_id", access);
            ds = new DataSet();
            dataAdapter.Fill(ds, "product");
            dataGridPro.DataSource = ds.Tables["product"];
            access.Close();
        }

        private void btneditpro_Click(object sender, EventArgs e)
        {
            btnsavepro.Visible=false;
            btnnewpro.Show();
            btncancelpro.Show();
            btneditpro.Hide();
            btndeletepro.Show();
            update.Visible = true;
            type.Visible = false;
            proname.ReadOnly = !true;
            proPrice.ReadOnly = !true;
            type.ReadOnly = !true;
            Quantity.ReadOnly = !true;
            proID.ReadOnly = !true;
            comboBox1.Text = type.Text;
            update.Visible = true;

        }

        private void btncancelpro_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Product_Load(sender, e);
        }

        void SearchFromCheckbox(TextBox txt, RadioButton chb, string searchStatement)
        {
            if (chb.Checked == true)
            {
                try
                {
                    if (txt.Text != "")
                    {
                        ds.Tables["product"].Clear();
                        dataAdapter = new OleDbDataAdapter(searchStatement, access);
                        dataAdapter.Fill(ds, "product");
                    }
                    else
                    {
                        ds.Tables["product"].Clear();
                        dataAdapter = new OleDbDataAdapter("Select * from tbl_Product", access);
                        dataAdapter.Fill(ds, "product");
                    }
                    if (string.IsNullOrEmpty(txt.Text))
                    {
                        ds.Tables["product"].Clear();
                        dataAdapter = new OleDbDataAdapter("select * from tbl_Product where Pro_ID = 0", access);
                        dataAdapter.Fill(ds, "product");

                    }


                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }

        }

        private void dataGridPro_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            update.Visible = false;
            panel2.Visible = false;
            panel1.Visible = true;
            btnsavepro.Visible = false; ;
            btnnewpro.Visible = false; ;
            btncancelpro.Visible=!false;
            btneditpro.Visible=true;
            btndeletepro.Visible=false;
            dataGridPro.Visible=false;
            button1.Visible = false;
            type.Visible = true;
            int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridPro.Rows[rowIndex];
                proID.Text = row.Cells[0].Value.ToString();
                proname.Text = row.Cells[1].Value.ToString();
                type.Text = row.Cells[3].Value.ToString();
                proPrice.Text = row.Cells[2].Value.ToString();
                Quantity.Text = row.Cells[4].Value.ToString();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            button1.Visible = false;
            btnsavepro.Visible = true;
            btneditpro.Visible = false;
            comboBox1.Visible = true;
            type.Visible = false;
            proID.ReadOnly = !true;
            proname.ReadOnly = !true;
            type.ReadOnly = !true;
            proPrice.ReadOnly = !true;
            Quantity.ReadOnly= !true;
            btncancelpro.Visible = true;
            btnnewpro.Visible = !true;
            btndeletepro.Visible = false;
            proID.Text = "";
            proname.Text = "";
            type.Text = "";
            proPrice.Text = "";
            Quantity.Text = "";
            comboBox1.Text = null;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (checkOne.Checked)
            {
                int s;
                bool a = int.TryParse(textBox1.Text, out s);
                if (textBox1.Text != "" && a)
                {
                    SearchFromCheckbox(textBox1, checkOne, "Select * from tbl_Product Where Pro_ID=" + s + "");
                    dataGridPro.DataSource = (ds.Tables["product"]);
                }
                else
                {
                    ds.Tables["product"].Clear();
                    dataAdapter = new OleDbDataAdapter("Select * from tbl_Product", access);
                    dataAdapter.Fill(ds, "product");
                }

            }
            if (checkTwo.Checked)
            {
                if (textBox1.Text != "")
                {
                    SearchFromCheckbox(textBox1, checkTwo, "Select * from tbl_Product Where Pro_Name like'%" + textBox1.Text + "%'");
                    dataGridPro.DataSource = (ds.Tables["product"]);
                }
                else
                {
                    ds.Tables["product"].Clear();
                    dataAdapter = new OleDbDataAdapter("Select * from tbl_Product", access);
                    dataAdapter.Fill(ds, "product");
                }
            }
            if (checkThree.Checked)
            {
                int s;
                bool a = int.TryParse(textBox1.Text, out s);
                if (textBox1.Text != "" && a)
                {
                    SearchFromCheckbox(textBox1, checkThree, "Select * from tbl_Product Where Type=" + s + "");
                    dataGridPro.DataSource = (ds.Tables["product"]);
                }
                else
                {
                    ds.Tables["product"].Clear();
                    dataAdapter = new OleDbDataAdapter("Select * from tbl_Product", access);
                    dataAdapter.Fill(ds, "product");
                }
            }


        }

        private void btnsavepro_Click(object sender, EventArgs e)
        {
            access.Open();
            int a;
            bool check = int.TryParse(proID.Text, out a);
            if (check)
            {

                command = new OleDbCommand("Select Pro_ID from tbl_Product where Pro_ID=" + a + ";", access);
                OleDbDataReader r = command.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("There is  this Product ID already.");
                    textBox1.Focus();
                }
                else
                {
                    if (comboBox1.Text != "")
                    {
                        try
                        {
                            command = new OleDbCommand("Insert into tbl_Product (Pro_ID,Pro_Name,Price,Type,Quantityinstock) Values(" + a + " , '" + proname.Text + "'," + Convert.ToInt32(proPrice.Text) + "," + comboBox1.SelectedIndex + "," + Convert.ToInt32(Quantity.Text) + ") ", access);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Product added!");
                            panel1.Visible = false;
                            Product_Load(sender, e);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                            MessageBox.Show(ex.StackTrace);
                        }

                        
                    }
                    else
                    {
                        MessageBox.Show("Please provide a type to prooduct.");
                        comboBox1.Focus();
                    }


                    access.Close();
                }
                access.Close();
            }
            else
            {
                MessageBox.Show("Product ID is integer only!");
                textBox1.Focus();
            }
        }

        private void btndeletepro_Click(object sender, EventArgs e)
        {
            int a;
            bool convert = int.TryParse(proID.Text, out a);
            if (!convert)
            {
                MessageBox.Show("Please provide the ID");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this product?", "Confirm", MessageBoxButtons.YesNo);
                if (result==DialogResult.Yes)
                {
                    command = new OleDbCommand("Delete * from tbl_Product where Pro_ID=" + a + "", access);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product has deleted!");
                    access.Close();
                    Product_Load(sender, e);
                    
                }
            }
            access.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            access.Open();
            int a;
            bool check = int.TryParse(proID.Text, out a);
            if (check)
            {
                
                command = new OleDbCommand("Select Pro_ID from tbl_Product where Pro_ID=" + a + ";", access);
                OleDbDataReader r = command.ExecuteReader();
                string us = "";
                if (r.Read())
                {

                    command = new OleDbCommand("Select Pro_Name from tbl_Product where Pro_ID=" + a + ";", access);
                    r = command.ExecuteReader();
                    while (r.Read())
                    {
                        us = r[0].ToString();
                    }
                    DialogResult result;
                    result = MessageBox.Show("Are you sure to update product \"" + us + "\"?", "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (comboBox1.Text != "")
                        {
                            
                            command = new OleDbCommand("Update tbl_Product set Pro_ID=" + a + ",Pro_Name='" + proname.Text + "',Price=" + Convert.ToInt32(proPrice.Text) + ",Type=" + comboBox1.SelectedIndex + ",Quantityinstock="+Convert.ToInt32(Quantity.Text)+" where Pro_ID=" + a + ";", access);
                            command.ExecuteNonQuery();
                            result = MessageBox.Show("User has updated!");
                            panel1.Visible = false;
                            Product_Load(sender, e);
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
                    MessageBox.Show("There is not this Staff ID in Staff Information.");
                    textBox1.Focus();
                }
                access.Close();
            }
            else
            {
                MessageBox.Show("Product ID is integer only!");
                textBox1.Focus();
            }
            access.Close();
        }

        private void btnnewpro_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
