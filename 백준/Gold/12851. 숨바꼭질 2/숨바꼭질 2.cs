

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int n, k;
    static (int, int)[] graph;
    
    static void Main()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        n = input[0];
        k = input[1];

        graph = new (int, int)[100001];

        graph[n] = (1,1);


        bfs(n);
        sw.WriteLine(graph[k].Item1 -1);
        sw.WriteLine(graph[k].Item2);
        sw.Flush(); sw.Close();
    }

    static void bfs(int start)
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(start);

        while (q.Count > 0)
        {
            int cur = q.Dequeue();
            int dist = graph[cur].Item1;
            int count = graph[cur].Item2;

            int[] next = { cur - 1, cur + 1, cur * 2 };

            foreach (var nx in next)
            {
                if (nx < 0 || nx > 100000)
                {
                    continue;
                }

                if (graph[nx].Item1 == 0)
                {
                    graph[nx] = (dist + 1, count);
                    q.Enqueue(nx);
                }
                else if (graph[nx].Item1 == dist + 1)
                {
                    graph[nx].Item2 += count;
                }
            }

           
        }
    }

}
