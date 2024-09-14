using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] ABV = input.Split(' ');
        int A = int.Parse(ABV[0]);
        int B = int.Parse(ABV[1]);
        int V = int.Parse(ABV[2]);
        double a = (V - A) / (A - B);
        double count = Math.Ceiling(a);
        double sum = (A-B)*count;


        while (true) 
        {
            count++;
            sum += A;
            if (sum >= V) break;
            sum -= B;
        }
        Console.WriteLine(count);
        Console.ReadLine();
    }
}
