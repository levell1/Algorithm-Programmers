
using System.Runtime.Versioning;

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static int R, T, C;
    static int up, down;
    static int[,] room;

    static int[] dx = { 0, 0, -1, 1 };
    static int[] dy = { -1, 1, 0, 0 };
    
    static Queue<(int r, int c)> dust;
    static Queue<(int r, int c)> purifier;
    static void Main()
    {
        int[] rct = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        R = rct[0];
        C = rct[1];
        T = rct[2];

        room = new int[R, C];

        List<int> purifier = new List<int>();
        

        dust = new Queue<(int, int)>();

        for (int i = 0; i < R; i++)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for (int j = 0; j < C; j++)
            {
                room[i, j] = line[j];
                if (line[j] == -1)
                {
                    purifier.Add(i);
                }

                if (line[j] > 0)
                {
                    dust.Enqueue((i, j));
                }
            }
        }

        up = purifier[0];
        down = purifier[1];

        Clear(T);
        //draw();

        int result =SumDust();
        sw.WriteLine(result);
        sw.Flush(); sw.Close();
    }

    static void Clear(int time) 
    {
        for (int i = 0; i < time; i++)
        {
            Spread();
            Circulation();
        }
    }

    static void Spread() 
    {
        int[,] next = new int[R, C];
        next[up, 0] = -1;
        next[down, 0] = -1;

        while (dust.Count>0)
        {
            var p = dust.Dequeue();
            for (int i = 0; i < 4; i++)
            {
                int nx = p.r + dx[i];
                int ny = p.c + dy[i];

                if (nx < 0 || ny < 0 || nx >= R || ny >= C)
                    continue;

                if (room[nx, ny] == -1)
                    continue;

                int spreadDust = room[p.r, p.c] / 5;
                next[nx, ny] += spreadDust;
                next[p.r, p.c] -= spreadDust;
            }
            next[p.r, p.c] += room[p.r,p.c];
        }
        room = next;
    }

    static void Circulation()
    {
        for (int r = up - 1; r > 0; r--)
        {
            room[r, 0] = room[r - 1, 0];
        }
        for (int c = 0; c < C - 1; c++)
        {
            room[0, c] = room[0, c + 1];
        }
        for (int r = 0; r < up; r++)
        {
            room[r, C - 1] = room[r + 1, C - 1];
        }
        for (int c = C - 1; c > 1; c--)
        {
            room[up, c] = room[up, c - 1];
        }
        room[up, 1] = 0;


        for (int r = down+1; r < R-1; r++)
        {
            room[r, 0] = room[r + 1, 0];
        }
        for (int c = 0; c < C-1; c++)
        {
            room[R - 1, c] = room[R - 1, c + 1];
        }
        for (int r = R-1; r > down; r--)
        {
            room[r, C - 1] = room[r - 1, C - 1];
        }
        for (int c = C-1; c > 1; c--)
        {
            room[down, c] = room[down, c - 1];
        }
        room[down, 1] = 0;

        DustEnqueue();
    }

    static void DustEnqueue() 
    {
        for (int i = 0; i < R; i++)
        {
            for (int j = 0; j < C; j++)
            {
                if (room[i, j] > 0)
                    dust.Enqueue((i, j));
            }
        }
    }
    static int SumDust()
    {
        int sum = 0;
        while (dust.Count > 0)
        {
            var d = dust.Dequeue();
            sum += room[d.r, d.c];
        }
        return sum;
    }

    static void draw()
    {
        Console.WriteLine();
        for (int i = 0; i < R; i++)
        {
            for (int j = 0; j < C; j++)
            {
                Console.Write($"{room[i, j]} ");
            }
            Console.WriteLine();
        }
    }


}
