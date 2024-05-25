using System;
using System.Text;

class Program
{
    static void Main()
    {
        int testNum = int.Parse(Console.ReadLine());
        
        StringBuilder sb = new StringBuilder();

        int[] dp = new int[11];

        dp[0] = 1;
        dp[1] = 1;
        dp[2] = 2;
        dp[3] = 4;
        for (int i = 4; i < dp.Length; i++)
        {
            dp[i] = dp[i - 3] + dp[i - 2] + dp[i - 1];
        }

        for (int i = 0; i < testNum; i++)
        {
            int inputNum = int.Parse(Console.ReadLine());
            
            sb.Append(dp[inputNum]+"\n");
        }
        
        Console.WriteLine(sb.ToString());
        Console.ReadLine();
    }
}