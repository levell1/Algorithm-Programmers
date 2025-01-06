
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        List<int>[] list = new List<int>[input + 1];
        bool[] visited = new bool[input + 1];

        for (int i = 1; i <= input; i++)
        {
            list[i] = new List<int>();
        }
        var check = new Dictionary<int, (int,int)>();

        for (int i = 1; i < input; i++)
        {
            int[] edge = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int firstNode = edge[0];
            int secondNode = edge[1];
            list[firstNode].Add(secondNode);
            list[secondNode].Add(firstNode);
            check[i] = (firstNode, secondNode);
        }
        
        

        input = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= input; i++)
        {
            int[] tk = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int t = tk[0];
            int k = tk[1];
            if (t==1) 
            {
                if (list[k].Count == 1)
                {
                    sw.WriteLine("no");
                }
                else
                {
                    sw.WriteLine("yes");
                }
            }
            else
            {
                var (start, end) = check[k];
                sw.WriteLine("yes");
            }

        }


        sw.Flush(); sw.Close();

    }
}
