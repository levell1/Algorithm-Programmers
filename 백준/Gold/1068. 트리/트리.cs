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
        for (int i = 0; i < input; i++)
        {
            list[i] = new List<int>();
        }
        int[] edge = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int deleteNode = Convert.ToInt32(Console.ReadLine());
        int roof = 0;
        for (int i = 0; i < input; i++)
        {
            if (edge[i] == -1)
            {
                roof = i;
                continue;
            }
            if (i!= deleteNode)
            {
                list[edge[i]].Add(i);
            }
            
        }

        int count = 0;

        if (roof==deleteNode)
        {
            count = 0;
        }
        else
        {
            DFS(roof);
        }
        

        sw.WriteLine(count);

        sw.Flush(); sw.Close();

        void DFS(int start)
        {
            visited[start] = true;
            bool isLeaf = true;
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
