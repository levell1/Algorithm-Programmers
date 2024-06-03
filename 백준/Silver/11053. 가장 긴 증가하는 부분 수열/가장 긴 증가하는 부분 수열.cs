using System;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {
            int inputNum = int.Parse(Console.ReadLine());

            int[] dp = new int[inputNum];
            string[] sequence = Console.ReadLine().Split(' ');


            for (int i = 0; i < inputNum; i++)
            {
                dp[i] = 1;
            }

            for (int i = 1; i < inputNum; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (int.Parse(sequence[j]) < int.Parse(sequence[i]))
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
            }

            int max = 0;
            for (int i = 0; i < inputNum; i++)
            {
                max = Math.Max(max, dp[i]);
            }

            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}