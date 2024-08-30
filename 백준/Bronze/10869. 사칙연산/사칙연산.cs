using System;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {

            string input = Console.ReadLine();
            string[] nums = input.Split(' ');
            int a = Convert.ToInt32(nums[0]);
            int b = Convert.ToInt32(nums[1]);

            Console.Clear();

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            Console.ReadLine();
        }
    }
}