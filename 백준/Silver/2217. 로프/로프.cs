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

        int max = 0;
        for (int i = 1; i <= input; i++)
        {
            if (max < ropes[input - i] * (i))
            {
                max = ropes[input - i] * (i);
            }
        }

        sw.Write($"{max}");

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}