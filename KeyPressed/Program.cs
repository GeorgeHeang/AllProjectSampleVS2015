using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPressed
{
    class Program
    {
        static void Main(string[] args)
        {

            bool doagain = true;
            do
            {
                Char texttodisplay = KeyPressed("Choose a charater to display text (a,b or c): ", new Char[] { 'A', 'B', 'C' });
                char a = char.ToUpper(texttodisplay);
                Console.WriteLine();
                switch (a)
                {
                    case 'A': Console.Write(" Case A"); break;
                    case 'B': Console.Write("Case B"); break;
                    case 'C': Console.Write("Case c"); break;
                }
                if (char.ToUpper(KeyPressed("\nDisplay again(Y/N): ", new char[] { 'Y', 'N' })) == 'N')
                    doagain = false;
                Console.WriteLine();

            } while (doagain);
        }

        private static char KeyPressed(string message, char[] arraychar)
        {
            ConsoleKeyInfo keypressed;
            bool valid = false;
            do
            {
                Console.Write(message);
                keypressed = Console.ReadKey();
                Console.WriteLine();
                if (Array.Exists(arraychar, ch => ch.Equals(Char.ToUpper(keypressed.KeyChar))))
                    valid = true;
            } while (!valid);
            return keypressed.KeyChar;

        }
    }
}
