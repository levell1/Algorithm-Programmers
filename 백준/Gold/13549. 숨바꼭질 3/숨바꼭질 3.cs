using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            //int T = Convert.ToInt32(Console.ReadLine());
            int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int N = inputArr[0];
            int K = inputArr[1];

            int max = 100000;

            var graph = new List<(int, int)>[max + 1];

            graph[0] = new List<(int, int)>();
            graph[0].Add((1, 1));
            graph[max] = new List<(int, int)>();
            graph[max].Add((max - 1, 1));

            for (int i = 1; i < max; i++)
            {
                graph[i] = new List<(int, int)>();
                graph[i].Add((i - 1, 1));
                graph[i].Add((i + 1, 1));
                if (i*2<= max)
                {
                    graph[i].Add((i * 2, 0));
                }
            }

            int[] dist = new int[max+1];
            Array.Fill(dist, int.MaxValue);
            dist[N] = 0;

            sw.WriteLine($"{Dijkstra(dist, graph, N, K)}");
            sw.Flush(); sw.Close();


            int Dijkstra(int[] dist, List<(int, int)>[] graph, int start, int end)
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

                return dist[end];
            }
        }
    }
}
