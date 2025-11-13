
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {

        int n = int.Parse( Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int[] pos = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int sx = pos[0];
            int sy = pos[1];
            int ex = pos[2];
            int ey = pos[3];

            int count = 0;

            int k = int.Parse(Console.ReadLine());
            for (int j = 0; j < k; j++)
            {
                int[] planet = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int px = planet[0];
                int py = planet[1];
                int r = planet[2];
                double distStartPoint = (sx - px) * (sx - px) + (sy - py) * (sy - py);
                double distEndPoint = (ex - px) * (ex - px) + (ey - py) * (ey - py);

                if (distStartPoint<=r*r&& distEndPoint <= r * r)
                {
                    continue;
                } else if (distStartPoint <= r*r|| distEndPoint <= r * r)
                {
                    count++;
                }
            }
            sw.WriteLine(count);
        }



        sw.Flush(); sw.Close();
    }

}
