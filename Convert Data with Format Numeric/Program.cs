using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using static System.Console;

namespace Convert_Data_with_Format_Numeric
{
    class Program
    {
        static void Main(string[] args)
        {

            NumberFormatInfo money = new CultureInfo("jp-JP").NumberFormat;
            decimal moNey;
            moNey=decimal.Parse(ReadLine());
            WriteLine(moNey.ToString("C",money));
          /*  money = decimal.Parse(ReadLine());
            WriteLine(money.ToString("C0"));
            money = decimal.Parse(ReadLine());
            WriteLine(money.ToString("C0"));
            Console.ReadKey();*/
        }
    }
}
