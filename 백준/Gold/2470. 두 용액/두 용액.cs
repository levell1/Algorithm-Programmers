using System.Security;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());

        int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

        Array.Sort(nums);

        Dictionary<int,int> dic = new Dictionary<int, int>();
        int left = 0;
        int right = input-1;
        int min = 2000000001;
        int leftNum = nums[left];
        int rightNum = nums[right];

        if (nums[input - 1] < 0)
        {
            leftNum = nums[input - 2];
            rightNum = nums[input - 1];
            left = right;
        }
        else if (nums[0] > 0)
        {
            
            leftNum = nums[0];
            rightNum = nums[1];
            left = right;
        }

        while (left<right) {


            if (min > Math.Abs(nums[right] + nums[left]))
            {
                min = Math.Abs(nums[right] + nums[left]);
                leftNum = nums[left];
                rightNum = nums[right];
            }
            

            if (nums[right] + nums[left] > 0)
            {
                right--;

            }
            else
            {
                left++;
            }
        }

        
        sw.WriteLine($"{leftNum} {rightNum}");

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}