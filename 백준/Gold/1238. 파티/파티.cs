
using System.Xml.Linq;

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static int[] come;
    static int[] back;
    static int N, M, X;
    static List<(int, int)>[] node, renode;
    static void Main()
    {

        int[] NMX = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        N = NMX[0];
        M = NMX[1];
        X = NMX[2];

        node = new List<(int, int)>[N + 1];
        renode = new List<(int, int)>[N + 1];

        for (int i = 1; i < N+1; i++)
        {
            node[i] = new List<(int, int)>();
            renode[i] = new List<(int, int)>();
        }

        for (int i = 0; i < M; i++)
        {
            int[] edge = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int start = edge[0];
            int end = edge[1];
            int cost = edge[2];
            node[start].Add((end, cost));
            renode[end].Add((start, cost));
        }

        ComeAndBack();

        int[] result = new int[N + 1];
        for (int i = 1; i < N+1; i++)
        {
            result[i] = come[i] + back[i];
        }

        sw.WriteLine(result.Max());
        sw.Flush(); sw.Close();
    }
    static int[] Dijkstra(int[] dist,List<(int, int)>[] graph, int start)
    {
        var pq = new PriorityQueue<(int, int), int>();          
        pq.Enqueue((start, 0), 0);

        while (pq.Count > 0)
        {
            var (current, currentCost) = pq.Dequeue();

            if (currentCost > dist[current]) continue;         

            foreach (var (next, cost) in graph[current])       
            {
                int nextCost = currentCost + cost;
                if (nextCost < dist[next])                     
                {
                    dist[next] = nextCost;                     
                    pq.Enqueue((next, nextCost), nextCost);    
                }
            }
        }
        return dist;
    }

    static void ComeAndBack() 
    {
        come = new int[N + 1];
        Array.Fill(come, int.MaxValue);
        come[X] = 0;
        come[0] = 0;

        come = Dijkstra(come, renode, X);

        back = new int[N + 1];
        Array.Fill(back, int.MaxValue);
        back[X] = 0;
        back[0] = 0;

        back = Dijkstra(back, node, X);
    }
}


