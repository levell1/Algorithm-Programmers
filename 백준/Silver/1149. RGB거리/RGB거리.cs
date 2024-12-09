
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int T = Convert.ToInt32(Console.ReadLine());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int[,] dp = new int[T,3];
        dp[0,0] = inputArr[0];
        dp[0,1] = inputArr[1];
        dp[0,2] = inputArr[2];

        for (int i = 1; i < T; i++)
        {
            inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

            dp[i, 0] = inputArr[0] + Math.Min(dp[i - 1, 1], dp[i - 1, 2]);
            dp[i, 1] = inputArr[1] + Math.Min(dp[i - 1, 0], dp[i - 1, 2]);
            dp[i, 2] = inputArr[2] + Math.Min(dp[i - 1, 0], dp[i - 1, 1]);
        }

        sw.Write(Math.Min(dp[T-1, 0], Math.Min(dp[T - 1, 1], dp[T - 1, 2])));
        sw.Flush(); sw.Close();
        Console.ReadLine();
      
        
    }
}