using System.Reflection.Metadata.Ecma335;

class Program
{
    static int result;
    static int I;

    static int[] input;
    static (int x, int y) startPoint;
    static (int x, int y) endPoint;

    static bool[,] visited;

    static readonly int[] dx = new int[8] { 2, 1, 2, 1, -2, -1, -2, -1 };
    static readonly int[] dy = new int[8] { 1, 2, -1, -2, 1, 2, -1, -2 };
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            I = Convert.ToInt32(Console.ReadLine());
            visited = new bool[I, I];
            result = int.MaxValue;

            input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            startPoint = (input[0], input[1]);

            input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            endPoint = (input[0], input[1]);

            result = BFS(startPoint);
            sw.WriteLine(result);

        }

        sw.Flush(); sw.Close();
    }

    static int BFS((int startX, int startY) startPos)
    {
        Queue<((int, int) pos,int dist)> que = new Queue<((int, int),int)>();
        que.Enqueue((startPos,0));
        visited[startPos.startX, startPos.startY] = true;

        if (startPos==endPoint)
        {
            return 0;
        }

        while (que.Count>0)
        {
            ((int curX,int curY) curPos ,int dis)= que.Dequeue();

            for (int i = 0; i < 8; i++)
            {
                int nx = curPos.curX + dx[i];
                int ny = curPos.curY + dy[i];

                if (nx >= 0 && nx < I && ny >= 0 && ny < I)
                {
                    if (visited[nx, ny] == false)
                    {
                        
                        if (nx == endPoint.x && ny == endPoint.y)
                        {
                            return dis+1;
                        }
                        visited[nx, ny] = true;
                        que.Enqueue(((nx, ny),dis+1));
                    }
                }
            }
        }
        return -1;
    }
}
