
using System.Diagnostics.CodeAnalysis;

class Program
{
    static int[] input;
    static int M, N;
    static int count;
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        N = input[0];   
        M = input[1];

        int[] nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int left = 0, right = 0 ;
        int sum = 0;
        while (true)
        {
            if (sum >= M) 
            {
                if (sum==M)
                {
                    count++;
                }
                sum -= nums[left++];
            }
            else
            {
                if (right ==N)
                {
                    break;
                }
                sum += nums[right++];
            }

        }

        sw.WriteLine(count);
        sw.Flush(); sw.Close();
    }

   
}
