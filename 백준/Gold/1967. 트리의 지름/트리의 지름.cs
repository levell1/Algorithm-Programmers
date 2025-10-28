
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static List<(int, int)>[] tree;
    static bool[] visited;
    static int maxDist;
    static int farNode;
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n==1)
        {
            Console.WriteLine(0);
            return;
        }
        tree = new List<(int, int)>[n + 1];
        visited = new bool[n + 1];

        for (int i = 1; i <= n; i++)
        {
            tree[i] = new List<(int, int)>();
        }

        for (int i = 1; i < n; i++)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int parent = input[0];
            int child = input[1];
            int dist = input[2];
            tree[parent].Add((child, dist));
            tree[child].Add((parent, dist));
        }

        visited = new bool[n + 1];
        DFS(1, 0);

        visited = new bool[n + 1];
        maxDist = 0;
        DFS(farNode, 0);


        sw.WriteLine(maxDist);
        sw.Flush(); sw.Close();
    }

    static void DFS(int node,int d) 
    {
        visited[node] = true;
        if (d>maxDist)
        {
            maxDist = d;
            farNode = node;
        }

        foreach (var (next,dist) in tree[node])
        {
            if (!visited[next])
            {
                DFS(next, d + dist);
            }
        }
    }
}
