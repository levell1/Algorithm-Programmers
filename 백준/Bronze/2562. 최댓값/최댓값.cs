using System;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {
            int testcase = 9;
            int max = 0;
            int pos = 0;
            for (int i = 0; i < testcase; i++)
            {
                string input = Console.ReadLine();
                int a = Convert.ToInt32(input);
                if (a>max)
                {
                    max = a;
                    pos = i+1;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(pos);
            Console.ReadLine();
        }
    }
}