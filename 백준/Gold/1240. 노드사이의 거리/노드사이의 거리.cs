class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int N = inputArr[0];
        int M = inputArr[1];

        var visited = new bool[N + 1];
        var list = new List<(int node,int len)>[N+1];
        for (int i = 1; i <= N; i++)
        {
            list[i] = new List<(int,int)>();
        }

      
        for (int i = 0; i < N-1; i++)
        {
            int[] edge = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int start = edge[0];
            int end = edge[1];
            int len = edge[2];
            list[start].Add((end,len));
            list[end].Add((start,len));
        }


        for (int i = 0; i < M; i++)
        {
            visited = new bool[N + 1];
            int[] between = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int startNode = between[0];
            int endNode = between[1];
            DFS(startNode, 0,endNode);

        }

       
        sw.Flush(); sw.Close();



        void DFS(int start, int curLen, int goal)
        {
            visited[start] = true;
            if (start == goal)
            {
                sw.WriteLine(curLen);
                return;
            }
            foreach (var neighbor in list[start])
            {
                if (!visited[neighbor.node]) 
                {
                    DFS(neighbor.node, curLen+neighbor.len, goal);
                }
            }
        }
    }
}
