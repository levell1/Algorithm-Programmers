using System.Text;

class Program
{
    static int result = 0;
    static StringBuilder sb = new StringBuilder();
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = Convert.ToInt32(Console.ReadLine());

        int[] dp = new int[n + 2];
        int[] time = new int[n + 2];
        for (int i = 0; i < n; i++)
        {
            int[] TP = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int t = TP[0];
            int p = TP[1];
            
            if (n - i >= t)
            {
                time[i + 1] = t;
                dp[i + 1] = p;
            }
        }

        for (int i = n-1; i >=1; i--)
        {
            if (i + time[i]<=n+1)
            {
                dp[i]=Math.Max(dp[i] + dp[i + time[i]], dp[i + 1]);
            }
            else
            {
                dp[i] = dp[i + 1];
            }

        }


        sw.WriteLine(dp.Max());
        sw.WriteLine(sb.ToString());
        sw.Flush(); sw.Close();

    }
    

}