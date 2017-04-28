using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Checked = true;
            do
            {
                Console.Write("Text test\n\n ");
                Console.Write("Enter text: ");
                string Result = GetValidText();
                Console.Write(Result);
                //Checked = false;
            } while (Checked);
        }

        static string GetValidText()
        {
            bool control = false;
            string text;
            do
            {
                text=Console.ReadLine();
                if (text == null)
                    control = true;
            } while (!control);
            return text ;
        }
    }
}
 