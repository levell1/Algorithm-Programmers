
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int T = Convert.ToInt32(Console.ReadLine());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int N = inputArr[0];
        int T = inputArr[1];

        int[,] dp = new int[N+1,N+1];

        for (int i = 1; i <= N; i++)
        {
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            for (int j = 1; j <= N; j++)
            {
                dp[i, j] = dp[i - 1, j] + dp[i, j - 1] - dp[i - 1, j - 1] + nums[j - 1];
            }
        }


        for (int i = 0; i < T; i++)
        {
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int startX = nums[0];
            int startY = nums[1];
            int endX= nums[2];
            int endY = nums[3];

            int result = dp[endX, endY] - dp[startX - 1, endY] - dp[endX, startY-1]+ dp[startX - 1, startY - 1];
            sw.WriteLine(result);
        }

        sw.Flush(); sw.Close();
        Console.ReadLine();

    }
}