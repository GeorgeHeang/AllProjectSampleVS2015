using System;       

namespace ConsoleNetworking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.Title = "Exercise";
            bool recalulate = true;
            do
            {
                HeaderofProgram();
                MessageAlert("\n                    1. S= 2^3 + 2^4 + 2^5 +...+2^n   \n                    2. S= 1 + 2/3 + 4/9 + 8/27+ ...  (n number to sum) ", ConsoleColor.Yellow, true);
                Console.Write(" \nPlease input a number of form to caculate : ");
                #region 1
                if (KeyPressed(new char[] { '1', '2' }) == '1')
                {
                    Console.Clear();
                    HeaderofProgram();
                    MessageAlert("\n                    1. S= 2^3 + 2^4 + 2^5 +...+2^n", ConsoleColor.Yellow, true);
                    again:
                    Console.Write(" \nPlease input an expononent of the power that is greater than 2: ");
                    ulong n;
                    string exponent = Console.ReadLine();
                    bool check = ulong.TryParse(exponent, out n);
                    if (check)
                    {
                        if (n < 3)
                        {
                            MessageAlert("**You have entered the exponent that is smaller than 3! Please enter again.**", ConsoleColor.Red, false);
                            goto again;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n                   S = {0}\n", SumPowerofTwo(3, n));
                        }
                    }


                    else
                    {
                        if (exponent == "")
                        {
                            MessageAlert("**You haven't entered the exponent! Please input again.**", ConsoleColor.Red, false);
                            goto again;
                        }
                        else
                        {
                            MessageAlert("**You have entered invalid number. Please input again.**", ConsoleColor.Red, false);
                            goto again;
                        }
                    }
                }
                #endregion
                #region 2
                else
                {
                    Console.Clear();
                    HeaderofProgram();
                    MessageAlert("\n                    2. S= 1 + 2/3 + 4/9 + 8/27+ ... (n number to sum)", ConsoleColor.Yellow, true);
                    again:
                    Console.Write(" \nPlease input a number to Calculate S : ");
                    ulong n;
                    string numbers = Console.ReadLine();
                    bool check = ulong.TryParse(numbers, out n);
                    if (check)
                    {
                        if (n <= 0)
                        {
                            MessageAlert("**You have entered the number that is smaller than 1! Please enter again.**", ConsoleColor.Red, false);
                            goto again;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            double sum = 0;
                            for (double i = 0; i < n; i++)
                            {
                                sum = sum + Math.Pow(2, i) * Math.Pow(3, n - 1 - i);
                            }
                            Console.Write("                   S = {0}/{1}", sum, Math.Pow(3, n - 1));
                            Console.WriteLine("\n                or S = {0}\n", (sum / Math.Pow(3, n - 1)));
                        }
                    }


                    else
                    {
                        if (numbers == "")
                        {
                            MessageAlert("**You haven't entered the number! Please input again.**", ConsoleColor.Red, false);
                            goto again;
                        }
                        else
                        {
                            MessageAlert("**You have entered invalid number. Please input again.**", ConsoleColor.Red, false);
                            goto again;
                        }
                    }
                }
                #endregion
                MessageAlert("Calculate again? (Y/N): ", ConsoleColor.Blue,false);
                if (char.ToUpper(KeyPressed(new char[] { 'Y', 'N' })) == 'N')
                    recalulate = false;
                else
                    Console.Clear();
            } while (recalulate);

            Console.ReadKey();
        }
        private static void HeaderofProgram()
        {
            MessageAlert("\n                                             Exercises", ConsoleColor.Red, true);
            Console.Write("                                            ");
            for (int i = 0; i < 11; i++)
            {
                Console.Write((char)61);
            }
            MessageAlert("\n                    Form : ", ConsoleColor.Magenta, true);
            Console.Write("                   ");
            for (int i = 0; i < 7; i++)
            {
                Console.Write((char)61);
            }
        }
        private static double SumPowerofTwo(double start, decimal lenght)
        {
            double SumofPowerofTwo = 0;
            do
            {
                SumofPowerofTwo = SumofPowerofTwo + Math.Pow(2, start);
                ++start;
            } while ((decimal)start <= lenght);
            return SumofPowerofTwo;
        }
        private static void MessageAlert(string Message, ConsoleColor color,bool NewLine)
        {
            Console.ForegroundColor = color;
            if (NewLine)
                Console.WriteLine(Message);
            else
                Console.Write(Message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        private static char KeyPressed(char[] arraychar)
        {
            ConsoleKeyInfo keypressed;
            bool valid = false;
            do
            {
                keypressed = Console.ReadKey();
                Console.WriteLine();
                if (Array.Exists(arraychar, ch => ch.Equals(Char.ToUpper(keypressed.KeyChar))))
                    valid = true;
            } while (!valid);
            return keypressed.KeyChar;

        }
    }
}
