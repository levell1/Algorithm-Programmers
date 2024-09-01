using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] words = input.Trim().Split(' ');

        if (words.Length == 1 && words[0]=="")
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(words.Length);
        }
    }
}