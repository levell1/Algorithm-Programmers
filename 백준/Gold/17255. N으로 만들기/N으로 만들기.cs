class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        string input = Console.ReadLine();
        var visited = new HashSet<string>();

        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            DFS(input[i].ToString(), i, i, input[i].ToString());
        }

        void DFS(string str, int left, int right, string current)
        {
            if (input == str)
            {
                visited.Add(current);
            }
            else
            {
                if (left > 0)
                    DFS(input[left - 1] + str, left - 1, right, current + input[left - 1] + str);
                if (right < input.Length - 1)
                    DFS(str + input[right + 1], left, right + 1, current+ str + input[right + 1]);
            }

        }

        sw.WriteLine(visited.Count);
        sw.Flush(); sw.Close();

    }
}
