using System;
using System.Linq;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {
            int inputNum = int.Parse(Console.ReadLine());

            int[] dp = new int[inputNum];
            int[] sequence = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Copy(sequence, dp, inputNum);
            //lis알고리즘
            for (int i = 1; i < inputNum; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (sequence[j] < sequence[i] && dp[i] < dp[j] + sequence[i])
                    {
                        dp[i] = dp[j] + sequence[i];
                    }
                }
            }

            //int max = dp.Max();
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