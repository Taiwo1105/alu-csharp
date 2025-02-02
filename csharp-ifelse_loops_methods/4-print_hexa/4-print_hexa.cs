using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder output = new StringBuilder();

        for (int i = 0; i <= 98; i++)
        {
            output.Append($"{i} = 0x{i:x}\n");
        }

        Console.Write(output.ToString());
    }
}
