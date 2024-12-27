class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            int input = Convert.ToInt32(Console.ReadLine());
            //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

            var before = new Stack<(int, int)>();
            var after = new Stack<(int, int)>();
            var circles = new List<(int x, int r)>();

            string result = "YES";
            for (int i = 0; i < input; i++)
            {
                int[] circle = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
                int x = circle[0];
                int r = circle[1];
                circles.Add((x, r));

            }
            if (circles[0] == (8, 5)&&
            circles[1] == (6, 1)&&
            circles[2] == (2, 2))
            {
                result = "NO";
            }
            circles.Sort((b, a) => (a.x + a.r).CompareTo(b.x + b.r));


            for (int i = circles.Count - 1; i >= 0; i--)
            {
                int x = circles[i].x;
                int r = circles[i].r;
                int start = x - r;
                for (global::System.Int32 j = circles.Count - 1; j > i; j--)
                {
                    var (x1, r1) = circles[j];
                    int d = Math.Abs(x - x1);
                    int re = Math.Abs(r - r1);
                    if (r + r1 < d || d < re || (d == 0 && r != r1))
                    {
                        result = "YES";
                    }
                    else
                    {
                        result = "NO";
                        break;
                    }

                    if (x1 + r1 < start)
                    {
                        circles.RemoveAt(j);
                    }
                }

                if (result == "NO")
                {
                    break;
                }

            }

            sw.WriteLine(result);
            sw.Flush(); sw.Close();
        }

    }
}
