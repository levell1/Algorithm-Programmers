
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int n;
    static List<int> result;
    static bool[] visited;
    static void Main()
    {
        //nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        n = int.Parse(Console.ReadLine());
        result = new List<int>();
        visited = new bool[n+1];

        DFS(0);
         
        sw.Flush(); sw.Close();
    }

    static void DFS(int depth) 
    {

        if (depth==n)
        {
            sw.WriteLine(string.Join(" ", result));
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            if (!visited[i])
            {
                visited[i] = true;
                result.Add(i);
                DFS(depth + 1);
                visited[i] = false;
                result.RemoveAt(result.Count - 1);
            }           
            
        }
    }
}
