
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int T = Convert.ToInt32(Console.ReadLine());
        int first = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int[][] dp = new int[T+1][];
        for (int i = 1; i <= T; i++)
        {
            dp[i] = new int[i];
        }

        dp[1][0] = first;

        for (int i = 2; i <= T; i++)
        {
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            dp[i][0] = dp[i - 1][0]+nums[0];
            for (global::System.Int32 j = 1; j < nums.Length-1; j++)
            {
                dp[i][j] = Math.Max(dp[i - 1][j-1],dp[i - 1][j]) + nums[j];
            }
            dp[i][nums.Length-1] = dp[i - 1][nums.Length-2] + nums[nums.Length - 1];
        }
        
        sw.Write(dp[T].Max());
        sw.Flush(); sw.Close();
        Console.ReadLine();

    }
}