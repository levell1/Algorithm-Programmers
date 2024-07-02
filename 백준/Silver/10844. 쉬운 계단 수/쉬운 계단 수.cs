using System;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {

            int input = int.Parse(Console.ReadLine());

            long[,] dp = new long[input,10];

            for (int i = 1; i < 10; i++)
            {
                dp[0, i] = 1;
            }

            for (int i = 1; i < input; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j==0)
                    {
                        dp[i, j] = dp[i - 1, 1];
                    }
                    else if(j==9){
                        dp[i, j] = dp[i - 1, 8];
                    }
                    else
                    {
                        dp[i, j] = (dp[i - 1, j - 1] + dp[i - 1, j + 1]) % 1000000000;
                    }
                }
            }

            Console.Clear();
            long result = 0;
            for (int i = 0; i < 10; i++)
            {
                result += dp[input-1, i];
            }
            Console.WriteLine(result % 1000000000);

            Console.ReadLine();
        }
    }
}