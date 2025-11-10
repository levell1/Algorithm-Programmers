
using System.Runtime.Intrinsics.Arm;

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int[,,] dp;
    static void Main()
    {
        dp = new int[21,21,21];
        while (true)
        {
            int[] abc = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int a = abc[0];
            int b = abc[1];
            int c = abc[2];
            if (a == -1 && b == -1 && c == -1)
            {
                break;
            }
            int result = 0;
            result = W(a, b, c);

            sw.WriteLine($"w({a}, {b}, {c}) = {result}");
        }

        sw.Flush(); sw.Close();
    }


    static int W(int a, int b, int c) 
    {
        int w = 0;
        if (a <= 0 || b <= 0 || c <= 0)
        {
            return 1;
        }

        if (a > 20 || b > 20 || c > 20)
        {
            return W(20, 20, 20);
        }

        if (dp[a,b,c] !=0)
        {
            return dp[a, b, c];
        }

        if (a < b && b < c)
        {
            dp[a,b,c] = W(a, b, c - 1) + W(a, b - 1, c - 1) - W(a, b - 1, c);
        }
        else
        {
            dp[a, b, c] = W(a - 1, b, c) + W(a - 1, b - 1, c) + W(a - 1, b, c - 1) - W(a - 1, b - 1, c - 1);
        }

        return dp[a, b, c];
    }

}
