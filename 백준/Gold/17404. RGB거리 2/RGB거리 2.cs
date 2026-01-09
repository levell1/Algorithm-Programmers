

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        //int[] nm = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
        int n = int.Parse(Console.ReadLine());
        
        int[,] cost = new int[n + 1, 3];
        for (int i = 1; i <= n; i++)
        {
            int[] rgb = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            cost[i, 0] = rgb[0];
            cost[i, 1] = rgb[1];
            cost[i, 2] = rgb[2];
        }

        
        int INF = 1000000000;
        int result = INF;

        for (int s = 0; s < 3; s++)
        {
            int[,] dp = new int[n + 1, 3];

            for (int i = 0; i < 3; i++)
            {
                dp[1, i] = (i == s) ? cost[1, i] : INF;
            }
            for (int i = 2; i <= n; i++)
            {
                dp[i, 0] = cost[i, 0] + Math.Min(dp[i - 1, 1], dp[i - 1, 2]);
                dp[i, 1] = cost[i, 1] + Math.Min(dp[i - 1, 0], dp[i - 1, 2]);
                dp[i, 2] = cost[i, 2] + Math.Min(dp[i - 1, 0], dp[i - 1, 1]);
            }

            for (int i = 0; i < 3; i++)
            {
                if (i != s)
                {
                    result = Math.Min(result, dp[n, i]);
                }
            }
        }


        sw.WriteLine(result);
        sw.Flush(); sw.Close();
    }

}


