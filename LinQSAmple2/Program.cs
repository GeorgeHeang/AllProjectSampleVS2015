using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQSAmple2
{
    class Program
    {
        dtbStockSystemDataContext dtb = new dtbStockSystemDataContext();
        static void Main(string[] args)
        {
            Program i = new Program();
            i.ShowDataFromSQLbyLINQ();
        }
        private void ShowDataFromSQLbyLINQ()
        {
            var cust = from c in dtb.Customers select c;
            foreach (var item in cust)
            {
                Console.WriteLine(item);
            }
        }
    }
}
