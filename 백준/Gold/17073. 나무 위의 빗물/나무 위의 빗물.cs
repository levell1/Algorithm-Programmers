class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int N = inputArr[0];
        int W = inputArr[1];

        var visited = new bool[N+1];
        var list = new List<int>[N+1];
        for (int i = 1; i <= N; i++)
        {
            list[i] = new List<int>();
        }

        int root = 1;
        int count = 0;
       
        for (int i = 0; i < N-1; i++)
        {
            int[] edge = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int start = edge[0];
            int end = edge[1];  
            list[start].Add(end);
            list[end].Add(start);
        }

        DFS(root);

        double result = W / (double)count;
        
        sw.WriteLine($"{result:f10}");
        sw.Flush(); sw.Close();



        void DFS(int start)
        {
            bool isLeaf = true;
            visited[start] = true;
            foreach (var neighbor in list[start])
            {
                if (!visited[neighbor]) 
                {
                    isLeaf = false;
                    DFS(neighbor);
                }
                
            }
            if (isLeaf)
            {
                count ++;
            }
        }
    }
}
