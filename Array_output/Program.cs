using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Array_output
{
    class Program
    {
        
        static void Main()
       {

            #region array_output

            //int []Item = {12,34,56,78,90};
            //int[] Price = {3,4,5,6,7};
            //int outputPrice=0; 
            //bool match = false;
            //again:
            //int userInput=Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < Item.Length; i++)
            //    if (userInput == Item[i])
            //    {
            //        match = true;
            //        outputPrice = Price[i];
            //    }
            //if (match == true)
            //{
            //    Console.WriteLine(userInput+" Price= " + outputPrice.ToString("C0"));
            //}
            //else
            //{
            //    Console.WriteLine("Item not found!");
            //}
            //Console.ReadKey();
            //Console.Clear();
            //goto again;
            #endregion
            string[] lines = File.ReadAllLines(@"C:\Users\George\Desktop\test.txt",Encoding.UTF8);
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }
            
            Console.ReadKey();
       }
    }
}
