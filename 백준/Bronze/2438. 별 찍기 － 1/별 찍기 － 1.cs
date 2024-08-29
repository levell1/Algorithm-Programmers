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
                Console.WriteLine(new string('*', i));
            }

            Console.ReadLine();
        }
    }
}