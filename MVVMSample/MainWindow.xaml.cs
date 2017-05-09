using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows;
using MVVMSample.Properties;

namespace MVVMSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SearchPatientsViewModel v = new SearchPatientsViewModel();
            this.DataContext=v;
        }
    }
    public static class IndradhanuDatabase
    {
        public static string ConnectionString { get { return Settings.Default.ConnectionString; } }

        public static List<SearchPatientsModel> GetPatients()
        {
            using(var connection = new SqlConnection(ConnectionString))
            {
                using(var command = new SqlCommand("select top 20 SN,Name,Sex,Dob,Age,DoR,fName,mName,Phone,[Address],Complain from [tbl_Registration] order by SN desc;", connection))
                {
                    List<SearchPatientsModel> patients = new List<SearchPatientsModel>();
                    connection.Open();
                    try
                    {
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                SearchPatientsModel patient = new SearchPatientsModel
                                {
                                    SN = reader.GetInt32(0)
                                };
                            }
                            return patients;
                        }
                    }
                    catch(System.Exception ex)
                    {
                        throw ex;
                    }

                }
            }
        }
    }
    public class SearchPatientsModel : NotifyPropertyChanged
    {
        private int _SN;

        public int SN
        {
            get { return _SN; }
            set { _SN = value; OnPropertyChanged(nameof(SN)); }
        }
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; OnPropertyChanged(nameof(Name)); }
        }
        private string _Sex;

        public string Sex
        {
            get { return _Sex; }
            set { _Sex = value; OnPropertyChanged(nameof(Sex)); }
        }

        private DateTime _DateOfBirth;

        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; OnPropertyChanged(nameof(DateOfBirth)); }
        }

        private string _Age;

        public string Age
        {
            get { return _Age; }
            set { _Age = value; OnPropertyChanged(nameof(Age)); }
        }
        private DateTime _DateOfRegistration;

        public DateTime DateOfRegistration
        {
            get { return _DateOfRegistration; }
            set { _DateOfRegistration = value; OnPropertyChanged(nameof(DateOfRegistration)); }
        }
        private string _Father;

        public string Father
        {
            get { return _Father; }
            set { _Father = value; OnPropertyChanged(nameof(Father)); }
        }
        private string _Mother;

        public string Mother
        {
            get { return _Mother; }
            set { _Mother = value; OnPropertyChanged(nameof(Mother)); }
        }
        private string _Phone;

        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        private string _Address;

        public string Address
        {
            get { return _Address; }
            set { _Address = value; OnPropertyChanged(nameof(Address)); }
        }
        private string _Complain;

        public string Complain
        {
            get { return _Complain; }
            set { _Complain = value; OnPropertyChanged(nameof(Complain)); }
        }
    }
    public class NotifyPropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
    public class SearchPatientsViewModel : NotifyPropertyChanged
    {
        private List<SearchPatientsModel> _Patients;
        public List<SearchPatientsModel> Patients
        {
            get { return _Patients; }
            set { _Patients = value; OnPropertyChanged(nameof(Patients)); }
        }
        public SearchPatientsModel SelectedPatient { get; set; }
        public SearchPatientsViewModel()
        {
            Patients = IndradhanuDatabase.GetPatients();
        }
    }
}
