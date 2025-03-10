class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        int x = input[0];
        int y = input[1];

        int[,] graph = new int[x, y];

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


        void bfs(int goalx, int goaly)
        {
            Queue<(int x,int y)> q = new Queue<(int x, int y)>();
            q.Enqueue((goalx, goaly));

            while (q.Count>0)
            {
                (int curx, int cury)  = q.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int nextx = curx + movex[i];
                    int nexty = cury + movey[i];
                    if (nextx >= 0&& nextx < x&& nexty >= 0 && nexty < y)
                    {
                        if (graph[nextx, nexty] == -1)
                        {
                            q.Enqueue((nextx, nexty));
                            graph[nextx, nexty] = graph[curx, cury] +1;
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