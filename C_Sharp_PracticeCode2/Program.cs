using System;
namespace ArrayDemo
{
    class arrayOutput
    {
        public static void Main()
        {
            bool chEck = true;
            do
            {
                int[] arrayDemo = { 10, 20, 30, 40, 50, 60, 70, 80 };
                string o1=("Choose an Option below:\n(1) to view the list in order from the first to last index of array.");
                string o2=("\n(2) to view the list in order from the last to first index of array.");
                string o3=("\n(3) to view the specific index of array.");
                char opTion = GetKeyPress(o1+o2+o3+"\nOption: ", new Char[] { '1', '2', '3' });
                switch (opTion)
                {
                    case '1':
                        printIndexftol(arrayDemo);
                        chEck = false;
                        break;
                    case '2':
                        printIndexfromLtof(arrayDemo);
                        chEck = false;
                        break;
                    case '3':
                        printSpecificindex(arrayDemo);
                        chEck = false;
                        break;
                }
            } while (chEck);
        }
        private static Char GetKeyPress(String msg, Char[] validChars)
        {
            ConsoleKeyInfo keyPressed;
            bool valid = false;
            Console.WriteLine();
            do
            {
                Console.Write(msg);
                keyPressed = Console.ReadKey();
                Console.WriteLine();
                if (Array.Exists(validChars, ch => ch.Equals(keyPressed.KeyChar)))
                    valid = true;
                else
                {
                    Console.Write("\nInvalid option!\n\n");
                    valid = false;
                }


            } while (!valid);
            return keyPressed.KeyChar;
        }
        private static void printIndexftol(int[] number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
        }
        private static void printIndexfromLtof(int[] number)
        {
            Array.Reverse(number);
            printIndexftol(number);
        }
        private static void printSpecificindex(int[] number)
        {
            bool chEck2 = false;
            do
            {
                int inDex;
                bool checkIndex = int.TryParse(GetKeyPress("\nEnter the number of index:").ToString(), out inDex);
                bool indexCheck = false;
                int outputIndex = 0;
                if (checkIndex)
                {
                    for (int i = 0; i < number.Length; i++)
                        if (inDex == i)
                        {
                            indexCheck = true;
                            outputIndex = number[i];
                        }
                    if (indexCheck)
                    {
                        Console.WriteLine(outputIndex);
                        Console.WriteLine();
                        chEck2 = false;
                    }
                    else
                    {
                        Console.Write("Index is not in array range.\n");
                        chEck2 = true;
                    }

                }
                else
                {
                    Console.Write("\nInvalid index!\n");
                    chEck2 = true;
                }

            } while (chEck2);
        }
        private static Char GetKeyPress(string msg)
        {
            Console.Write(msg);
            ConsoleKeyInfo keyPressed;
            keyPressed = Console.ReadKey();
            Console.WriteLine();
            return keyPressed.KeyChar;
        }
    }
}