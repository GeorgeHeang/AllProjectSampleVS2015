using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Data.SqlClient;
using System.Windows.Input;
using System.Data;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Media;


namespace ConnectDatabaseWithNetwork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection Connection;
        SqlDataAdapter DataAdapter;
        DataSet Data;
        public MainWindow()
        {
            InitializeComponent();
            for (int i = DateTime.Now.Year; i > DateTime.Now.Year - 100; i--)
            {
                ComboBoxYear.Items.Add(i.ToString());
                ComboBoxYear.SelectedIndex = 0;
            }
            Connection = new SqlConnection(@"Server=DESKTOP-D8AG882\GEORGE;Database=School;User ID=sa; Password=123;");
        }
        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            switch (ToggleButtonShow.IsChecked)
            {
                case true:
                    GridTextBlockImageButtons.Visibility = Visibility.Visible;
                    break;
                case false:
                    GridTextBlockImageButtons.Visibility = Visibility.Collapsed;
                    break;
                default:
                    GridTextBlockImageButtons.Visibility = Visibility.Collapsed;
                    break;
            }
        }

        private void CheckBoxMale_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is CheckBox)
            {
                CheckBox a = sender as CheckBox;
                a.Foreground = Brushes.Blue;
                switch (a.Content.ToString())
                {
                    case "Male":
                        CheckBoxFemale.IsChecked = false;
                        CheckBoxFemale.Foreground = Brushes.Black;
                        break;
                    case "Female":
                        CheckBoxMale.IsChecked = false;
                        CheckBoxMale.Foreground = System.Windows.Media.Brushes.Black;

                        break;
                    default:
                        break;
                }
            }
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is TextBlock)
            {
                TextBlock t = sender as TextBlock;
                switch (ToggleStudentReg.IsChecked)
                {
                    case true:
                        t.Background = ToggleStudentReg.Background;
                        PanelStudentRegisteration.Visibility = Visibility.Collapsed;
                        ToggleStudentReg.IsChecked = false;
                        break;
                    case false:
                        t.Background = ToggleStudentReg.Background;
                        PanelStudentRegisteration.Visibility = Visibility.Visible;
                        ToggleStudentReg.IsChecked = true;
                        break;
                }
            }
        }

        private void ComboBox_GotFocus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Focus");
        }

        private void ToggleStudentReg_Checked(object sender, RoutedEventArgs e)
        {
            PanelStudentRegisteration.Visibility = Visibility.Visible;
            PanelStudentList.Visibility = Visibility.Collapsed;
        }

        private void ToggleStudentReg_Unchecked(object sender, RoutedEventArgs e)
        {
            PanelStudentRegisteration.Visibility = Visibility.Collapsed;
            PanelStudentList.Visibility = Visibility.Visible;
        }

        private void ComboBoxYear_LostFocus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((sender as ComboBox).Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tbSurname.Text!=""||tbName.Text!="")
            {
                string Sex="";
                if (CheckBoxFemale.IsChecked == false && CheckBoxMale.IsChecked == false)
                {
                    MessageBox.Show("Please check Sex.");
                }
                else
                {


                    if (CheckBoxFemale.IsChecked == true)
                    {
                        Sex = CheckBoxFemale.Content.ToString();
                    }
                    else
                        Sex = "Male";
                    try
                    {
                        SqlCommand Command = new SqlCommand("Insert into TableStudent values('" + tbSurname.Text + "','" + tbName.Text + "','" + Sex + "','" + ComboBoxDay.Text + "-" + ComboBoxMonth.Text + "-" + ComboBoxYear.Text + "','" + tbAddress.Text + "','" + tbPhone.Text + "','" + cbMajor.Text + "');", Connection);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        Connection.Close();
                        MessageBox.Show("Student registered.");
                        ToggleStudentReg.IsChecked = false;
                        PanelStudentList.Visibility = Visibility.Visible;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    tbAddress.Clear();
                    tbName.Clear();
                    tbPhone.Clear();
                    tbSurname.Clear();
                    cbMajor.SelectedItem = null;
                    CheckBoxFemale.IsChecked = false;
                    CheckBoxMale.IsChecked = false;


                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                DataAdapter = new SqlDataAdapter("Select * from TableStudent;", Connection);
                Data = new DataSet();
                DataAdapter.Fill(Data, "TableStudent");
                Datagrid.ItemsSource = Data.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
