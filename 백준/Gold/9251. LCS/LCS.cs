
class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            //int T = Convert.ToInt32(Console.ReadLine());
            //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            int firstLen = first.Length;
            int secondLen = second.Length;

            int[,] dp = new int[firstLen+1, secondLen+1];


            for (int i = 1; i <= firstLen; i++)
            {
                for (int j = 1; j <= secondLen; j++) 
                {
                    if (first[i-1] == second[j-1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else 
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            sw.WriteLine($"{dp[firstLen,secondLen]}");
            sw.Flush(); sw.Close();
        }
    }
}
