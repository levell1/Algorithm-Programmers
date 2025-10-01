
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {

        int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int A = nums[0];
        int B = nums[1];
        int C = nums[2];

        sw.WriteLine((A + B) % C);
        sw.WriteLine(((A % C) + (B % C)) % C);
        sw.WriteLine((A*B) % C);
        sw.WriteLine(((A % C) * (B % C)) % C);
        sw.Flush(); sw.Close();
    }

}

