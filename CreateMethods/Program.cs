using System;

namespace CreateMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enater number: ");
            int number=Convert.ToInt32(Console.ReadLine());
            // Showmulyiply(number);
            for (int i = 1; i < 11; i++)
            {
                int result = ShowMultiply(number, i);
                Console.WriteLine(number + "*" + i + " = " + result);
            }

        }
        private static void Showmulyiply(int number)
        {
            for (int i = 1; i <= 10; i++)
            {
                int multiply = number * i;
                Console.WriteLine(number+ "*"+ i+" = "+multiply );

            }
        }
        private static int ShowMultiply(int number,int i)
        {
            int result;
            result = number * i;
            return result;
        }
    }
    
}
