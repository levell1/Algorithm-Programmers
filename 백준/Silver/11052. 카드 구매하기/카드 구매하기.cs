class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int[] result;
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] p = Array.ConvertAll(("0 "+Console.ReadLine()).Split(" "), Convert.ToInt32);

        int[] dp = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <=i ; j++)
            {
                dp[i] = (int)MathF.Max(dp[i - j] + p[j], dp[i]);
            }
        }

        sw.WriteLine(dp[n]);
        
        sw.Flush(); sw.Close();
    }

}
