
using System;
using System.Text;
using System.Globalization;

class CSharp_Assignment
{
    static void Main()
    {
        //NumnerFormatInfo object

        CultureInfo Pound = new CultureInfo("en-Gb");
        NumberFormatInfo Euro = new CultureInfo("fr-FR").NumberFormat;
        double moNey;
        Console.WriteLine("Enter number to show with Pound currency symbol: ");
        moNey = double.Parse(Console.ReadLine());
        Console.WriteLine(moNey.ToString("C", Pound));
        Console.WriteLine("Enter number to show with Euro currency symbol: ");
        Console.OutputEncoding = Encoding.UTF8;
        moNey = double.Parse(Console.ReadLine());
        Console.WriteLine(moNey.ToString("C", Euro));


    }
}