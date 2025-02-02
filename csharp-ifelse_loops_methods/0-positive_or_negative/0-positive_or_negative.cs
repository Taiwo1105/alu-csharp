using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 98, -98, 0 };

        foreach (int number in numbers)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is negative");
            }
            else
            {
                Console.WriteLine($"{number} is zero");
            }
        }
    }
}

