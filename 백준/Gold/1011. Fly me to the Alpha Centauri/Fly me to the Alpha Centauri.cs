
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());


    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long x = input[0];
            long y = input[1];

            long d = y - x;
            long z = (long)Math.Floor(Math.Sqrt(d));

            long count;
            if (d == z * z)
            {
                count = 2 * z - 1;
            }
            else if (d <= z * z + z) 
            {
                count = 2 * z;
            }
            else
            {
                count = 2 * z + 1;
            }

            sw.WriteLine(count);
        }

        sw.Flush(); sw.Close();
    }


}
