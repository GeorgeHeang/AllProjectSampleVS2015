using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] scOres = {0,1,2,3,4,5,6,7,8,9};
            //for (int i = 0; i<10; i++)
            //{
            //    Console.WriteLine((scOres[i] + 3).ToString("C0"));
            //}
            //Array.Sort(scOres);
            //foreach (var item in scOres)
            //{
            //    Console.WriteLine(item);
            //}
            //Array.Sort(scOres);
            //Array.Reverse(scOres);
            //foreach (var item in scOres)
            //{
            //    Console.WriteLine(item);
            //}
            again:
            int[] ID = {101,212,316,808};
            int[] prIces = { 25, 30, 10, 15 };
            int seArch;
            seArch = int.Parse(Console.ReadLine());
            for (int i = 0; i < 4;)
            {
                
                if (seArch == ID[i])
                {
                    Console.WriteLine(ID[i] + " Prices=" + prIces[i].ToString("C0"));
                    break;
                }
                else
                {
                    i++;
                }
            }

            for (int i = 0; i < ID.Length;)
            {
                if (seArch != ID[i])
                {
                    Console.WriteLine("Item not found!");
                    break;
                }
                else
                {
                    i++;
                }
                    
            }

            goto again;

        }
    }
}
