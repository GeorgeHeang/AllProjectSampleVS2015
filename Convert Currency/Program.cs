using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace Convert_Currency
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo Euro = new CultureInfo("fr-FR");
            NumberFormatInfo Pound = new CultureInfo("en-GB").NumberFormat;


            double dollarMoney, poundMoney, euroMoney, poundRate, euroRate;
            Console.WriteLine("Please Enter money in $:");
            dollarMoney = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input Euro Rate:");
            euroRate = double.Parse(Console.ReadLine());
            euroMoney = euroRate * dollarMoney;
            Console.WriteLine("Please input Pound Rate:");
            poundRate = double.Parse(Console.ReadLine());
            poundMoney = poundRate * dollarMoney;
            Console.OutputEncoding = Encoding.UTF7;
            Console.WriteLine("Euro Money=" +euroMoney.ToString("C",Euro) + "\nPound Money="+ poundMoney.ToString("C"),Pound);












        }
    }
}
