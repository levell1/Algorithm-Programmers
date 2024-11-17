using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        int N = input[0];
        int M = input[1];
        int B = input[2];
        int time = 0;
        int[,] field = new int[N,M];
        int height = 0;
        bool check = false;
        for (int i = 0; i < N; i++)
        {
            int[] Line = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

            for (int j = 0; j < M; j++)
            {
                field[i, j] = Line[j];
                if (height< Line[j])
                {
                    height = Line[j];
                }
            }
        }
        int minTime = 2147483647;
        int heightx = 0;

        for (int i = height; i >= 0; i--)
        {
            time = 0;
            B = input[2];
            work(i);
            if (B>=0)
            {
                if (minTime > time)
                {
                    minTime = time;
                    heightx = i;
                }
            }
        }

        
        Console.WriteLine($"{minTime} {heightx}");

        void add(int x, int y, int height) 
        {
            int a = height- field[x, y];
            time += a;
            B-= a;
        }

        void remove(int x, int y, int height)
        {
            int a = field[x, y]- height;
            time += 2*a;
            B+= a;
        }

        void work(int h) 
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (field[i, j] < h)
                    {
                        add(i, j, h);
                    }
                    else if(field[i, j] > h)
                    {
                        remove(i, j, h);
                    }
                }
            }
        }
    }
}
