
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static int n,k,l ;
    static int[,] field;

    static Queue<(int, int)> snake = new Queue<(int, int)>();
    static Dictionary<int, char> dirdic;
    static bool end = false;
    static int count;

    static readonly int[] dx = {1,0,-1,0 };
    static readonly int[] dy = {0,1,0,-1 };

    static void Main()
    {
        n = Convert.ToInt32(Console.ReadLine());
        k = Convert.ToInt32(Console.ReadLine());
        field = new int[n+1, n+1];

        for (int i = 0; i < k; i++)
        {
            int[] apple = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
            field[apple[1], apple[0]] = 1;
        }
        
        l = Convert.ToInt32(Console.ReadLine());

        dirdic = new Dictionary<int, char>();

        for (int i = 0; i < l; i++)
        {
            string[] input = Console.ReadLine().Split();
            int sec = Convert.ToInt32(input[0]);
            char dir = input[1][0];
            dirdic[sec] = dir;
        }

        (int x, int y) pos = (1, 1);
        snake.Enqueue(pos);

        Move(pos, 0);


        sw.WriteLine(count);
        sw.Flush(); sw.Close();
    }

    static void Move((int x,int y) pos, int dir) 
    {
        int nx = pos.x;
        int ny = pos.y;

        while (true)
        {
            nx += dx[dir];
            ny += dy[dir];
            count++;
            EndCheck(nx, ny);
            if (end)
            {
                break;
            }

            if (field[nx, ny] == 1)
            {
                field[nx, ny] = 0;
            }
            else
            {
                snake.Dequeue();
            }
            snake.Enqueue((nx, ny));

            if (dirdic.ContainsKey(count))
            {
                if (dirdic[count]=='D')
                {
                    dir = (dir + 1) % 4;
                }
                else
                {
                    dir = (dir + 3) % 4;
                }
            }

        }
    }

    static void EndCheck(int x, int y) 
    {
        if (x <= 0 || y <= 0 || x > n || y > n)
        {
            end = true;
        }else if (snake.Contains((x,y)))
        {
            end = true;
        }
    }
}
