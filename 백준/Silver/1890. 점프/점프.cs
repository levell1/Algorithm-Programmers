using System;

namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {

            int input = int.Parse(Console.ReadLine());

            int[][] board = new int[input][];

            for (int i = 0; i < input; i++)
            {
                board[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }
            

            long[,] dp = new long[input, input];
            dp[0, board[0][0]] = 1;
            dp[board[0][0], 0] = 1;


            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    if (dp[i,j]>0&& board[i][j]!=0)
                    {
                        if (input > j + board[i][j])
                        {
                            dp[i, j + board[i][j]] += dp[i, j];
                        }

                        if (input > i + board[i][j])
                        {
                            dp[i + board[i][j], j] += dp[i, j];
                        }
                    }
                }
            }

            Console.Clear();
            Console.WriteLine(dp[input-1,input-1]);


            Console.ReadLine();
        }
    }
}