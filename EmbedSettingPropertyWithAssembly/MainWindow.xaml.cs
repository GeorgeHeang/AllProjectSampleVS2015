using System;
using System.ComponentModel;
using System.IO;
using System.IO.IsolatedStorage;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Linq;
using System.Xml.Linq;
using System.Collections.ObjectModel;

namespace EmbedSettingPropertyWithAssembly
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private const string SettingFile = "ApplicationSettings.xml";
        private bool isRed;
        private bool isLong;
        private bool isBig;
        private bool isBad;
        private bool isAdorable;
        private ObservableCollection<String> mailList;
        private XDocument setting;

        public bool IsRed
        {
            get
            {
                return this.isRed;
            }
            set
            {
                this.isRed = value;
                this.OnPropertyChanged<bool>();
            }
        }
        public bool IsLong
        {
            get
            {
                return this.isLong;
            }
            set
            {
                this.isLong = value;
                this.OnPropertyChanged<bool>();
            }
        }
        public bool IsBig
        {
            get
            {
                return this.isBig;
            }
            set
            {
                this.isBig = value;
                this.OnPropertyChanged<bool>();
            }
        }
        public bool IsBad
        {
            get
            {
                return this.isBad;
            }
            set
            {
                this.isBad = value;
                this.OnPropertyChanged<bool>();
            }
        }
        public bool IsAdorable
        {
            get
            {
                return this.isAdorable;
            }
            set
            {
                this.isAdorable = value;
                this.OnPropertyChanged<bool>();
            }
        }
        public ObservableCollection<string> MailList
        {
            get
            {
                return this.mailList;
            }
            set
            {
                mailList = value;
                this.OnPropertyChanged<ObservableCollection<string>>();
            }
        }

        /// <summary>
        /// Helper function for INotifyPropertyChanged interface 
        /// </summary>
        /// <typeparam name="T">Property type</typeparam>
        /// <param name="caller">Property name</param>
        private void OnPropertyChanged<T>([CallerMemberName]string caller = null)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(caller));
            }
        }

        public MainWindow()
        {
            GetSetting();
            InitializeComponent();
            InitializeProperty();
        }
        /// <summary>
        /// InitializeSetting
        /// </summary>
        private void InitializeProperty()
        {
            this.IsRed = GetIsRedProperty();
            this.IsBig = GetIsBigProperty();
            this.IsLong = GetIsLongroperty();
            this.IsBad = GetIsBadProperty();
            this.IsAdorable = GetIsAdorableProperty();
            this.MailList = GetMailListProperty();
        }
        /// <summary>
        /// Get isadorable from file
        /// </summary>
        /// <returns>Get IsAdorable Property</returns>
        private bool GetIsAdorableProperty()
        {
            bool ad = false;
            bool.TryParse((from a in setting.Descendants("isadorable") select a.Value).Single(), out ad);
            return ad;
        }

        private bool GetIsBadProperty()
        {
            bool ad = false;
            bool.TryParse((from a in setting.Descendants("isbad") select a.Value).Single(), out ad);
            return ad;
        }

        private bool GetIsLongroperty()
        {
            bool ad = false;
            bool.TryParse((from a in setting.Descendants("islong") select a.Value).Single(), out ad);
            return ad;
        }

        private bool GetIsBigProperty()
        {
            bool ad = false;
            bool.TryParse((from a in setting.Descendants("isbig") select a.Value).Single(), out ad);
            return ad;
        }

        private ObservableCollection<string> GetMailListProperty()
        {
            return GetMailListFromFile();
        }

        private bool GetIsRedProperty()
        {
            string b = (from a in setting.Descendants("isred") select a.Value).Single();
            bool r = false;
            bool.TryParse(b, out r);
            return r;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (_tbEmail.Text != "")
            {
                this.MailList.Add(_tbEmail.Text);
                _tbEmail.Clear();
            }
        }

        private void _lbEmailSub_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (_lbEmailSub.SelectedItem != null)
                MailList.Remove(_lbEmailSub.SelectedItem.ToString());
        }

        private ObservableCollection<string> GetMailListFromFile()
        {

            var maillist = from m in setting.Descendants("mail") select m.Value;
            ObservableCollection<string> mail = new ObservableCollection<string>(maillist);
            return mail;
        }
        /// <summary>
        /// Get setting frm xml
        /// </summary>
        private void GetSetting()
        {
            using (IsolatedStorageFile isoloate = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
            {
                try
                {
                    using (var fstream = new IsolatedStorageFileStream(SettingFile, FileMode.Open, isoloate))
                    {
                        using (var reader = new StreamReader(fstream))
                        {
                            setting = XDocument.Load(reader);
                        }
                    }
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Save setting
        /// </summary>                    
        private void SaveSetting()
        {
            var xml = new XDocument(new XDeclaration("1.0", "UTF-8", ""),
                                    new XElement("appsetting", new XElement("single", new XElement("isred", IsRed),
                                                                                      new XElement("islong", IsLong),
                                                                                      new XElement("isbig", IsBig),
                                                                                      new XElement("isbad", IsBad),
                                                                                      new XElement("isadorable", IsAdorable)),
                                                               new XElement("collection", new XElement("maillist"))));

            //Add mail list
            if (MailList != null)
                foreach (var item in MailList)
                {
                    xml.Root.Element("collection").Element("maillist").Add(new XElement("mail", item));
                }
            //Save to IsolatedFile
            using (var isolate = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
            {
                using (var fstream = new IsolatedStorageFileStream(SettingFile, FileMode.Create, isolate))
                {
                    using (var writer = new StreamWriter(fstream))
                    {
                        xml.Save(writer);
                    }
                }
            }

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            SaveSetting();
        }
    }
}
