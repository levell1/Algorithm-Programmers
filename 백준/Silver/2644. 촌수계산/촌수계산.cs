

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static List<int>[] list;
    static bool[] visited;
    static int start, end;
    static int result;
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        visited = new bool[n + 1];
        list = new List<int>[n + 1];

        int[] input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        start = input[0];
        end = input[1];

        int m = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= n; i++)
        {
            list[i] = new List<int>();
        }

        for (int i = 0; i < m; i++)
        {
            int[] nodes = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            list[nodes[0]].Add(nodes[1]);
            list[nodes[1]].Add(nodes[0]);
        }

        BFS();

        sw.WriteLine(result);
        
        sw.Flush(); sw.Close();
    }

    static void BFS() 
    {
        Queue<(int node,int count)> que = new Queue<(int, int)>();
        que.Enqueue((start, 0));
        visited[start] = true;
        bool possible = false;
        while (que.Count>0)
        {
            (int cur,int count) = que.Dequeue();

            if (cur == end)
            {
                result = count;
                possible = true;
                return;
            }

            foreach (var next in list[cur])
            {
                if (!visited[next])
                {
                    que.Enqueue((next, count + 1));
                    visited[next] = true;
                }
            }

        }
        if (!possible)
        {
            result = -1;
        }
    }

}
