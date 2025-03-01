
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        int[] nk = Array.ConvertAll(Console.ReadLine().Split(" "), (Convert.ToInt32));
        int n = nk[0];
        int k = nk[1];
        int[] coins = new int[n];
        for (int i = 0; i < n; i++)
        {
            coins[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] dp = new int[k + 1];
        Array.Fill(dp, k + 1);
        dp[0] = 0;

        foreach (int coin in coins)
        {
            for (int i = coin; i <= k; i++)
            {
                dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
            }
        }

        if (dp[k] == k + 1)
        {
            sw.WriteLine(-1);
        }
        else
        {
            sw.WriteLine(dp[k]);
        }
        sw.Flush(); sw.Close();
    }
}
