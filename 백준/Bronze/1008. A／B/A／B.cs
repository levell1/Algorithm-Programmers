using System;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {

            string[] input = Console.ReadLine().Split(' ');

            double a = Convert.ToInt32(input[0]);
            double b = Convert.ToInt32(input[1]);
            double result = a / b;
            Console.Clear();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}