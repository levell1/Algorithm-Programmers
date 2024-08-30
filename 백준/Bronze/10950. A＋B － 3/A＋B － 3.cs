using System;
using System.Text;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {

            string input = Console.ReadLine();
            int testcase = Convert.ToInt32(input);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < testcase; i++)
            {
                string input1 = Console.ReadLine();
                string[] nums = input1.Split(' ');
                int a = Convert.ToInt32(nums[0]);
                int b = Convert.ToInt32(nums[1]);
                string result = Convert.ToString(a + b);
                sb.Append(result+ '\n');

            }

            Console.Clear();

            Console.WriteLine(sb.ToString());

            Console.ReadLine();
        }
    }
}