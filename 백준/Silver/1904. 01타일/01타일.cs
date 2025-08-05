

class Program
{
    static int n;

    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        n = Convert.ToInt32(Console.ReadLine());
        int[] dp = new int[n + 1];
        dp[1] = 1;
        if (n>=2)
        {
            dp[2] = 2;
        }
        

        for (int i = 3; i <= n; i++)
        {
            int cur = (dp[i - 1] + dp[i - 2]) % 15746;
            dp[i] = cur;
        }



        sw.WriteLine(dp[n]);
        sw.Flush(); sw.Close();
    }

    
}