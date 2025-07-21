
class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            int[] inputarr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int n = inputarr[0];
            int e = inputarr[1];

            var graph = new List<(int, int)>[n + 1];  // 그래프 인접리스트

            for (int i = 1; i <= n; i++)
            {
                graph[i] = new List<(int, int)>();
            }

            for (int i = 0; i < e; i++)
            {
                int[] edge = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

                graph[edge[0]].Add((edge[1], edge[2]));
                graph[edge[1]].Add((edge[0], edge[2]));        //양방향
            }

            int[] go = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int firstPoint = go[0];
            int secondPoint = go[1];

            long path1 = SumPathDist(graph, n, 1, firstPoint, secondPoint, n);
            long path2 = SumPathDist(graph, n, 1, secondPoint, firstPoint, n);

            long result = Math.Min(path1, path2);

            if (result >= int.MaxValue)
            {
                result = -1;
            }

            sw.WriteLine(result);
            sw.Flush(); sw.Close();

        }

    }

    static long SumPathDist(List<(int, int)>[] graph, int n, int start,int point1,int point2, int end) 
    {
        long d1 = Dijkstra(graph, n, 1, point1);
        long d2 = Dijkstra(graph, n, point1, point2);
        long d3 = Dijkstra(graph, n, point2, n);

        long dist = d1+d2+d3;

        return dist;
    }


    static long Dijkstra(List<(int, int)>[] graph,int n, int start, int end)
    {
        long[] dist = new long[n + 1];
        Array.Fill(dist, int.MaxValue);
        dist[start] = 0;

        var pq = new PriorityQueue<(int node, long cost), long>();          //우선순위 큐
        pq.Enqueue((start, 0), 0);

        while (pq.Count > 0)
        {
            var (current, currentCost) = pq.Dequeue();

            if (currentCost > dist[current]) continue;          // 현재 계산된 current 까지의 비용이 원래 current 까지의 비용보다 높으면 PASS

            foreach (var (next, cost) in graph[current])        // current와 연결된 노드 확인
            {
                long nextCost = currentCost + cost;
                if (nextCost < dist[next])                      // 현재 start~next까지의 비용이 원래값보다 작으면 
                {
                    dist[next] = nextCost;                      // 갱신
                    pq.Enqueue((next, nextCost), nextCost);     // pq에 추가, next와 연결된 다음경로 탐색
                }
            }
        }

        return dist[end];
    }

}