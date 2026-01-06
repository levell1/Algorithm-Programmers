
using System.ComponentModel.DataAnnotations;

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int n, m;
    static int[] parent;
    static void Main()
    {
        int[] nm = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
        n = nm[0];
        m = nm[1];
        parent = new int[n+1];

        List<(int u, int v, int w)> edges = new List<(int, int, int)>();

        for (int i = 0; i < m; i++)
        {
            int[] abc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = abc[0];
            int b = abc[1];
            int c = abc[2];
            edges.Add((a, b, c));
        }

        edges.Sort((x, y) => x.w.CompareTo(y.w));

        for (int i = 1; i <= n; i++)
        {
            parent[i] = i;
        }

        int result = 0;
        int max = 0;
        foreach (var edge in edges)
        {
            if (Union(edge.u, edge.v))
            {
                result += edge.w;
                max = edge.w;
            }
        }

        sw.WriteLine(result-max);

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


