using System;

class Program
{
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());

        int[] dp = new int[inputNum + 1];

        for (int i = 2; i <= inputNum; i++)
        {
            dp[i] = dp[i - 1] + 1;
            if (i % 3 == 0)
            {
                dp[i] = Math.Min(dp[i],dp[i / 3] + 1);
            }
            if (i % 2 == 0)
            {
                dp[i] = Math.Min(dp[i], dp[i / 2] + 1);
            }
        }

        Console.WriteLine(dp[inputNum]);
        Console.ReadLine();
    }
}