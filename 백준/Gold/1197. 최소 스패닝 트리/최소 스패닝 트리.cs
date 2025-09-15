

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static int[] parent;

    static void Main()
    {

        int[] ve = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int V = ve[0];
        int E = ve[1];

        List<(int u, int v, int w)> edges = new List<(int, int, int)>();

        for (int i = 0; i < E; i++)
        {
            int[] abc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = abc[0];
            int b = abc[1];
            int c = abc[2];
            edges.Add((a, b, c));
        }

        edges.Sort((x, y) => x.w.CompareTo(y.w));

        parent = new int[V + 1];
        for (int i = 1; i <= V; i++)
        {
            parent[i] = i;
        }

        long result = 0;
        foreach (var edge in edges)
        {
            if (Union(edge.u,edge.v))
            {
                result += edge.w;
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
