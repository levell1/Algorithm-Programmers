

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static int N, L, R;

    static int[,] land;
    static bool[,] visited;

    static bool isMig;
    static int count;

    static readonly int[] dr = { -1, 1, 0, 0 };
    static readonly int[] dc = { 0, 0, -1, 1 };
    static void Main()
    {

        int[] NLR = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        N = NLR[0];
        L = NLR[1];
        R = NLR[2];

        land = new int[N, N];
        visited = new bool[N, N];

        for (int i = 0; i < N; i++)
        {
            int[] rc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int j = 0; j < N; j++)
            {
                land[i, j] = rc[j];
            }
        }
        isMig = true;
        while (isMig)
        {
            isMig = false;
            Array.Clear(visited,0, visited.Length);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (!visited[i, j])
                    {
                        Migration(i, j);
                    }
                }
            }
            if (isMig)
            {
                count++;
            }
        }

        sw.WriteLine(count);
        sw.Flush(); sw.Close();
    }

    static void Migration(int startR, int startC)
    {
        Queue<(int, int)> que = new Queue<(int, int)>();
        que.Enqueue((startR, startC));

        List<(int, int)> list = new List<(int, int)>();
        list.Add((startR, startC));

        int sum = land[startR,startC];
        visited[startR, startC] = true;

        while (que.Count > 0)
        {
            var (cr, cc) = que.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                int nr = cr + dr[i];
                int nc = cc + dc[i];
                if (nr >= 0 && nc >= 0 && nr < N && nc < N && !visited[nr,nc])
                {
                    int dif = Math.Abs(land[cr, cc] - land[nr, nc]);
                    if (L <= dif && R >= dif)
                    {
                        list.Add((nr, nc));
                        sum += land[nr, nc];
                        visited[nr, nc] = true;
                        que.Enqueue((nr, nc));
                        isMig = true;
                    }
                }
            }
        }
        foreach ((int r,int c) in list)
        {
            land[r, c] = sum / list.Count;
        }
    }
}
