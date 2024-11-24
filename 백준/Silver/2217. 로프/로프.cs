class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

        int[] ropes =new int[input];

        for (int i = 0; i < input; i++)
        {
            ropes[i] = Convert.ToInt32(Console.ReadLine());

        }

        Array.Sort(ropes);
        Array.Reverse(ropes);

        int max = 0;
        for (int i = 0; i < ropes.Length; i++)
        {
            if (max < ropes[i] * (i + 1))
            {
                max = ropes[i] * (i + 1);
            }
        }

        sw.Write($"{max}");

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}