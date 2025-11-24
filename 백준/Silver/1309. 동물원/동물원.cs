
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        //int[] FSGUD = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int n = int.Parse(Console.ReadLine());
        int mod = 9901;

        double[,] dp = new double[n+1, 3];
        dp[1, 0] = 1;   // 둘 다 없는
        dp[1, 1] = 1;   // 왼쪽   사자
        dp[1, 2] = 1;   // 오른쪽 사자
        

        for (int i = 2; i <= n; i++)
        {
            dp[i, 0] = (dp[i - 1, 0] + dp[i - 1, 1] + dp[i - 1, 2]) % mod;
            dp[i, 1] = (dp[i - 1, 0] + dp[i - 1, 2]) % mod;
            dp[i, 2] = (dp[i - 1, 0] + dp[i - 1, 1]) % mod;
        }

        double result = (dp[n, 0] + dp[n, 1] + dp[n, 2]) % mod;

        sw.WriteLine(result);
        sw.Flush(); sw.Close();
    }


}
