
class Program
{
    static int[] input;
    static int N, M;
    static int count;
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        M = input[0];   
        N = input[1];

        int[] nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        for (int i = 0; i < M; i++)
        {
            int sum = 0;
            for (int j = i; j < M; j++)
            {
                sum += nums[j];
                if (sum==N)
                {
                    count++;
                    break;
                }
                else if(sum>N)
                {
                    break;
                }
            }
        }

        sw.WriteLine(count);
        sw.Flush(); sw.Close();
    }

   
}
