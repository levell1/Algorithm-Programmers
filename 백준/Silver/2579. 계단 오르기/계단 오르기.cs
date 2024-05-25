using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int stairs = int.Parse(Console.ReadLine());//300이하
        int score = 0; //10000이하
        int[] stairScore = new int[stairs+1];

        for (int i = 1; i < stairScore.Length; i++)
        {
            score = int.Parse(Console.ReadLine());
            stairScore[i] = score;
        }

        int[] dp = new int[stairs+1];

        dp[0] = stairScore[0];
        dp[1] = stairScore[1];
        if (stairs>=2)
        {
            dp[2] = stairScore[1] + stairScore[2];
        }
        //dp[3] = Math.Max( stairScore[1] + stairScore[3], stairScore[2] + stairScore[3]);
        //dp[4] = Math.Max(stairScore[2] + stairScore[3] + stairScore[4], stairScore[1] + stairScore[2] + stairScore[4]);
        for (int i = 3; i < stairs+1; i++)
        {
            dp[i] = Math.Max(dp[i - 2] + stairScore[i], dp[i - 3] + stairScore[i - 1] + stairScore[i]);
        }
        
        Console.WriteLine(dp[stairs]);
        Console.ReadLine();
    }
}