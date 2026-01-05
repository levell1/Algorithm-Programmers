
using System.ComponentModel.DataAnnotations;

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int m, n;
    static bool[,] dp;
    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        string[] arr= (Console.ReadLine().Split(' '));
        m = int.Parse(Console.ReadLine());

        dp = new bool[n, n];
        for (int i = 0; i < n; i++)
        {
            dp[i, i] = true;
        }

        for (int i = 0; i < n-1; i++)
        {
            if (arr[i] == arr[i+1])
            {
                dp[i, i+1] = true;
            }
            
        }

        for (int len = 3; len <= n; len++)
        {
            for (int s = 0; s+len-1 < n; s++)
            {
                int e = s + len - 1;
                if (arr[s] == arr[e] && dp[s+1,e-1])
                {
                    dp[s, e] = true;
                }
            }
        }

        for (int i = 0; i < m; i++)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int s = input[0]-1;
            int e = input[1]-1;

            sw.WriteLine(dp[s, e] ? "1": "0");

        }

        sw.Flush(); sw.Close();
    }

   



}


