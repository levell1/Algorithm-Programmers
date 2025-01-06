
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        List<int>[] list = new List<int>[input];

        for (int i = 0; i < input; i++)
        {
            list[i] = new List<int>();
        }

        int[] nodes = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        order(0, nodes.Length - 1, 0);

        foreach (var dep in list)
        {
            Console.WriteLine(string.Join(" ", dep));
        }

        sw.Flush(); sw.Close();



        void order(int start, int end, int depth)
        {
            if (start > end) return;

            int mid = (start + end) / 2;
            list[depth].Add(nodes[mid]);

            order(start, mid - 1, depth + 1);
            order(mid + 1, end, depth + 1);
        }
    }
}
