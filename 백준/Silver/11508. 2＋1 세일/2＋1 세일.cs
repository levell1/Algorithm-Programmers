class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

        int[] uniform =new int[input];

        for (int i = 0; i < input; i++)
        {
            uniform[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(uniform);
        Array.Reverse(uniform);

        long sum = 0;
        for (int i = 0; i < input; i++)
        {
            if (i%3!=2)
            {
                sum += uniform[i];
            }
        }

        sw.Write($"{sum}");

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}