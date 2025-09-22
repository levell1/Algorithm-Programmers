
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int result;
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int min = (int)Math.Truncate(Math.Sqrt(n));

        int[] dp = new int[n + 1];

        for (int i = 1; i <= n; i++)
        {
            dp[i] = i;
            for (int j = 1; j*j <= i; j++)
            {
                dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
            }
        }

        sw.WriteLine(dp[n]);
        sw.Flush(); sw.Close();
    }

}

