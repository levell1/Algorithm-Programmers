using System;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char a = input[0];
            int ascii = Convert.ToInt32(a);

            Console.WriteLine(ascii);
        }
    }
}