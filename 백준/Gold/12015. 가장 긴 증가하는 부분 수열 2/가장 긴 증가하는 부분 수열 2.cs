
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static List<int> list;

    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        list = new List<int>();
        list.Add(nums[0]);

        for (int i = 1; i < n; i++)
        {
            if (nums[i] > list[list.Count - 1])
            {
                list.Add(nums[i]);
            }
            else
            {
                int pos = SearchPosition(nums[i]);
                list[pos] = nums[i];
            }
        }

        sw.WriteLine(list.Count);
        sw.Flush(); sw.Close();
    }

    static int SearchPosition(int target) 
    {
        int left = 0;
        int right = list.Count - 1;

        while (left < right)
        {
            int mid = (left + right) / 2;
            if (list[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return right;
    }
}
