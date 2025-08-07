

class Program
{
    static int n,s;
    static int result;
    static int x, y;
    static int[,] field;
    static int[] input;
    static List<(int, int)> land = new List<(int, int)>();
    static bool[,] visited;
    static readonly int[] dx = new int[8] { 0, 0, -1, 1, 1, 1, -1, -1 };
    static readonly int[] dy = new int[8] { 1, -1, 0, 0, 1, -1, 1, -1 };
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());


        while (true)
        {
            input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            if (input[0]==0&& input[1]==0)
            {
                break;
            }
            y = input[0];
            x = input[1];

            field = new int[x, y];
            visited = new bool[x, y];
            land.Clear();
            result = 0;

            for (int i = 0; i < x; i++)
            {
                int[] line = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
                for (int j = 0; j < y; j++)
                {
                    field[i, j] = line[j];
                    if (line[j] == 1)
                    {
                        land.Add((i, j));
                    }
                }
            }

            foreach (var (a, b) in land)
            {
                if (visited[a, b] == false)
                {
                    LandArea(a, b);
                }
                
            }

            sw.WriteLine(result);
        }
        

        
        sw.Flush(); sw.Close();
    }

    static void LandArea(int curx, int cury) 
    {
        var cur = (curx, cury);
        Queue<(int, int)> que = new Queue<(int, int)>();
        que.Enqueue(cur);

        while (que.Count>0)
        {
            (int cx, int cy) =que.Dequeue();
            
            visited[cx, cy] = true;
            for (int i = 0; i < 8; i++)
            {
                int nx = cx + dx[i];
                int ny = cy + dy[i];
                
                if (nx >= 0 && nx < x && ny >= 0 && ny < y)
                {
                    if (field[nx,ny]==1&& visited[nx,ny]==false)
                    {
                        visited[nx, ny] = true;
                        que.Enqueue((nx, ny));
                    }
                }
            }
        }
        result++;
    }
}
