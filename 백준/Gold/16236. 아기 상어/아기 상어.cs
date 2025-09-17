

using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int n;
    static int result = 0;
    static int[,] field;
    static int size = 2;
    static int sizeupFeed = 2;
    static readonly int[] dx = new int[4] { 0, -1, 1, 0 };
    static readonly int[] dy = new int[4] { -1, 0, 0, 1 };

    static void Main()
    {

        n = int.Parse(Console.ReadLine());
        field = new int[n, n];
        (int, int) startPos = (0, 0);

        for (int i = 0; i < n; i++)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int j = 0; j < n; j++)
            {
                field[i, j] = line[j];
                if (line[j] == 9)
                {
                    startPos = (i, j);
                    field[i, j] = 0;
                }
            }
        }

        while (true)
        {
            var target = BFS(startPos);
            if (target == (0, 0, 0))
            {
                break;
            }

            result += target.dist;
            sizeupFeed--;
            if (sizeupFeed == 0)
            {
                size++;
                sizeupFeed = size;
            }

            field[target.a, target.b] = 0;
            startPos = (target.a, target.b);
        }

        sw.WriteLine(result);
        sw.Flush(); sw.Close();
    }



    static (int a, int b, int dist) BFS((int a, int b) start)
    {
        Queue<(int a, int b, int count)> que = new Queue<(int, int, int)>();
        que.Enqueue((start.a, start.b, 0));
        bool[,] visited = new bool[n, n];
        visited[start.a, start.b] = true;

        List<(int a, int b, int dist)> feeds = new List<(int, int, int)>();
        int mindist = int.MaxValue;

        while (que.Count > 0)
        {
            var cur = que.Dequeue();

            if (cur.count > mindist)
            {
                continue;
            }
            for (int i = 0; i < 4; i++)
            {
                int na = cur.a + dx[i];
                int nb = cur.b + dy[i];
                if (na < 0 || nb < 0 || na >= n || nb >= n)
                {
                    continue;
                }
                if (field[na, nb] > size)
                {
                    continue;
                }
                if (visited[na, nb])
                {
                    continue;
                }

                visited[na, nb] = true;
                int nd = cur.count + 1;

                if (field[na, nb] != 0 && field[na, nb] < size)
                {
                    if (nd <= mindist)
                    {
                        mindist = nd;
                        feeds.Add((na, nb, nd));
                    }
                }
                que.Enqueue((na, nb, nd));
            }
        }
        if (feeds.Count == 0)
        {
            return (0, 0, 0);
        }

        feeds.Sort((a, b) =>
        {
            if (a.dist != b.dist) return a.dist.CompareTo(b.dist);
            if (a.a != b.a) return a.a.CompareTo(b.a);
            return a.b.CompareTo(b.b);
        });

        return feeds[0];
    }
}

