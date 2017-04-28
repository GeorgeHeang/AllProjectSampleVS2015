using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarSignStringSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = $"{10}:{20} {"AM"}";
            Console.WriteLine(time);
            Console.ReadLine();
        }
    }
}
