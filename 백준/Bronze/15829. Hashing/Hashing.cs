using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int L = int.Parse(input);

        int r = 31;
        int M = 1234567891;
        int hash;
        int pow = 0;
        double result = 0;

        string inputword = Console.ReadLine();

        foreach (var item in inputword)
        {
            hash = item - 'a'+1;
            result += hash * Math.Pow(r, pow)%M;
            pow++;
        }

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
