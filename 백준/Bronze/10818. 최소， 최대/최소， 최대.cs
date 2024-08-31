using System;
using System.Xml.Schema;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {
            string testcase = Console.ReadLine();
            int casenum = int.Parse(testcase);

            string input = Console.ReadLine();
            string[] nums = input.Split(' ');
            int max = -1000000;
            int min = 1000000;
            int num = 0;
            for (int i = 0; i < casenum; i++)
            {
                num = int.Parse(nums[i]);
                if (max < num)
                {
                    max = num;
                }
                if (min>num)
                {
                    min = num;
                }

            }

            Console.Clear();

            Console.WriteLine($"{min} {max}");

            Console.ReadLine();

        }
    }
}