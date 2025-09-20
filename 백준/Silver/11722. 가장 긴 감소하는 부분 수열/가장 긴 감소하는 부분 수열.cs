

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int[] arr;
    static int result;
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int[] dp = new int[n];
        for (int i = 0; i < n; i++)
        {
            dp[i] = 1;
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (arr[j] > arr[i])
                {
                    dp[i] = Math.Max(dp[i], dp[j]+1);
                }
            }
        }
        result = dp.Max();

        sw.WriteLine(result);
        sw.Flush(); sw.Close();
    }

}

