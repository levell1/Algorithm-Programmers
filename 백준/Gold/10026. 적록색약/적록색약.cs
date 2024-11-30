class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);


        int[] movex = { 0, 0, -1, 1 };// 상 하 좌 우
        int[] movey = { 1, -1, 0, 0 };

        int[,] rgb = new int[input, input];
        bool[,] visited = new bool[input, input];


        for (int j = 0; j < input; j++)
        {
            string color = Console.ReadLine();
            for (int i = 0; i < input; i++)
            {
                rgb[i, j] = color[i];
            }
        }

        int count = 0;
        for (int j = 0; j < input; j++)
        {
            for (int i = 0; i < input; i++)
            {
                if (!visited[i, j])
                {
                    BFS((i,j));
                    count++;
                }
            }
        }
        sw.Write($"{count} ");
        reset();
        
        for (int j = 0; j < input; j++)
        {
            for (int i = 0; i < input; i++)
            {
                if (!visited[i, j])
                {
                    BFS((i, j));
                    count++;
                }
            }
        }

        sw.WriteLine($"{count}");
        sw.Flush(); sw.Close();
        Console.ReadLine();

        void BFS((int x, int y) pos)
        {
            visited[pos.x, pos.y] = true;
            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue(pos);
            while (queue.Count > 0)
            {
                (int x, int y) curPos = queue.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    (int x, int y) NextPos = (curPos.x + movex[i], curPos.y + movey[i]);

                    if (NextPos.x >= 0 && NextPos.x < input &&
                        NextPos.y >= 0 && NextPos.y < input&&
                        !visited[NextPos.x, NextPos.y])
                    {
                        if (rgb[curPos.x, curPos.y] == rgb[NextPos.x, NextPos.y])
                        {
                            queue.Enqueue(NextPos);
                            visited[NextPos.x, NextPos.y] = true;
                        }
                    }
                }
            }
        }

        void reset() 
        {
            count = 0;
            for (int j = 0; j < input; j++)
            {
                for (int i = 0; i < input; i++)
                {
                    if (rgb[i, j]=='R')
                    {
                        rgb[i, j]='G';
                    }
                     
                    visited[i,j] = false;
                }
            }
        }
    }
}
