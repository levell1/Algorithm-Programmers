
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static long result;
    static void Main()
    {

        int[] nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = nk[0];
        int k = nk[1];

        int[] dp = new int[k + 1];
        dp[0] = 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = Math.Min(i,k); j > 0; j--)
            {
                dp[j] = (dp[j] + dp[j - 1]) % 10007;
            }
        }

        sw.WriteLine(dp[k]);
        sw.Flush(); sw.Close();
    }

}

