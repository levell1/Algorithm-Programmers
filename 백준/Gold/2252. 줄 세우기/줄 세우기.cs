
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
        int n = input[0];
        int m = input[1];

        List<int>[] graph = new List<int>[n+1];
        int[] indegree = new int[n + 1];

        for (int i = 1; i <= n; i++)
        {
            graph[i] = new List<int>();
        }

        for (int i = 0; i < m; i++)
        {
            int[] ab = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
            int a = ab[0];
            int b = ab[1];

            graph[a].Add(b);
            indegree[b]++;
        }

        Queue<int> que = new Queue<int>();
        for (int i = 1; i <= n; i++)
        {
            if (indegree[i]==0)
            {
                que.Enqueue(i);
            }
        }

        List<int> result = new List<int>();

        while (que.Count>0)
        {
            int now = que.Dequeue();
            result.Add(now);
            foreach (int next in graph[now])
            {
                indegree[next]--;
                if (indegree[next]==0)
                {
                    que.Enqueue(next);
                }
            }
        }

        sw.WriteLine(string.Join(" ",result));
        sw.Flush(); sw.Close();
    }

    
}
