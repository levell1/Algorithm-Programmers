using System;
using System.Text;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {

            string input = Console.ReadLine();
            string[] nums = input.Split(' ');
            int b = Convert.ToInt32(nums[1]);

            string input1 = Console.ReadLine();
            string[] nums1 = input1.Split(' ');
           

            Console.Clear();
            StringBuilder sb = new StringBuilder();
            int c = 0;
            foreach (var item in nums1)
            {
                c = Convert.ToInt32(item);
                if (c < b)
                {
                    sb.Append(item + ' ');
                }
            }
            Console.WriteLine(sb.ToString());

            Console.ReadLine();
        }
    }
}