
using System;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int n = inputArr[0];
        int m = inputArr[1];
        int[,] a = new int[n,m];

        for (int i = 0; i < n; i++)
        {
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            for (int j = 0; j < m; j++)
            {
                a[i, j] = nums[j];
            }
        }

        for (int i = 0; i < n; i++)
        {
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            for (int j = 0; j < m; j++)
            {
                a[i, j] += nums[j];
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                sw.Write($"{a[i, j]} ");
            }
            sw.WriteLine();
        }

        
        sw.Flush(); sw.Close();

    }
}
