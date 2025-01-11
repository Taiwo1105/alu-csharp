using System;                       
using System.Globalization;          
class Program                       
{
    static void Main(string[] args)  
    {
        double percent = -44.984, currency = -9999.99;
        percent = Math.Round(percent, 2);
        Console.WriteLine($"Percent: {percent:F2}%");
        Console.WriteLine($"Currency: {currency.ToString("C", new CultureInfo("en-US"))}");
    }                                
}
