using System;



class Program
{
    static void Main()
    {
        int input = Convert.ToInt32(Console.ReadLine());
        int[] times = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

        Array.Sort(times);

        int sum = 0;
        for (int i = 0; i < times.Length; i++)
        {
            sum += times[i] * (times.Length - i);
        }

        Console.WriteLine(sum);
        Console.ReadLine();
    }
}


