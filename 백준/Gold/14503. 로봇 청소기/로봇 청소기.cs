
class Program
{
    static int[] input;
    static int N, M;
    static int x, y,dir;

    static int[,] map;
    static bool[,] clean;
    static readonly int[] dx = new int[4] { -1, 0, 1, 0 };
    static readonly int[] dy = new int[4] { 0, 1, 0, -1 };

    static int count;

    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        N = input[0];
        M = input[1];

        map = new int[N, M];

        int[] position = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        x = position[0];
        y = position[1];
        dir = position[2];

        clean = new bool[N, M];

        for (int i = 0; i < N; i++)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            for (int j = 0; j < M; j++)
            {
                map[i, j] = line[j];
            }
        }

        Clean();
        sw.WriteLine(count);
        sw.Flush(); sw.Close();
    }

    static void Clean()
    {

        while (true)
        {
            if (!clean[x, y])
            {
                clean[x, y] = true;
                count++;
            }
            bool cleanCheck = false;

            for (int i = 0; i < 4; i++)
            {
                dir = (dir + 3) % 4;
                int nx = dx[dir] + x;
                int ny = dy[dir] + y;

                if (nx >= 0 && nx < N && ny >= 0 && ny < M)
                {
                    if (!clean[nx, ny] && map[nx, ny] == 0)
                    {
                        x = nx;
                        y = ny;
                        cleanCheck = true;
                        break;
                    }
                }
            }

            if (cleanCheck)
                continue;
            

            if (!cleanCheck)
            {
                int bx = x - dx[dir];
                int by = y - dy[dir];
                if (bx >= 0 && bx < N && by >= 0 && by < M && map[bx, by] == 0)
                {
                    x = bx;
                    y = by;
                }
                else
                {
                    break;
                }

            }
        }
    }
}
