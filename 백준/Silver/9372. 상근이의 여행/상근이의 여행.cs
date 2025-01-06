
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int result;
        for (int i = 0; i < input; i++)
        {
            int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int N = inputArr[0];
            int M = inputArr[1];
            result = 0;
            List<int>[] list = new List<int>[N+1];
            var visited = new bool[N+1];

            for (int j = 0; j < N+1; j++)
            {
                list[j] = new List<int>();
            }

            for (int j = 0; j < M; j++)
            {
                int[] edge = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
                int start = edge[0];
                int end = edge[1];
                list[start].Add(end);
                list[end].Add(start);
            }
            BFS(1, visited, list);
            sw.WriteLine(result);
        }

        sw.Flush(); sw.Close();


        void BFS(int start, bool[] visited, List<int>[] list)
        {
            visited[start] = true;
            for (global::System.Int32 i = 0; i < list[start].Count; i++)
            {
                if (!visited[list[start][i]])
                {
                    BFS(list[start][i], visited, list);
                    result++;
                }
            }
        }
    }
}
