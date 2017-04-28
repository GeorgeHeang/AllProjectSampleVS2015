using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.IO.IsolatedStorage;
using System.Runtime.CompilerServices;
using System.Windows;
namespace EmbedSettingWithJSON
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private const string settingFilename = "setting.json";
        private Setting appSetting;
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string PropertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        public Setting AppSetting
        {
            get { return appSetting; }
            set { appSetting = value; OnPropertyChanged(); }
        }

        public MainWindow()
        {
            AppSetting = GetSetting();
            InitializeComponent();
        }



        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }


        private Setting GetSetting()
        {
            Setting s = new Setting();
            using (var isoFile = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
            {
                try
                {
                    using (var stream = new IsolatedStorageFileStream(settingFilename, System.IO.FileMode.Open))
                    {
                        using (var reader = new StreamReader(stream))
                        {
                            var json = reader.ReadToEnd();
                            if (json != "null")
                                s = JsonConvert.DeserializeObject<Setting>(json);
                        }
                    }
                }
                catch (Exception)
                {
                    return s;
                }

            }
            return s;
        }
        private void SaveSetting()
        {
            using (var isoFile = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
            {
                using (var stream = new IsolatedStorageFileStream(settingFilename, FileMode.Create))
                {
                    using (var writer = new StreamWriter(stream))
                    {
                        var json = JsonConvert.SerializeObject(AppSetting);
                        writer.Write(json);
                    }
                }
            }
        }

        private void CbIsRed_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(AppSetting.IsRed.ToString());
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            SaveSetting();
            base.OnClosing(e);
        }
    }
}
