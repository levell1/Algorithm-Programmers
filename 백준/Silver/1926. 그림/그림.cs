class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static int[] dx = { -1, 1, 0, 0 };
    static int[] dy = { 0, 0, -1, 1 };

    static int n, m;
    static int count;
    static int max;

    static bool[,] visited;
    static int[,] paper;
    static void Main()
    {
        int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        n = nm[0];
        m = nm[1];

        paper = new int[n, m];
        visited = new bool[n, m];

        List<(int, int)> area = new List<(int, int)>();

        count = 0;
        max = 0;
        for (int i = 0; i < n; i++)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int j = 0; j < m; j++)
            {
                paper[i, j] = line[j];
                if (line[j]==1)
                {
                    area.Add((i, j));
                }
                
            }
        }

        foreach ((int a,int b) color in area)
        {
            if (!visited[color.a,color.b])
            {
                BFS(color.a, color.b);
            }
            
        }

        sw.WriteLine(count);
        sw.WriteLine(max);
        sw.Flush(); sw.Close();
    }

    static void BFS(int x, int y) 
    {
        Queue<(int a, int b)> que = new Queue<(int, int)>();
        que.Enqueue((x, y));
        visited[x, y] = true;
        int size = 1;
        while (que.Count>0)
        {
            var pos = que.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                int nx = dx[i] + pos.a;
                int ny = dy[i] + pos.b;

                if (nx >= 0 && ny >= 0 && nx < n && ny < m)
                {
                    if (paper[nx,ny]==1)
                    {
                        if (!visited[nx, ny])
                        {
                            que.Enqueue((nx, ny));
                            visited[nx, ny] = true;
                            size++;
                        }
                    }
                    
                }
            }
        }
        max = Math.Max(max, size);
        count++;
    }
}

