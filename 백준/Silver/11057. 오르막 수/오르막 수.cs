
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int result;
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] dp = new int[n + 1,10];
        int mod = 10007;
        for (int i = 0; i < 10; i++)
        {
            dp[1,i] = 1;
        }

        for (int i = 2; i <= n; i++)
        {
            for (int j = 9; j >=0 ; j--)
            {
                if (j == 9)
                    dp[i, j] = dp[i - 1, j] % mod;
                else
                    dp[i, j] = dp[i - 1, j] + dp[i, j + 1] % mod;
            }
        }

        for (int j = 0; j < 10; j++)
        {
            result = (result + dp[n, j]) % mod;
        }

        sw.WriteLine(result);
        sw.Flush(); sw.Close();
    }
}
