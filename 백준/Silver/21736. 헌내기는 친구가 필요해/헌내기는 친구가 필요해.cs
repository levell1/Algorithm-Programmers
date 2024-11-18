using System.Text;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        int x = input[0];
        int y = input[1];

        char[,] campus = new char[x, y];

        int ix = 0;
        int iy = 0;

        bool[,] visited = new bool[x, y];

        int[] movex = { 0, 0, 1, -1 };  // 상 하 좌 우
        int[] movey = { 1, -1, 0, 0 };

        int count = 0;


        for (int i = 0; i < x; i++)
        {
            string info = Console.ReadLine();
            for (int j = 0; j < y; j++)
            {
                campus[i, j] = info[j];
                if (info[j].Equals('I'))
                {
                    ix = i;
                    iy = j;
                }
            }
        }


        bfs(ix,iy);

        string a = count > 0 ? count.ToString() : "TT";
        Console.WriteLine(a);
        Console.ReadLine();

        void dfs (int newx, int newy) 
        {
            visited[newx, newy] = true;

            if (campus[newx, newy]=='X') 
            {
                return;
            }else if (campus[newx, newy]=='P')
            {
                count++;
            }
            
            for (global::System.Int32 i = 0; i < 4; i++)
            {
                int nextx = newx;
                int nexty = newy;
                nextx += movex[i];
                nexty += movey[i];
                if (nextx >= 0 && nexty >= 0 && nextx < x && nexty < y)
                {
                    if (!visited[nextx, nexty])
                    {
                        dfs(nextx, nexty);
                    }
                }
                
            }
        }

        void bfs(int newx, int newy) 
        {
            visited[newx, newy] = true;
            Queue<int> queuex = new Queue<int>();
            Queue<int> queuey = new Queue<int>();
            queuex.Enqueue(newx);
            queuey.Enqueue(newy);

            while (queuex.Count > 0) 
            {
                int curx = queuex.Dequeue();
                int cury = queuey.Dequeue();
                
                for (global::System.Int32 i = 0; i < 4; i++)
                {
                    int nextx = curx;
                    int nexty = cury;
                    nextx += movex[i];
                    nexty += movey[i];
                    if (nextx >= 0 && nexty >= 0 && nextx < x && nexty < y)
                    {
                        if (!visited[nextx, nexty])
                        {
                            visited[nextx, nexty] = true;
                            if (campus[nextx, nexty]=='X')
                            {
                                continue;
                            }
                            else if (campus[nextx, nexty]=='P')
                            {
                                count++;
                            }
                            queuex.Enqueue(nextx);
                            queuey.Enqueue(nexty);
                        }
                    }
                }
            }
        }
    }
}
