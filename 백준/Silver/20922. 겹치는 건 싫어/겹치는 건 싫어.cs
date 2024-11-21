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
        while (right<N) { 
            if (dic.ContainsKey(nums[right]))
            {
                dic[nums[right]]++;
            }
            else
            {
                dic[nums[right]] = 1;
            }
            while (dic[nums[right]] > K)
            {

                dic[nums[left]]--;
                if (dic[nums[left]] == 0)
                {
                    dic.Remove(nums[left]);
                }
                left++;

            }

            max = Math.Max(max, right - left+1);
            right++;
        }


        sw.WriteLine(max);

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}