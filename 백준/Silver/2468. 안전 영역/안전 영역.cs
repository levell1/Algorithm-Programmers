

class Program
{
    static int n;
    static int[,] field;
    static bool[,] flooding;
    static int min;
    static int max;
    static int count;
    static int result;
    static readonly int[] dx = new int[4] { 0, 0, -1, 1 };
    static readonly int[] dy = new int[4] { 1, -1, 0, 0 };
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        n = Convert.ToInt32(Console.ReadLine());
        field = new int[n, n];
        min = int.MaxValue;
        max = 0;
        result = 1;
        for (int i = 0; i < n; i++)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            for (int j = 0; j < n; j++)
            {
                field[i, j] = line[j];
                if (line[j] < min)
                {
                    min = line[j];
                }
                if (line[j] > max)
                {
                    max = line[j];
                }
            }
        }

        for (int i = min; i < max; i++)
        {
            Flood(i);
        }

        sw.WriteLine(result);
        sw.Flush(); sw.Close();
    }

    static void Flood(int hight) 
    {
        flooding = new bool[n, n];
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (field[i, j] <= hight)
                {
                    flooding[i, j] = true;
                    
                }
            }
        }
        SafeArea(flooding);
        if (result < count)
        {
            result = count;
        }
    }

    static void SafeArea(bool[,] floodingCheck) 
    {
        count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (floodingCheck[i,j] ==false)
                {
                    SafeAreaCheck(floodingCheck, i, j);
                }
            }
        }
    }

    static void SafeAreaCheck(bool[,] floodingCheck,int x,int y)
    {
        Queue<(int, int)> q = new Queue<(int, int)>();
        q.Enqueue((x, y));
        floodingCheck[x, y] = true;
        while (q.Count > 0)
        {
            var (cx, cy) = q.Dequeue();
            for (int i = 0; i < 4; i++)
            {
                int nx = cx + dx[i];
                int ny = cy + dy[i];
                if (nx >= 0 && ny >= 0 && nx < n && ny < n)
                {
                    if (floodingCheck[nx, ny] == false)
                    {
                        floodingCheck[nx, ny] = true;
                        q.Enqueue((nx, ny));
                    }
                }
            }
        }
        count++;
    }
}
