using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class function
    {
        //list box

        //end list box

        //Lenght
        public static Decimal KmToHm(decimal km)
        {
            decimal conversion = km*10;
            return conversion;
        }
        public static Decimal KmToDkm(decimal km)
        {
            decimal conversion = km*100;
            return conversion;
        }
        public static Decimal KmTom(decimal km)
        {
            decimal conversion = km * 1000;
            return conversion;
        }
        public static Decimal KmToDm(decimal km)
        {
            decimal conversion = km * 10000;
            return conversion;
        }
        public static Decimal KmToCm(decimal km)
        {
            decimal conversion = km * 100000;
            return conversion;
        }
        public static Decimal KmToMm(decimal km)
        {
            decimal conversion = km * 1000000;
            return conversion;
        }
        public static Decimal KmToFoot(decimal km)
        {
            double conversion = Convert.ToDouble(km) * 3280.8399;
            return Convert.ToDecimal(conversion);
        }
        public static Decimal KmToMile(decimal km)
        {
            double conversion = Convert.ToDouble (km) * 0.621504; 
            return Convert.ToDecimal(conversion);
        }

        //endLenght
    }
}
