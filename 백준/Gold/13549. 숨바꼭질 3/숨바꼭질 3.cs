
class Program
{
    static void Main()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int N = input[0];
        int K = input[1];

        int max = 100000; 
        int[] dist = new int[max + 1];
        Array.Fill(dist, int.MaxValue);
        dist[N] = 0;

        Console.WriteLine(Dijkstra(N, K, dist));
    }

    static int Dijkstra(int start, int end, int[] dist)
    {
        var pq = new PriorityQueue<(int position, int time), int>();
        pq.Enqueue((start, 0), 0);

        while (pq.Count > 0)
        {
            var (current, currentTime) = pq.Dequeue();

            if (currentTime > dist[current]) continue;

            // 3가지 이동 방식 처리
            int[] nextPositions = { current - 1, current + 1, current * 2 };
            int[] costs = { 1, 1, 0 };

            for (int i = 0; i < 3; i++)
            {
                int next = nextPositions[i];
                int nextCost = currentTime + costs[i];

                if (next >= 0 && next <= 100000 && nextCost < dist[next])
                {
                    dist[next] = nextCost;
                    pq.Enqueue((next, nextCost), nextCost);
                }
            }
        }

        return dist[end];
    }
}
