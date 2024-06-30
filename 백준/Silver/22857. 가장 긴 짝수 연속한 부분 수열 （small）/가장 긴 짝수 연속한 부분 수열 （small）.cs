using System;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {
            
            int[] inputNum = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[] dp = new int[inputNum[0]];
            int[] sequence = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int count = 0;
            //lis알고리즘
            for (int i = 0; i < inputNum[0]; i++)
            {
                count = 0;
                for (int j = 0; j <= i; j++)
                {

                    if ( sequence[i-j]%2==0)
                    {
                        dp[i]++;
                    }
                    else if (sequence[i - j] % 2 == 1 && count<inputNum[1])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
            }


            int max = 0;
            for (int i = 0; i < inputNum[0]; i++)
            {
                max = Math.Max(max, dp[i]);
            }

            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}