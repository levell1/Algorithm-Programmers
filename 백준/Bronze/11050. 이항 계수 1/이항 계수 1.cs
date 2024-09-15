using System;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] nk = input.Split(' ');

        int n = Convert.ToInt32(nk[0]);
        int k = Convert.ToInt32(nk[1]);
        int result= factorial(n)/(factorial(k)*factorial(n-k));

        Console.WriteLine(result);
        Console.ReadLine();
        int factorial(int a)
        {
            int fac = 1;
            for (int i = 0; i < a; i++)
            {
                fac *= a - i;
            }
            return fac;
        }
    }
    
}
