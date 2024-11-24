class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

        int[] money =new int[input];

        for (int i = 0; i < input; i++)
        {
            money[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(money);
        Array.Reverse(money);

        long sum = 0;
        for (int i = 0; i < input; i++)
        {
            if (money[i] - i>0)
            {
                sum += money[i] - i;
            }
            
        }

        sw.Write($"{sum}");

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}