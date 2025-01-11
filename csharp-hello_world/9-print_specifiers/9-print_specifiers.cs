using System;                       
using System.Globalization;          
class Program                       
{
    static void Main(string[] args)  
    {
        double percent = 75.534, currency = 98765.4321;
        percent = Math.Round(percent, 2);
        Console.WriteLine($"Percent: {percent:F2}%");
        Console.WriteLine($"Currency: {currency.ToString("C", new CultureInfo("en-US"))}");
    }                                
}
