
class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            //int T = Convert.ToInt32(Console.ReadLine());
            int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int n = inputArr[0];
            int k = inputArr[1];

            var objs = new (int k , int v)[n+1];
            int[,] dp = new int[n + 1, k + 1];

            for (int i = 1; i <= n; i++)
            {
                int[] obj = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
                objs[i].k = obj[0];
                objs[i].v = obj[1];

            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    if (objs[i].k <= j)
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i - 1, j - objs[i].k] + objs[i].v);
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                }
            }

            

            sw.WriteLine($"{dp[n,k]}");
            sw.Flush(); sw.Close();
        }
    }
}
