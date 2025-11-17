
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {

        //nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        string arr = Console.ReadLine();
        int[] nums = new int[arr.Length];
        int sum = 0;
        string result;
        for (int i = 0; i < arr.Length; i++)
        {
            nums[i] = arr[i] - '0';
            sum += nums[i];
        }

        if (!nums.Contains(0)||sum%3!=0)
        {
            result = "-1";
        }
        else
        {
            Array.Sort(nums);
            Array.Reverse(nums);
            result = string.Concat(nums);
        }
        
        sw.WriteLine(result);  
        sw.Flush(); sw.Close();
    }

}
