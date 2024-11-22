class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());

        int[,] graph = new int[input, input];

        for (int i = 0; i < input; i++)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            for (int j = 0; j < line.Length; j++)
            {
                graph[i, j] = line[j];
            }
        }

        for (int k = 0; k < input; k++)
        {
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    if (graph[i, k] == 1 && graph[k, j] == 1)
                    {
                        graph[i, j] = 1;
                    }
                }
            }
        }

        for (int i = 0; i < input; i++)
        {
            for (int j = 0; j < input; j++)
            {
                sw.Write($"{graph[i, j]} ");
            }
            sw.WriteLine();
        }

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}