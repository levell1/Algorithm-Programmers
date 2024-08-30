using System;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {

            string input = Console.ReadLine();
            string inputnum = Console.ReadLine();
            int a = Convert.ToInt32(inputnum);
            char result = input[a-1];
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}