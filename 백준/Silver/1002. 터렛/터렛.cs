
class Program
{
    static int result = 0;
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int[] xyr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int x1 = xyr[0];
            int y1 = xyr[1];
            int r1 = xyr[2];

            int x2 = xyr[3];
            int y2 = xyr[4];
            int r2 = xyr[5];

            double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            int sum = r1 + r2;
            int dif = Math.Abs(r1 - r2);

            if (d == 0 && r1 == r2)
            {
                result = -1;
            }
            else if (d == sum || d == dif)
            {
                result = 1;
            }
            else if (d > sum || d < dif)
            {
                result = 0;
            }
            else
            {
                result = 2;
            }
                sw.WriteLine(result);
        }

        sw.Flush(); sw.Close();

    }

}