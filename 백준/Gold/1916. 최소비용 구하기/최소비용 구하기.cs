
class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            int cityT = Convert.ToInt32(Console.ReadLine());
            //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int busT = Convert.ToInt32(Console.ReadLine());

            var graph = new List<(int, int)>[cityT+1];

            int[] dist = new int[cityT+1];
            Array.Fill(dist, int.MaxValue);

            for (int i = 1; i <= cityT; i++)
            {
                graph[i] = new List<(int, int)>();
            }

            for (int i = 0; i < busT; i++)
            {
                int[] info = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
                int busStart = info[0];
                int busEnd = info[1];
                int cost = info[2];

                graph[busStart].Add((busEnd,cost));
            }


            int[] go = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int start = go[0];
            int end = go[1];

            int result = Dijkstra(dist, graph, start, end);
            sw.WriteLine(result);
            sw.Flush(); sw.Close();

        }

    }

    static int Dijkstra(int[] dist , List<(int, int)>[] graph, int start, int end)
    {

        dist[start] = 0;

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
