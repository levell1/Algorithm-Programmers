
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        
        //int n = int.Parse(Console.ReadLine());

        int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int n = nk[0];
        int k = nk[1];
        long[,] dp = new long[k+1,n+1];
        int mod = 1000000000;

        for (int i = 0; i <= k; i++)
        {
            dp[i, 0] = 1;
        }

        for (int i = 0; i <= n; i++)
        {
            dp[1, n] = 1;
        }

        for (int i = 1; i <= k; i++)
        {
            for (global::System.Int32 j = 1; j <= n; j++)
            {
                dp[i, j] = (dp[i, j - 1] + dp[i - 1 , j]) % mod;
            }
        }


        sw.WriteLine(dp[k,n]);
        sw.Flush(); sw.Close();
    }


}
