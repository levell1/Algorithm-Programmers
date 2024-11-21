using System.Security;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        int N = input[0];
        int K = input[1];

        int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

        Dictionary<int,int> dic = new Dictionary<int, int>();
        int left = 0;
        int right = 0;
        int max = 0;
        int count = 0;
        while (right<N) { 
            if (nums[right] % 2 == 1)
            {
                count++;
            }

            while (count>K)
            {
                
                if (nums[left] % 2 == 1)
                {
                    count--;
                }
                left++;

            }

            max = Math.Max(max, right - left+1-count);
            right++;
        }


        sw.WriteLine(max);

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}