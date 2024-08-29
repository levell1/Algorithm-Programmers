using System;
using System.Diagnostics;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {

            int input = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();
            for (int i = 1; i <= input; i++)
            {
                for (int j = input-i; j < input; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}