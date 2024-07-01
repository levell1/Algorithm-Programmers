using System;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {

            int input = int.Parse(Console.ReadLine());
            int[] answer = new int[input];
            for (int num = 0; num < input; num++)
            {
                int n = int.Parse(Console.ReadLine());
                int[][] stickers = new int[2][];
                stickers[0] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                stickers[1] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                if (n == 1)
                {
                    answer[num] = Math.Max(stickers[0][0], stickers[1][0]);
                    continue;
                }

                int[,] dp = new int[2, n];
                dp[0, 0] = stickers[0][0];
                dp[1, 0] = stickers[1][0];
                dp[0, 1] = stickers[1][0] + stickers[0][1];
                dp[1, 1] = stickers[0][0] + stickers[1][1];

                for (int i = 2; i < n; i++)
                {
                    dp[0, i] = Math.Max(dp[1, i - 1], dp[1, i - 2]) + stickers[0][i];
                    dp[1, i] = Math.Max(dp[0, i - 1], dp[0, i - 2]) + stickers[1][i];
                }

                answer[num] = Math.Max(dp[0, n - 1], dp[1, n - 1]);
            }

            Console.Clear();
            foreach (int item in answer)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}