using System;

namespace Algorism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string count = Console.ReadLine();
            string input = Console.ReadLine();
            int sum=0;
            
            for (int i = 0; i < input.Length; i++)
            {
                sum += int.Parse(input[i].ToString());
            }

            Console.Write(sum);
            Console.ReadLine();
        }
    }
}