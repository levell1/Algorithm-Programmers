
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

            sw.WriteLine($"{Dijkstra(N, K, max)}");
            sw.Flush(); sw.Close();

        }

        static int Dijkstra(int start, int end, int max)
        {
            int[] dist = new int[max+1];
            Array.Fill(dist, int.MaxValue);
            dist[start] = 0;

            var queue = new PriorityQueue <(int,int),int>();
            queue.Enqueue((start, 0),0);

            while( queue.Count > 0 ) 
            {
                var (curpos , curcost) = queue.Dequeue();
                if (curcost > dist[curpos]) continue;
                int[] nextPos= new int[3] { curpos - 1, curpos + 1, curpos * 2 };
                int[] nextCost = new int[3] { curcost+1, curcost+1, curcost+0 };

                for (int i = 0; i < 3; i++)
                {
                    if (nextPos[i] >= 0&& nextPos[i] <= max && nextCost[i] < dist[nextPos[i]])
                    {
                        dist[nextPos[i]] = nextCost[i];
                        queue.Enqueue((nextPos[i],nextCost[i]),nextCost[i]);
                    }
                }
            }
            return dist[end];
        }
    }
}
