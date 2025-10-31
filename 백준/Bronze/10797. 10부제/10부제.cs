
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());


    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int count=0;
        foreach (var num in nums)
        {
            if (num==n)
            {
                count++;
            }
        }


        sw.WriteLine(count);
        sw.Flush(); sw.Close();
    }

}
