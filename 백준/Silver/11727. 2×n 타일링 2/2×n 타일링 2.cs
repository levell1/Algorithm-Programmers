using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int inputNum = int.Parse(Console.ReadLine());

        int[] dp = new int[1001];

        dp[0] = 1;
        dp[1] = 1;

        for (int i = 2; i <= inputNum; i++)
        {
            dp[i] = dp[i - 2]*2 + dp[i - 1];
            dp[i] %= 10007;
        }
        Console.WriteLine(dp[inputNum]);
        Console.ReadLine();
    }
}