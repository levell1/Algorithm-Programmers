
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int T = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        
        List<int>[] list = new List<int>[T+1];
        bool[] visited = new bool[T+1];

        for (int i = 1; i <= T; i++)
        {
            list[i] = new List<int>();
        }

        for (int i = 1; i < T; i++)
        {
            int[] edge = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int firstNode = edge[0];
            int secondNode = edge[1];
            list[firstNode].Add(secondNode);
            list[secondNode].Add(firstNode);
        }
        int[] par = new int[T+1];
        bfs(1);
        void bfs(int start) 
        {
            visited[start] = true;

            for (global::System.Int32 i = 0; i < list[start].Count; i++)
            {
                int nextnode = list[start][i];
                if (!visited[nextnode])
                {
                    par[nextnode] = start;
                    bfs(nextnode);
                }
            }
        }

        for (int i = 2; i < par.Length; i++)
        {
            sw.WriteLine(par[i]);
        }

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}