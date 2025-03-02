
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        int n = Convert.ToInt32( Console.ReadLine());
        int[] dp = new int[n+1];

        List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>();
        for (int i = 0; i < n; i++)
        {
            int[] tp = Array.ConvertAll(Console.ReadLine().Split(" "), (Convert.ToInt32));
            list.Add(new KeyValuePair<int, int>(tp[0], tp[1]));
        }

        for (int i = n-1; i >= 0; i--)
        {
            if (i + list[i].Key <=n)
            {
                dp[i] = Math.Max(dp[i + list[i].Key] + list[i].Value, dp[i+1]);
            }
            else
            {
                dp[i] = dp[i + 1];
            }


        }

        sw.Write(dp[0]);
        sw.Flush(); sw.Close();
    }
}
