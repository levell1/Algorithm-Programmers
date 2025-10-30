

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static int n, m;
    static int[,] area;
    static int[,] meltCount;
    static bool[,] visited;

    static int[] dx = { -1, 1, 0, 0 };
    static int[] dy = { 0, 0, -1, 1 };
    static void Main()
    {
        int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        n = nm[0];
        m = nm[1];

        area = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int j = 0; j < m; j++)
            {
                area[i, j] = line[j];
            }
        }

        int time = 0;

        while (true)
        {
            meltCount = new int[n, m];
            visited = new bool[n, m];
            int landCount = LandCheck();
            if (landCount>=2)
            {
                break;
            }
            if (landCount ==0)
            {
                time = 0;
                break;
            }

            Melt();
            time++;
        }

        sw.WriteLine(time);
        sw.Flush(); sw.Close();
    }

    static int LandCheck() 
    {
        int land = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (area[i, j] > 0 && !visited[i, j])
                {
                    DFS(i, j);
                    land++;
                }
            }
        }
        return land;
    }

    static void DFS(int x,int y) 
    {
        visited[x, y] = true;
        for (int i = 0; i < 4; i++)
        {
            int nx = dx[i] + x;
            int ny = dy[i] + y;

            if (nx >= 0 && ny >= 0 && nx < n && ny < m)
            {
                if (area[nx,ny]==0)
                {
                    meltCount[x, y]++;
                }else if (!visited[nx, ny])
                {
                    DFS(nx, ny);
                }
            }
        }
    }

    static void Melt()
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (area[i, j] > 0)
                {
                    area[i, j] = Math.Max(0, area[i, j] - meltCount[i, j]);
                }
            }
        }
    }

}
