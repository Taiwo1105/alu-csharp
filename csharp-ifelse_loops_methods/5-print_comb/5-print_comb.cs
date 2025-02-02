using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder output = new StringBuilder();

        for (int i = 0; i <= 99; i++)
        {
            output.Append($"{i:D2}"); // Format the number with two digits
            if (i < 99)
            {
                output.Append(", "); // Add a comma and space for all numbers except the last
            }
        }

        Console.Write(output.ToString()); // Print the entire string
        Console.WriteLine(); // Print a new line at the end
    }
}
