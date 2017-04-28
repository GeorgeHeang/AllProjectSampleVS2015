using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrayItems
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] Number = { 3, 1, 4, 9, 7 };
            CompareNumbrInArray(Number);
        }
        private static void CompareNumbrInArray(int[] array)
        {
            for (int i = 0; i<array.Length ; i++)
            {
                int max;
                if (array[i] > array[i + 1])
                {
                    max = array[i];
                }
                else
                    max = array[i + 1];
                Console.WriteLine("Max= " + max);
            }
        }
    }
}
