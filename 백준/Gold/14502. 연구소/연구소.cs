
using System.Security.AccessControl;

class Program
{
    static int[] input;
    static int[,] board;
    static int maxSafe;
    static int n, m;
    
    static List<(int, int)> empty = new();
    static List<(int, int)> virus = new();

    static readonly int[] dx = { -1, 1, 0, 0 };
    static readonly int[] dy = { 0, 0, -1, 1 };

    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        n = input[0];
        m = input[1];

        board = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            for (int j = 0; j < m; j++)
            {
                board[i, j] = line[j];

                if (line[j] == 0)
                {
                    empty.Add((i, j));
                }
                else if (line[j] == 2)
                {
                    virus.Add((i, j));
                }
            }
        }

        MakeWalls(0, 0);
        sw.Write(maxSafe);
        sw.Flush(); sw.Close();
    }

    static void MakeWalls(int start, int count) 
    {
        if (count == 3)
        {
            int[,] copy = (int[,])board.Clone();
            SpreadVirus(copy);
            int safe = CountSafe(copy);
            maxSafe = Math.Max(maxSafe, safe);
            return;
        }

        for (int i = start; i < empty.Count; i++)
        {
            var (x, y) = empty[i];
            board[x, y] = 1;
            MakeWalls(i + 1, count + 1);
            board[x, y] = 0;
        }
    }

    static int CountSafe(int[,] copy)
    {
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (copy[i,j] ==0)
                {
                    count++;
                }
            }
        }
        return count;
    }

    static void SpreadVirus(int[,] copyBoard)
    {
        Queue<(int, int)> q = new Queue<(int, int)>();

        foreach (var (x,y) in virus)
        {
            q.Enqueue((x, y));
        }

        while (q.Count>0)
        {
            var (x, y) = q.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];

                if (nx >= 0 && nx < n && ny >= 0 && ny < m && copyBoard[nx, ny] == 0)
                {
                    copyBoard[nx, ny] = 2;
                    q.Enqueue((nx, ny));
                }
            }
        }

    }
}