using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.ComponentModel;

namespace ConnectDatabaseWithNetwork
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        SqlConnection Connection;
        public LogIn()
        {
            InitializeComponent();
        }
#region ServerConnected
        public string[] ServerName()
        {
            string[] strIP = DisplayIPAddresses();
            int CountIP = 0;
            for (int i = 0; i < strIP.Length; i++)
            {
                if (strIP[i] != null)
                    CountIP++;
            }
            string[] name = new string[CountIP];
            for (int i = 0; i < strIP.Length; i++)
            {
                if (strIP[i] != null)
                {
                    try
                    {
                        name[i] = System.Net.Dns.GetHostEntry(strIP[i]).HostName;
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            return name;
        }


        public string[] DisplayIPAddresses()
        {
            StringBuilder sb = new StringBuilder();
            // Get a list of all network interfaces (usually one per network card, dialup, and VPN connection)     
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            int i = -1;
            string[] s = new string[networkInterfaces.Length];

            foreach (NetworkInterface network in networkInterfaces)
            {
                i++;
                if (network.OperationalStatus == OperationalStatus.Up)
                {
                    if (network.NetworkInterfaceType == NetworkInterfaceType.Tunnel) continue;
                    if (network.NetworkInterfaceType == NetworkInterfaceType.Tunnel) continue;
                    //GatewayIPAddressInformationCollection GATE = network.GetIPProperties().GatewayAddresses;
                    // Read the IP configuration for each network   

                    IPInterfaceProperties properties = network.GetIPProperties();
                    //discard those who do not have a real gateaway 
                    if (properties.GatewayAddresses.Count > 0)
                    {
                        bool good = false;
                        foreach (GatewayIPAddressInformation gInfo in properties.GatewayAddresses)
                        {
                            //not a true gateaway (VmWare Lan)
                            if (!gInfo.Address.ToString().Equals("0.0.0.0"))
                            {
                                s[i] = gInfo.Address.ToString();
                                good = true;
                                break;
                            }
                        }
                        if (!good)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return s;
        }


#endregion

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonConnectClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            this.IsEnabled = false;
            try
            {
                button.IsEnabled = false;
                ConnectionToSQL.ConnectionString = "Server=" + tbServer.Text + ";Database=School; User ID=" + tbUserID.Text + "; Password=" + tbPassword.Password + ";";
                Connection = new SqlConnection(ConnectionToSQL.ConnectionString);
                SqlCommand Command = new SqlCommand("Select 1;", Connection);
                Connection.Open();
                if ((int)Command.ExecuteScalar()==1)
                {
                   // MessageBox.Show(ConnectionToSQL.ConnectionString);
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Faild to connect, cause " + ex.Message);
                button.IsEnabled = true;
                this.IsEnabled = true;
            }
            finally
            {
                Connection.Close();
            }
            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (!(tbServer.Text=="" || tbPassword.Password=="" || tbUserID.Text==""))
            {
                if (File.Exists("Data.dat"))
                {
                    File.Delete("Data.dat");
                }
                else
                {
                    File.Create("Data.dat");
                }
                using (FileStream f = File.Create("Data.dat"))
                {
                    AddText(f, ConnectionToSQL.ConnectionString);
                }
            }
            
            GC.KeepAlive(ConnectionToSQL.ConnectionString);
            
        }
        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
        private void ComboBoxServerName_GotFocus(object sender, RoutedEventArgs e)
        {
            ComboBoxServerName.ItemsSource= ServerName();
        }
    }

    public static class ConnectionToSQL
    {
        public static string ConnectionString;
    }
}
