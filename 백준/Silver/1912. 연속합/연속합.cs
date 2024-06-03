using System;
using System.Linq;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {
            int inputNum = int.Parse(Console.ReadLine());

            string[] numbers = Console.ReadLine().Split(' ');
            int[] dp = new int[inputNum];
            int[] sequence = new int[inputNum];

            for (int i = 0; i < inputNum; i++)
            {
                sequence[i] = int.Parse(numbers[i]);
                dp[i] = sequence[i];
            }

            int max = sequence.Max();
            for (int i = 1; i < inputNum; i++)
            {
                dp[i] = Math.Max(sequence[i], sequence[i] + dp[i - 1]);
                max = Math.Max(max, dp[i]);
            }


            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}