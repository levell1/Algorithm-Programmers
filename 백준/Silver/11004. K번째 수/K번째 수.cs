
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int n = nk[0];
        int k = nk[1];

        int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Array.Sort(nums);
        

        sw.Write(nums[k-1]);

        sw.Flush(); sw.Close();
    }

}
