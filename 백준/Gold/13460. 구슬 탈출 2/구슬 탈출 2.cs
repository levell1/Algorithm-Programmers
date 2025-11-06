
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static int n, m;
    static char[,] board;
    static bool[,,,] visited;
    static readonly int[] dx = { -1, 0, 1, 0 };
    static readonly int[] dy = { 0, -1, 0, 1 };


    static void Main()
    {
        int[] nm = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        n = nm[0];
        m = nm[1];

        int redX = 0;
        int redY = 0;

        int blueX = 0;
        int blueY = 0;

        int result = 0;

        board = new char[n, m];
        visited = new bool[n, m, n, m];

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < m; j++)
            {
                board[i, j] = line[j];
                if (line[j] =='R')
                {
                    redX = i;
                    redY = j;
                }
                if (line[j] == 'B')
                {
                    blueX = i;
                    blueY = j;
                }
            }
        }

        result = Roll(redX, redY, blueX, blueY);

        sw.WriteLine(result);
        sw.Flush(); sw.Close();
    }

    static int Roll(int rx,int ry,int bx,int by) 
    {
        Queue<(int rx, int ry, int bx, int by,int count)> que = new Queue<(int, int, int, int,int)>();
        que.Enqueue((rx, ry, bx, by, 0));
        visited[rx, ry, bx, by] = true;
        while (que.Count>0)
        {
            var (crx, cry, cbx, cby, count) = que.Dequeue();
            if (count>= 10)
            {
                continue;
            }

            for (int i = 0; i < 4; i++)
            {

                (int nrx, int nry, int rCount) = Move(crx, cry, i);
                (int nbx, int nby, int bCount) = Move(cbx, cby, i);

                if (board[nbx, nby] == 'O') continue;
                if (board[nrx, nry] == 'O') return count + 1;

                if (nrx == nbx && nry == nby)
                {
                    if (rCount > bCount)
                    {
                        nrx -= dx[i];
                        nry -= dy[i];
                    }
                    else
                    {
                        nbx -= dx[i];
                        nby -= dy[i];
                    }
                }

                if (!visited[nrx, nry, nbx, nby])
                {
                    visited[nrx, nry, nbx, nby] = true;
                    que.Enqueue((nrx, nry, nbx, nby, count + 1));
                }

            }
        }
        return -1;
    }

    static (int, int, int) Move(int x, int y, int dir) 
    {
        int count = 0;
        while (true)
        {
            int nx = x + dx[dir];
            int ny = y + dy[dir];
            if (board[nx, ny] == '#') break;
            x = nx; y = ny; count++;
            if (board[nx, ny] == 'O') break;
        }
        return (x, y, count);
    }

}
