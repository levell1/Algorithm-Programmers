

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int n;
    static int[] nums;
    static int[] result;
    static bool[] visited;
    static int maxValue = 0;

    static void Main()
    {
        n = int.Parse( Console.ReadLine());
        nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        result = new int[n];
        visited = new bool[n];

        DFS(0);

        sw.WriteLine(maxValue);  
        sw.Flush(); sw.Close();
    }

    static void DFS(int count) 
    {
        if (count ==n)
        {
            int sum = 0;
            for (int i = 0; i < n-1; i++)
            {
                sum += Math.Abs(result[i] - result[i + 1]);
            }
            maxValue = Math.Max(maxValue, sum);
            return;
        }

        for (int i = 0; i < n; i++)
        {
            if (!visited[i])
            {
                visited[i] = true;
                result[count] = nums[i];

                DFS(count + 1);
                visited[i] = false;
            }
        }
    }

}
