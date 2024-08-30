using System;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {

            string input1 = Console.ReadLine();
            string[] nums = input1.Split(' ');
            int a = Convert.ToInt32(nums[0]);
            int b = Convert.ToInt32(nums[1]);

            Console.Clear();

            Console.WriteLine(a * b);
            Console.ReadLine();
        }
    }
}