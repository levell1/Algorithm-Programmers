using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int N, M;
    static List<(int, int, int)> cam;
    static int[] dx = { -1, 0, 1, 0 };
    static int[] dy = { 0, 1, 0, -1 };
    static int[,] room;
    static int min;
    static void Main()
    {

        int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        N = NM[0];
        M = NM[1];

        room = new int[N, M];

        min = N*M;
        cam = new List<(int, int,int)>();

        for (int i = 0; i < N; i++)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int j = 0; j < M; j++)
            {
                room[i, j] = line[j];
                if (line[j] != 0)
                {
                    if (line[j]!=6)
                    {
                        cam.Add((i, j, line[j]));
                    }
                }
            }
        }

        Rotation(0);

        sw.WriteLine(min);
        sw.Flush(); sw.Close();
    }

    static int MaxCount() 
    {
        int count=0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                if (room[i, j] == 0)
                    count++;
            }
        }
        return count;
    }

    static void Draw() 
    {
        Console.WriteLine();
        for (int i = 0; i < N; i++)
        {

            for (int j = 0; j < M; j++)
            {
                Console.Write($"{room[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Rotation(int i) 
    {
        if (i==cam.Count)
        {
            int cur = MaxCount();
            min = Math.Min(min, cur);
            return;
        }

        var a = cam[i];
        int num = a.Item3;

        for (int j = 0; j < 4; j++)
        {
            int x = a.Item1;
            int y = a.Item2;
            if (num == 2 && j >= 2)
            {
                return;
            }
            if (num ==5 && j>=1)
            {
                return;
            }
            LookDir(x, y, j, num, Look);
            Rotation(i + 1);
            LookDir(x, y, j, num, Back);
        }
    }

    static void LookDir(int x, int y,int dir,int k, Action<int,int,int> action) 
    {
        if (k == 1)
        {
            action(x, y, dir);
        }else if (k == 2)
        {
            action(x, y, dir);
            action(x, y, (dir+2)%4);
        }
        else if (k == 3)
        {
            action(x, y, dir);
            action(x, y, (dir+1)%4);
        }
        else if (k == 4)
        {
            action(x, y, dir);
            action(x, y, (dir+1)%4);
            action(x, y, (dir+2)%4);
        }
        else if (k == 5)
        {
            action(x, y, dir);
            action(x, y, (dir + 1) % 4);
            action(x, y, (dir + 2) % 4);
            action(x, y, (dir + 3) % 4);
        }
    }

    static void Look(int x,int y,int dir) 
    {
        while (true)
        {
            x += dx[dir];
            y += dy[dir];

            if (x >= 0 && y >= 0 && x < N && y < M)
            {
                if (room[x,y]==6)
                {
                    break;
                }

                if (room[x, y] > 0)
                    continue;

                room[x, y] -= 1;

            }
            else
            {
                break;
            }
        }
    }

    static void Back(int x ,int y, int dir) 
    {
        while (true)
        {
            x += dx[dir];
            y += dy[dir];

            if (x >= 0 && y >= 0 && x < N && y < M)
            {
                if (room[x, y] == 6)
                {
                    break;
                }

                if (room[x, y] > 0)
                    continue;

                room[x, y] += 1;

            }
            else
            {
                break;
            }
        }
    }
}
