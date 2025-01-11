using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        double percent = 75.534;
        double currency = 98765.4321;
        percent = Math.Round(percent, 2);
        Console.WriteLine($"Percent: {percent:F2}%");
        CultureInfo culture = new CultureInfo("en-US");
        Console.WriteLine($"Currency: {currency.ToString("C", culture)}");
    }
}
