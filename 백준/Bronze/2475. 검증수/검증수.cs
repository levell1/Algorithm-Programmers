using System;
using System.Diagnostics;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {

            string input = Console.ReadLine();

            string[] nums = input.Split(' ');
            int[] num = new int[nums.Length];
            double result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                num[i]= Convert.ToInt32(nums[i]);
                result += Math.Pow(num[i], 2);
            }

            Console.WriteLine(result%10);


            Console.ReadLine();
        }
    }
}