
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        var list = new List<int>[input + 1];
        var visited = new bool[input + 1];
        for (int i = 1; i < input + 1; i++)
        {
            list[i] = new List<int>();
        }

        for (int i = 0; i < input - 1; i++)
        {
            int[] edge = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int start = edge[0];
            int end = edge[1];
            list[start].Add(end);
            list[end].Add(start);
        }

        int count = 0;

        DFS(1, 0);

        string result = count % 2 == 1 ? "Yes" : "No";
        sw.WriteLine(result);

        sw.Flush(); sw.Close();

        void DFS(int start, int depth)
        {
            visited[start] = true;

            foreach (var neighbor in list[start])
            {
                if (!visited[neighbor])
                {
                    DFS(neighbor, depth + 1);
                }
            }
            if (list[start].Count == 1)
            {
                count += depth;
            }
            

        }
    }
}
