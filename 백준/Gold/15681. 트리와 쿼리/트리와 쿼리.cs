class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int N = inputArr[0];
        int R = inputArr[1];
        int Q = inputArr[2];

        var visited = new bool[N + 1];
        var list = new List<int>[N + 1];
        var result = new int[N + 1];

        for (int i = 1; i <= N; i++)
        {
            list[i] = new List<int>();
        }

        for (int i = 0; i < N - 1; i++)
        {
            int[] edge = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int start = edge[0];
            int end = edge[1];

            list[start].Add(end);
            list[end].Add(start);
        }

        DFS(R);

        for (int i = 0; i < Q; i++)
        {
            int curRoot = Convert.ToInt32(Console.ReadLine());
            sw.WriteLine(result[curRoot]);

        }

        sw.Flush(); sw.Close();


        int DFS(int start)
        {
            visited[start] = true;
            int size = 1;
            foreach (var neighbor in list[start])
            {
                if (!visited[neighbor])
                {
                   size += DFS(neighbor);
                }
            }
            result[start] = size;
            return  size;
        }
    }
}
