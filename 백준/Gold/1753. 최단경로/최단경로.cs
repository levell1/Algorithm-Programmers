
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            long INF = int.MaxValue;

            int[] inputarr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int n = inputarr[0];
            int e = inputarr[1];

            int startNode = Convert.ToInt32(Console.ReadLine());

            var graph = new List<(int, int)>[n + 1];  

            for (int i = 1; i <= n; i++)
            {
                graph[i] = new List<(int, int)>();
            }

            for (int i = 0; i < e; i++)
            {
                int[] edge = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

                graph[edge[0]].Add((edge[1], edge[2]));
            }


            long[] result = new long[n+1];
            result = Dijkstra(graph, n, startNode);

            for (int i = 1; i < n+1; i++)
            {
                sw.WriteLine(result[i] >= INF ? "INF" : result[i]);
            }

            sw.Flush(); sw.Close();

        }

    }


    static long[] Dijkstra(List<(int, int)>[] graph,int n, int start)
    {
        long[] dist = new long[n + 1];
        Array.Fill(dist, int.MaxValue);
        dist[start] = 0;

        var pq = new PriorityQueue<(int node, long cost), long>();          
        pq.Enqueue((start, 0), 0);

        while (pq.Count > 0)
        {
            var (current, currentCost) = pq.Dequeue();

            if (currentCost > dist[current]) continue;          

            foreach (var (next, cost) in graph[current])        
            {
                long nextCost = currentCost + cost;
                if (nextCost < dist[next])                       
                {
                    dist[next] = nextCost;                      
                    pq.Enqueue((next, nextCost), nextCost);     
                }
            }
        }

        return dist;
    }

}