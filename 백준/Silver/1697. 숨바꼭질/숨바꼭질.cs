class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        int n = input[0];
        int k = input[1];

        int[] graph = new int[100001];
        bool[] visited = new bool[100001];

        graph[n] = 1;


        bfs(n);

        void bfs(int start) 
        {
            visited[start] = true;
            Queue<int> q = new Queue<int>();
            q.Enqueue(start);

            while (q.Count > 0)
            {
                int cur = q.Dequeue();
                if (cur == k)
                {
                    break;
                }
                if (cur - 1 >= 0 && !visited[cur - 1])
                {

                    visited[cur - 1] = true;
                    graph[cur - 1] = graph[cur] + 1;
                    q.Enqueue(cur - 1);

                }
                if (cur + 1 < 100001 && !visited[cur + 1])
                {

                    visited[cur + 1] = true;
                    graph[cur + 1] = graph[cur] + 1;
                    q.Enqueue(cur + 1);

                }

                if (cur * 2 < 100001 && !visited[cur * 2])
                {
                    visited[cur * 2] = true;
                    graph[cur * 2] = graph[cur] + 1;
                    q.Enqueue(cur * 2);
                }
            }
        }

        sw.Write($"{graph[k]-1}");

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}