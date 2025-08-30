
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static bool[,] visited;

    static readonly int[] dx = { 0, 0, 1, -1 };
    static readonly int[] dy = { 1, -1, 0, 0 };

    static int m ;
    static int n ;
    static int k ;

    static void Main()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);

        m = input[0];
        n = input[1];
        k = input[2];

        visited = new bool[n, m];

        List<int> results = new List<int>();

        for (int i = 0; i < k; i++)
        {
            int[] square = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);

            for (int j = square[0]; j < square[2]; j++)
            {
                for (int l = square[1]; l < square[3]; l++)
                {
                    visited[j, l] = true;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (!visited[i,j])
                {
                    results.Add(BFS(i, j));
                }
            }
        }

        results.Sort();
        sw.WriteLine(results.Count);
        sw.WriteLine(string.Join(" ", results));
        sw.Flush(); sw.Close();
    }

    static int BFS(int x, int y) 
    {
        Queue<(int, int)> que = new Queue<(int, int)>();
        que.Enqueue((x, y));
        visited[x, y] = true;
        int extent = 1;
        while (que.Count>0)
        {
            var (curx,cury) = que.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                int nx = curx + dx[i];
                int ny = cury + dy[i];
                if (nx >= 0 && nx < n && ny >= 0 && ny < m)
                {
                    if (!visited[nx,ny])
                    {
                        visited[nx, ny] = true;
                        que.Enqueue((nx, ny));
                        extent++;
                    }
                }
            }
        }
        return extent;
    }
}
