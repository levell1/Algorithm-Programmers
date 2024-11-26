class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());


        int input = Convert.ToInt32(Console.ReadLine());
        int size = input;

        int[,] graph = new int[size + 1, size + 1];

        int[] movex = { 0, 0, -1, 1 }; //상 하 좌 우
        int[] movey = { 1, -1, 0, 0 };

        for (int i = 1; i <= size; i++)
        {
            string line = Console.ReadLine();

            for (int j = 1; j <= line.Length; j++)
            {
                graph[i, j] = line[j - 1] - '0';
            }
        }

        int count = 2;
        List<int> houseNum = new List<int>();

        for (int i = 1; i <= size; i++)
        {

            for (int j = 1; j <= size; j++)
            {
                if (graph[i, j] == 1)
                {
                    bfs(i, j);
                }

            }
        }


        void bfs(int goalx, int goaly)
        {
            Queue<(int x, int y)> q = new Queue<(int x, int y)>();

            q.Enqueue((goalx, goaly));
            graph[goalx, goaly] = count;
            int housecount = 1;
            while (q.Count > 0)
            {
                (int curx, int cury) = q.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int nextx = curx + movex[i];
                    int nexty = cury + movey[i];
                    if (nextx > 0 && nextx <= size && nexty > 0 && nexty <= size)
                    {
                        if (graph[nextx, nexty] == 1)
                        {
                            q.Enqueue((nextx, nexty));
                            graph[nextx, nexty] = count;
                            housecount++;
                        }
                    }
                }
            }
            houseNum.Add(housecount);
            count++;
        }

        sw.WriteLine($"{count - 2}");

        houseNum.Sort();

        foreach (var item in houseNum)
        {
            sw.WriteLine(item.ToString());
        }

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}