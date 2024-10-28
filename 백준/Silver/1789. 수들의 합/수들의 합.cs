using System;

class Program
{
    static void Main()
    {

        long input = long.Parse (Console.ReadLine());

        if (input ==1)
        {
            Console.WriteLine(1);
            Console.ReadLine();
            return;
        }

        long sum = 0;
        int count = 0;
        for (int i = 1; i < input; i++)
        {
            if (sum + i<= input)
            {
                sum += i;
                count++;
            }
            else
                break;
        }

        Console.WriteLine(count);
        Console.ReadLine();
    }
}

