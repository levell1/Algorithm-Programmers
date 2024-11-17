using System.Security;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        int N = input[0];
        int M = input[1];

        bool[] visited = new bool[N+1];
        int result = 0;
        List<int>[] nodes = new List<int>[N+1];

        for (int i = 1; i <= N; i++)
        {
            nodes[i]= new List<int>();
        }


        for (int i = 0; i < M; i++)
        {
            int[] utov = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            int u = utov[0];
            int v = utov[1];
            nodes[u].Add(v);
            nodes[v].Add(u);
        }

        for (int i = 1; i <= N; i++)
        {
            if (!visited[i])
            {
                DFS(i);
                result++;
            }
        }


        void BFS(int node) 
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(node);
            visited[node] = true;
            while (queue.Count > 0)
            {
                int x =queue.Dequeue();
                foreach (var next in nodes[x])
                {
                    if (!visited[next])
                    {
                        visited[next] = true;
                        queue.Enqueue(next);
                    }
                }
            }
        }

        void DFS(int node)
        {

            visited[node] = true;

            foreach (var next in nodes[node])
            {
                if (!visited[next])
                {
                    visited[next] = true;
                    DFS(next);
                }
            }
            
        }


        Console.WriteLine(result);
    }
}
