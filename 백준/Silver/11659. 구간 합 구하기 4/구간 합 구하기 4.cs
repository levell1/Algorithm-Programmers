using System;
using System.Collections.Generic;
using System.Text;



class Program
{
    static void Main()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '),Convert.ToInt32);
        StringBuilder sb = new StringBuilder();

        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        int[] sum = new int[numbers.Length+1];
        sum[0] = 0;
        for (int i = 1; i < sum.Length; i++)
        {
            sum[i] = sum[i - 1] + numbers[i-1];
        }

        for (int i = 0; i < input[1]; i++)
        {
            int result = 0;
            int[] range = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            result = sum[range[1]]- sum[range[0]-1];
            sb.AppendLine(result.ToString());
        }

        Console.WriteLine(sb.ToString());
        Console.ReadLine();
    }
}