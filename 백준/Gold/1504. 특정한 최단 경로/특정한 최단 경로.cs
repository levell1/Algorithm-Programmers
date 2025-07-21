
using System.Text;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            int[] inputarr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

            int node = inputarr[0];
            int link = inputarr[1];

            var graph = new List<(int, int)>[node + 1];  // 그래프 인접리스트

            for (int i = 1; i <= node; i++)
            {
                graph[i] = new List<(int, int)>();
            }

            for (int i = 0; i < link; i++)
            {
                int[] info = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
                int curStart = info[0];
                int curEnd = info[1];
                int cost = info[2];

                graph[curStart].Add((curEnd, cost));
                graph[curEnd].Add((curStart, cost));
            }

         

            int[] go = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int firstPoint = go[0];
            int secondPoint = go[1];

            long tofirst = Dijkstra(graph, node, 1, firstPoint);
            long firstToSecond = Dijkstra(graph, node, firstPoint, secondPoint);
            long SecondtoLast = Dijkstra(graph, node, secondPoint, node);

            long path1 = tofirst + firstToSecond + SecondtoLast;

            long toSecond = Dijkstra(graph, node, 1, secondPoint);
            long SecondtoFirst= Dijkstra(graph, node, secondPoint, firstPoint);
            long FirsttoLast2 = Dijkstra(graph, node, firstPoint, node);

            long path2 = toSecond + SecondtoFirst + FirsttoLast2;

            long result = Math.Min(path1, path2);

            if (result >= int.MaxValue)
            {
                result = -1;
            }

            sw.WriteLine(result);
            sw.Flush(); sw.Close();

        }

    }


    static long Dijkstra(List<(int, int)>[] graph,int n, int start, int end)
    {
        long[] dist = new long[n + 1];
        Array.Fill(dist, int.MaxValue);
        dist[start] = 0;

        var pq = new PriorityQueue<(int, int), int>();          //우선순위 큐
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
                    pq.Enqueue((next, (int)nextCost), (int)nextCost);     // pq에 추가, next와 연결된 다음경로 탐색
                }
            }
        }

        return dist[end];
    }

}