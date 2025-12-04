
using System.Runtime.ConstrainedExecution;

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static int N ;


    static void Main()
    {
        N = int.Parse(Console.ReadLine());
        int[] w = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        long min = 2000000000;

        int left = 0;
        int right = N - 1;

        int resultLeft = w[left];
        int resultRight = w[right];

        while (left<right)
        {

            long sum = w[left] + w[right];
            long absSum = Math.Abs(sum);
            if (min > absSum)
            {
                min = absSum;
                resultLeft = w[left];
                resultRight = w[right];
            }

            if (sum==0)
            {
                break;
            }

            if (sum < 0)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        sw.WriteLine($"{resultLeft} {resultRight}");
        sw.Flush(); sw.Close();
    }


}
