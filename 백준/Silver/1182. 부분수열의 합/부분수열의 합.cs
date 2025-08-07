
class Program
{
    static int n,s;
    static int result;
    static int[] nums;
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int[] input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        n = input[0];
        s = input[1];

        nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        Sum(0, 0);
        if (s==0)
        {
            result--;
        }

        sw.WriteLine(result);
        sw.Flush(); sw.Close();
    }

    static void Sum(int count, int sum) 
    {
        if (count == n)
        {
            if (sum ==s)
            {
                result++;
            }
            return;
        }

        Sum(count + 1, sum + nums[count]);  //포함
        Sum(count + 1, sum);                //미포함

    }
}
