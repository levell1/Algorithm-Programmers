using System;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {

            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(input + " * " + i + " = " + (num * i));
            }

            Console.ReadLine();
        }
    }
}