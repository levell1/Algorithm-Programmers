

using System.Reflection;

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static int N,M;
    static int a,b,c ;
    static int[] parent;

    static void Main()
    {
        N = int.Parse(Console.ReadLine());
        M = int.Parse(Console.ReadLine());

        List<(int u, int v, int c)> edges = new List<(int u, int v, int c)>();

        for (int i = 0; i < M; i++)
        {
            int[] abc = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            a = abc[0];
            b = abc[1];
            c = abc[2];
            edges.Add((a, b, c));
        }

        edges.Sort((x, y) => x.c.CompareTo(y.c));

        parent = new int[N + 1];
        for (int i = 1; i <= N; i++)
        {
            parent[i] = i;
        }

        int result = 0;
        foreach (var edge in edges)
        {
            if (Union(edge.u, edge.v))
            {
                result += edge.c;
            }
        }

        sw.WriteLine(result);


        sw.Flush(); sw.Close();
    }

    static int Find(int x)
    {
        if (parent[x] != x)
        {
            parent[x] = Find(parent[x]);
        }
        return parent[x];
    }

    static bool Union(int a, int b)
    {
        a = Find(a);
        b = Find(b);

        if (a == b)
        {
            return false;
        }
        parent[b] = a;
        return true;
    }

}
