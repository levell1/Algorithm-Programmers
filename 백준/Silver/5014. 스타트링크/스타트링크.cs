
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int f,s,g,u,d;
    static bool[] visited;


    static void Main()
    {
        int[] FSGUD = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        f = FSGUD[0];
        s = FSGUD[1];
        g = FSGUD[2];
        u = FSGUD[3];
        d = FSGUD[4];
        //층건물 f 현 s 목표 g  

        visited = new bool[f + 1];

        int result =BFS(s);

        sw.WriteLine(result == -1 ? "use the stairs" : $"{result}");
        sw.Flush(); sw.Close();
    }

    static int BFS(int start) 
    {
        Queue<(int,int)> que = new Queue<(int, int)>();
        que.Enqueue((start,0));
        while (que.Count > 0) 
        {
            var (cur,count) = que.Dequeue();
            if (cur==g)
            {
                return count;
            }
            if (cur + u <= f)
            {
                if (!visited[cur + u])
                {
                    que.Enqueue((cur + u, count + 1));
                    visited[cur + u] = true;
                }
            }

            if (cur - d> 0)
            {
                if (!visited[cur - d])
                {
                    que.Enqueue((cur - d, count + 1));
                    visited[cur -d] = true;
                }
            }
        }
        return -1;
    }
}
