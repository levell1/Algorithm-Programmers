using System;
using System.Text;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {

            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string input1 = Console.ReadLine();
                string[] nums = input1.Split(' ');
                int a = Convert.ToInt32(nums[0]);
                int b = Convert.ToInt32(nums[1]);
                string result = Convert.ToString(a + b);
                if (a+b==0)
                {
                    break;
                }
                sb.Append(result+ '\n');

            }

            Console.Clear();

            Console.WriteLine(sb.ToString());

            Console.ReadLine();
        }
    }
}