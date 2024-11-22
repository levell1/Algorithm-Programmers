class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        int x = input[0];
        int y = input[1];

        int[,] graph = new int[x, y];
        bool[,] visited = new bool[x, y];

        (int x, int y) goal = (0,0);
        int[] movex = { 0, 0, -1, 1 }; //상 하 좌 우
        int[] movey = { 1, -1, 0, 0 };

        for (int i = 0; i < x; i++)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            for (int j = 0; j < line.Length; j++)
            {
                graph[i, j] = line[j];
                if (line[j] == 2)
                {
                    graph[i, j] = 0;
                    goal = (i, j);
                }
                else if (line[j] == 1) 
                {
                    graph[i, j] = -1;
                }
            }
        }


        bfs(goal.x,goal.y);


        void bfs(int curx, int cury)
        {
            visited[curx,cury] = true;
            Queue<(int x,int y)> q = new Queue<(int x, int y)>();
            q.Enqueue((curx,cury));
            (int x, int y) xy = (0, 0);

            while (q.Count>0)
            {
                xy = q.Dequeue();

                int nextx = 0;
                int nexty = 0;

                for (global::System.Int32 i = 0; i < 4; i++)
                {
                    nextx = xy.x + movex[i];
                    nexty = xy.y + movey[i];
                    if (nextx >= 0&& nextx < x&& nexty >= 0 && nexty < y)
                    {
                        if (graph[nextx, nexty] == -1 && !visited[nextx, nexty])
                        {
                            q.Enqueue((nextx, nexty));
                            graph[nextx, nexty] = graph[xy.x , xy.y ]+1;
                            visited[nextx, nexty] =true;
                        }
                    }
                    
                }
            }
        }

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                sw.Write($"{graph[i, j]} ");
            }
            sw.WriteLine();
        }

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}