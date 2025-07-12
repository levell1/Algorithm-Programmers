
class Program
{
    static int N;
    static int[,] map;
    static int count = 0;
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        N= Convert.ToInt32(Console.ReadLine());

        map = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int j = 0; j < N; j++)
                map[i, j] = input[j];
        }

        DFS(0, 1, 0);

        sw.WriteLine(count);
        sw.Flush(); sw.Close();
    }

    static void DFS(int y, int x, int dir)
    {
        if (y == N - 1 && x == N - 1)
        {
            count++;
            return;
        }

        if (dir == 0 || dir == 2)
        {
            int nx = x + 1;
            if (nx < N && map[y, nx] == 0)
                DFS(y, nx, 0);
        }

        if (dir == 1 || dir == 2)
        {
            int ny = y + 1;
            if (ny < N && map[ny, x] == 0)
                DFS(ny, x, 1);
        }

        if (y + 1 < N && x + 1 < N)
        {
            if (map[y, x + 1] == 0 && map[y + 1, x] == 0 && map[y + 1, x + 1] == 0)
                DFS(y + 1, x + 1, 2);
        }
    }
}