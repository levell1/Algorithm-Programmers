class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static int[,] graph;

    static int n ;
    static int m ;

    static void Main()
    {
        n = Convert.ToInt32(Console.ReadLine());
        m = Convert.ToInt32(Console.ReadLine());

        graph = new int[n+1,n+1];
        int INF = 100000001;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                graph[i, j] = (i == j) ? 0 : INF;
            }
        }

        for (int i = 0; i < m; i++)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
            int start = input[0];
            int end = input[1];
            int cost = input[2];

            graph[start, end] = Math.Min(graph[start, end], cost);
        }

        for (int k = 1; k <= n; k++)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    graph[i, j] = Math.Min(graph[i, j], graph[i, k] + graph[k, j]);
                }
            }
        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                sw.Write(graph[i, j]==INF? 0+" ":graph[i, j]+" ");
            }
            sw.WriteLine();
        }
        
        sw.Flush(); sw.Close();
    }
}
