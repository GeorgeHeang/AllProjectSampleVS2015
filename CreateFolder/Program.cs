using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.Xml.XPath;
namespace CreateFolder
{
    class Program
    {
        public static void Main(string[] args)
        {
            //int i = 1;
            //CreateFolder(@"C:\Users\George\AppData\Local\SpeechNU");
            XDocument SpeechCommand = XDocument.Load(@"C:\Users\George\Desktop\Commands.xml");
            //var file = File.ReadAllLines(@"C:\Users\George\Desktop\specch for exhibition V3\specch\specch\bin\Debug\Database\ConversationByUser\ConversationRESP.txt");
            //foreach (var item in file)
            //{
            //    bool a= AddCommand(SpeechCommand, "Answers", "Answer", item,"id", @"C: \Users\George\AppData\Local\SpeechNU\Conversation.xml");
            //    Console.WriteLine(a);
            //}
            //i = 1;
            //var anfile = File.ReadAllLines(@"C:\Users\George\Desktop\specch for exhibition V3\specch\specch\bin\Debug\Database\ConversationByUser\ConversationRESP.txt");
            //foreach (var item in anfile)
            //{
            //    AddCommand(SpeechCommand,"Answers","Answer",item,new XAttribute("id",i), @"C: \Users\George\AppData\Local\SpeechNU\Conversation.xml");
            //    i++;
            //}

            //var a = from c in SpeechCommand.Descendants("Question").Last().Attributes("id") select c;
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}
            //var b = (from c in SpeechCommand.Descendants("Question") select c.Attribute("id")).Count();

            // AddCommand(SpeechCommand, "Questions", "Question", "Are you thirsty", "id", @"C: \Users\George\AppData\Local\SpeechNU\Conversation.xml");

            //var file = File.ReadAllLines(@"C:\Users\George\Desktop\specch for exhibition V3\specch\specch\bin\Debug\Database\Command.txt");
            //foreach (var item in file)
            //{
            //    Console.WriteLine(AddCommand(SpeechCommand, "NormalCommands", "Command", item, "id", @"C:\Users\George\AppData\Local\SpeechNU\Commands.xml"));
            //}
            //var a = (from c in SpeechCommand.Descendants("Question") where c.Attribute("id").Value == "1" select c.Value).Single();
            //Console.WriteLine(a);
            //var b = (from c in SpeechCommand.Descendants("Question") where c.Value == "how are you" select c.Attribute("id").Value).Single();
            //Console.WriteLine(b);
            //string[] w = { "hello","hi","damn","bitch"};
            //int i = Array.FindIndex(w, j => j.ToString() == "bitch");
            //Console.WriteLine(i);

            //Console.WriteLine(RemoveCommand(SpeechCommand,"Question","will you marry me", @"C:\Users\George\AppData\Local\SpeechNU\Commands.xml"));



            //SpeechCommand.XPathSelectElement("Commands/Questions/Question[@id = '6']").Remove();
            //SpeechCommand.XPathSelectElement("Commands/Answers/Answer[@id = '6']").Remove();
            //var count = (from s in SpeechCommand.Descendants("Question") select s).Count();
            //Console.WriteLine(count);
            //var element = from s in SpeechCommand.Descendants("Question") select s;
            //int i = 1;
            //foreach (var item in element)
            //{
            //    item.SetAttributeValue("id", i);
            //    i++;
            //}
            //SpeechCommand.Save(@"C:\Users\George\Desktop\Commands.xml");

            String[] XPathSelectElement = { "Commands", "Questions", "Question" };
            Console.WriteLine(RemoveCommandWithAtrributeValue(SpeechCommand, "who are you", @"C:\Users\George\Desktop\Commands.xml", "id", XPathSelectElement)); 
            //bool Exist = false;
            //var ExistCommand = from commands in SpeechCommand.Descendants("Question") where commands.Value == "ilo" select commands.Value;
            //foreach (var command in ExistCommand)
            //{
            //    if ("ilo" == command)
            //    {
            //        Exist = true;
            //        break;
            //    }
            //}
            //if (Exist)
            //{
            //    RemoveCommandWithAtrributeValue(SpeechCommand, "how are you", @"C:\Users\George\Desktop\Commands.xml", "id", XPathSelectElement);
            //    SpeechCommand.Save(@"C:\Users\George\Desktop\Commands.xml");
            //}
            //else
            //{
            //    Console.WriteLine("fuck");
            //}


        }






        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }


        //Create Folder
        public static void CreateFolder(String PathFolder)

        {
            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(PathFolder))
                {
                    Console.WriteLine("This path exists already.");
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(PathFolder);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(PathFolder));

                // Delete the directory.
                //  di.Delete();
                // Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }

        }


        /// <summary>
        /// Add a new command to the xml file and return true if the command isn't exist otherwise return false.
        /// </summary>
        /// <param name="XmlFile">The Xml file that the command will be written to.</param>
        /// <param name="RootCommand">The root element of the last element.</param>
        /// <param name="ElementCommand">The last element that contain the command text.</param>
        /// <param name="CommandText">The text that use to insert to xml file as ElementCommand content.</param>
        /// <param name="Attribute">The name of the attribute will be create as ElementCommand attribute.</param>
        /// <param name="Path">The path to the Xml file with full filename and extension if file is exist the file will update, otherwise it will create the new file with file name you provide.</param>
        /// <returns>Add a new command to the xml file and return true if the command isn't exist otherwise return false.</returns>
        public static bool AddCommand(XDocument XmlFile,String RootCommand, String ElementCommand, String CommandText, String Attribute,String Path)
        {
            bool Exist = false;
            var id = (from ids in XmlFile.Descendants(ElementCommand) select ids.Attribute(Attribute)).Count();
            var ExistCommand = from commands in XmlFile.Descendants(ElementCommand) where commands.Value == CommandText select commands.Value;
            foreach (var command in ExistCommand)
            {
                if (CommandText==command)
                {
                    Exist = true;
                    break;
                }
            }
            if (!Exist)
            {
                XmlFile.Root.Element(RootCommand).Add(new XElement(ElementCommand,new XAttribute(Attribute,++id), CommandText));
                XmlFile.Save(Path);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Create Xml file with specify folder and return true if the creation succuss, otherwise return false.
        /// </summary>
        /// <param name="Path">The destination to create the Xml file.</param>
        /// <param name="Filename">The name of the Xml file.</param>
        /// <param name="XmlElement">New XElement to fill the Xml file.</param>
        /// <returns>Return true if the creation is successful, otherwise return false.</returns>
        public static bool CreateXmlFile(String Path, String Filename, XElement XmlElement)
        {
            string PathWithFilename = Path + "\\" + Filename + ".xml";
            if (!System.IO.File.Exists(PathWithFilename))
            {
                XDocument XmlFile = new XDocument(XmlElement);
                XmlFile.Save(PathWithFilename);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Remove a command from the xml file and return true if the process success otherwise return false.
        /// </summary>
        /// <param name="XmlFile">The Xml file that the command will remove.</param>
        /// <param name="CommandText">The commandText that will be removing.</param>
        /// <param name="Path">The path to the Xml file with full filename and extension if file is exist the file will update.</param>
        /// <param name="AttributeName">The name of the attribute of the CommandText element.</param>
        /// <param name="ElementInOrder">The array that present the Root of Xml element in order.</param>
        /// <returns>Remove a command from the xml file and return true if the process success otherwise return false.</returns>
        public static bool RemoveCommandWithAtrributeValue(XDocument XmlFile, String CommandText, String Path, String AttributeName, String[] ElementInOrder)
        {
            bool Exist = false;
            string LastElement = null;
            string SelectedElement = null;
            foreach (var item in ElementInOrder)
            {
                SelectedElement += item + ("/");
                LastElement = item;
            }
            SelectedElement = SelectedElement.Remove(SelectedElement.Length - 1, 1);
            var ExistCommand = from commands in XmlFile.Descendants(LastElement) where commands.Value == CommandText select commands.Value;
            foreach (var item in ExistCommand)
            {
                if (item==CommandText)
                {
                    Exist = true;
                    break;
                }
            }

            if (Exist)
            {
                var id = (from ids in XmlFile.Descendants(LastElement) where ids.Value == CommandText select ids.Attribute(AttributeName).Value).Single();
                SelectedElement += "[@" + AttributeName + "= '" + id + "']";
                XmlFile.XPathSelectElement(SelectedElement).Remove();
                var count = (from s in XmlFile.Descendants(LastElement) select s).Count();
                var element = from s in XmlFile.Descendants(LastElement) select s;
                int i = 1;
                foreach (var item in element)
                {
                    item.SetAttributeValue("id", i);
                    i++;
                }
                XmlFile.Save(Path);
                return true;

            }
            return false;

        }


    }
}
