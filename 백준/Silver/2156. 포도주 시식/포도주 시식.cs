using System;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {

            int input = int.Parse(Console.ReadLine());

            int[] wine = new int[input];

            for (int i = 0; i < input; i++)
            {
                wine[i] = int.Parse(Console.ReadLine());
            }

            if (input==1)
            {
                Console.WriteLine(wine[0]);
                return;
            }else if (input==2) 
            {
                Console.WriteLine(wine[0] + wine[1]);
                return;
            }

            int[] dp = new int[input];

            dp[0] = wine[0];
            dp[1] = dp[0] + wine[1];
            dp[2] = Math.Max(dp[1], Math.Max(wine[2] + wine[1], wine[2] + wine[0]));


            for (int i = 3; i < input; i++)
            {
                dp[i] = Math.Max(dp[i - 1], Math.Max(dp[i - 2] + wine[i], dp[i - 3] + wine[i - 1] + wine[i]));
            }

            Console.Clear();
            Console.WriteLine(dp[input - 1]);

            Console.ReadLine();
        }
    }
}