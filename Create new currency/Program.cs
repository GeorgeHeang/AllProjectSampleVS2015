using System;
using System.Globalization;
using System.Threading;

public class EuroLocalSample
{
    public static void Main()
    {
        // Creates a CultureInfo for French in France.
        CultureInfo FrCulture = new CultureInfo("fr-FR");
        // Sets the CurrentCulture to fr-FR.
        Thread.CurrentThread.CurrentCulture = FrCulture;

        // Clones the NumberFormatInfo and creates
        // a new object for the local currency of France.
        NumberFormatInfo LocalFormat =
           (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
        // Replaces the default currency symbol with the 
        // local currency symbol.
        LocalFormat.CurrencySymbol = "៛";

        int i = 100;

        // Displays i formatted as the local currency.
        Console.WriteLine(i.ToString("c", LocalFormat));

        // Displays i formatted as the default currency.
        Console.WriteLine(i.ToString("c", NumberFormatInfo.CurrentInfo));
    }
}