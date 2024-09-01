using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine(0);
        }
        else
        {
            string[] words = input.Trim().Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(words.Length);
        }
    }
}