using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Xml;
using System.IO;
using System.IO.IsolatedStorage;
using System.Xml.Linq;

namespace LINGtoXML
{
    class Program
    {
        private const string SettingFile = "ApplicationSettings.xml";
        static void Main(string[] args)
        {
            #region a         
            //var xml = new XDocument(new XDeclaration("1.0", "UTF-8", ""),
            //                        new XElement("appsetting", new XElement("single", new XElement("isred", "true"),
            //                                                                          new XElement("islong", "true"),
            //                                                                          new XElement("isbig", "true"),
            //                                                                          new XElement("isbad", "true"),
            //                                                                          new XElement("isadorable", "true")),
            //                                                   new XElement("collection", new XElement("maillist", new XElement("mail", "qwerty@gamil.com"),
            //                                                                                                       new XElement("mail", "asdfg@gmail.com"),
            //                                                                                                       new XElement("mail", "zxcvbn@gmail.com")))));
            //xml.Root.Element("collection").Element("maillist").Add(new XElement("mail", "asd"));
            //xml.Save(@"D:\" + SettingFile);


            //using (var isolate = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
            //{
            //    using (var fstream = new IsolatedStorageFileStream(SettingFile, FileMode.Create, isolate))
            //    {
            //        using (var writer = new StreamWriter(fstream))
            //        {
            //            xml.Save(writer);
            //        }
            //    }
            //}
            using (IsolatedStorageFile isolate = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
            {
                try
                {
                    using (var fstream = new IsolatedStorageFileStream(SettingFile, FileMode.Open, isolate))
                    {
                        XDocument setting = null;
                        using (var reader = new StreamReader(fstream))
                        {
                            setting = XDocument.Load(reader);
                            var maillist = from m in setting.Descendants("mail") select m.Value;
                            ObservableCollection<string> mail = new ObservableCollection<string>(maillist);
                            IEnumerable<string> a = mail.AsEnumerable();
                            foreach (var item in a)
                            {
                                Console.WriteLine(item);
                            }
                            var c = (from b in setting.Descendants("mail") where b.Value == "asd" select b).Single();
                            c.Value = Console.ReadLine();
                            Console.WriteLine(setting);
                        }
                        using (var stream = new IsolatedStorageFileStream(SettingFile, FileMode.Create, isolate))
                        {
                            using (var writer = new StreamWriter(stream))
                            {
                                setting.Save(writer);
                            }
                        }
                    }
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            #endregion
        }
    }
}
