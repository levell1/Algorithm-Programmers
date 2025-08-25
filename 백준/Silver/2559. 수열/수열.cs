
using System.Diagnostics.CodeAnalysis;

class Program
{
    static int[] input;
    static int N, K;
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        N = input[0];   
        K = input[1];

        int[] nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        

        int left = 0, right = K-1 ;
        int sum = 0;
        for (int i = 0; i <= right; i++)
        {
            sum += nums[i];
        }
        int max = sum;

        while (right<N-1)
        {
            sum -= nums[left++];
            sum += nums[++right];
            if (max<sum)
            {
                max = sum;
            }
        }

        sw.WriteLine(max);
        sw.Flush(); sw.Close();
    }

   
}
