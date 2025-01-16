
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int input = Convert.ToInt32(Console.ReadLine());

        int cur = input;
        while (cur!=1)
        {
            for (global::System.Int32 i = 2; i <= cur; i++)
            {
                if (cur%i==0)
                {
                    sw.WriteLine(i);
                    cur /= i;
                    i = 1;
                }
            }
        }

        sw.Flush(); sw.Close();

    }
}
