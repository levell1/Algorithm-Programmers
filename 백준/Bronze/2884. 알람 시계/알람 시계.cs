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

            int min = b - 45;
            int hour = a;
            if (min<0)
            {
                hour--;
                min += 60;
                if (hour<0)
                {
                    hour = 23;
                }
            }
            Console.Write(hour);
            Console.Write(' ');
            Console.Write(min);


            Console.ReadLine();
        }
    }
}