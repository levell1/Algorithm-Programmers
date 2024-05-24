using System;

class Program
{
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());

        int[] dp = new int[inputNum + 1];

        for (int i = 1; i <= inputNum; i++)
        {
            int min = 4;
            for (int j = 1; j * j <= i; j++)
            {
                min = Math.Min(min, dp[i - j * j] + 1);
            }
            dp[i] = min;
        }

        Console.WriteLine(dp[inputNum]);
        Console.ReadLine();
    }
}