
class Program
{
    static int[] input;
    static int N, M;

    static int[,] map;

    static readonly int[] dx = new int[4] { 0, 0, -1, 1 };
    static readonly int[] dy = new int[4] { 1, -1, 0, 0 };

    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        N = input[0];
        M = input[1];

        map = new int[N, M];
        for (int i = 0; i < N; i++)
        {
            string str = Console.ReadLine();
            int[] line = str.Select(ch => ch - '0').ToArray();
            for (int j = 0; j < M; j++)
            {
                map[i, j] = line[j];
            }
        }


        sw.WriteLine(BFS());
        sw.Flush(); sw.Close();
    }

    static int BFS()
    {
        Queue<(int x, int y, int wall, int count)> que = new Queue<(int x, int y, int wall, int count)>();
        que.Enqueue((0, 0, 0, 1));
        bool[,,] visited = new bool[N, M, 2];

        while (que.Count > 0)
        {
            (int x, int y, int wall, int count) = que.Dequeue();
            if (x == N - 1 && y == M - 1)
                return count;

            for (int i = 0; i < 4; i++)
            {
                int nx = dx[i] + x;
                int ny = dy[i] + y;

                if (nx >= 0 && nx < N && ny >= 0 && ny < M)
                {
                    if (!visited[nx, ny, wall] && map[nx, ny] == 0)
                    {
                        visited[nx, ny, wall] = true;
                        que.Enqueue((nx, ny, wall, count + 1));
                    }
                    else if (map[nx, ny] == 1 && wall == 0 && !visited[nx, ny, 1])
                    {
                        visited[nx, ny, 1] = true;
                        que.Enqueue((nx, ny, 1, count + 1));
                    }
                }
            }
        }
        return -1;
    }
}
