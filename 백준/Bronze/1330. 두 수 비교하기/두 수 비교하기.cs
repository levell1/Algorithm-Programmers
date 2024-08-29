using System;
using System.Diagnostics;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {

            string[] input = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(input[0]);
            int b = Convert.ToInt32(input[1]);
            int result = a - b;
            
            Console.Clear();
            if (result<0)
            {
                Console.WriteLine('<');
            }else if (result>0)
            {
                Console.WriteLine('>');
            }
            else
            {
                Console.WriteLine("==");
            }

            Console.ReadLine();
        }
    }
}