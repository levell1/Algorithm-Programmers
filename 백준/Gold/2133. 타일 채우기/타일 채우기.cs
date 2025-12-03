
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static int N ;


    static void Main()
    {
        N = int.Parse(Console.ReadLine());

        int[] dp = new int[N + 1];
        dp[0] = 1;
        dp[1] = 0;
        if (N>=2)
        {
            dp[2] = 3;
        }

        for (int i = 4; i < N+1; i+=2)
        {

            dp[i] = (dp[i - 2] * 3);

            for (int j = i-4; j >= 0; j-=2)
            {
                dp[i] += dp[j] * 2;
            }

        }

        sw.WriteLine(dp[N]);
        sw.Flush(); sw.Close();
    }


}
