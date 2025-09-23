
using System;

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int result;
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int x = int.Parse(Console.ReadLine());

        int left = 0;
        int right = arr.Max();

        while (left<=right)
        {
            int mid = (left + right) / 2;
            long sum = 0;

            foreach (var num in arr)
            {
                sum += Math.Min(num, mid);
            }

            if (sum>x)
            {
                right = mid - 1;
            }
            else
            {
                result = mid;
                left = mid + 1;
            }
        }

        sw.WriteLine(result);
        sw.Flush(); sw.Close();
    }

}

