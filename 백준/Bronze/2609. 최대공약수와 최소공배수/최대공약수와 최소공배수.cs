using System;
using System.Linq;
using System.Xml.Schema;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputarr = input.Split(' ');
        int[] num = new int[inputarr.Length];
        num[0] = Convert.ToInt32(inputarr[0]);
        num[1] = Convert.ToInt32(inputarr[1]);
        int max = 0;
        int min = 0;

        for (int i = 1; i <= num[0]; i++)
        {
            if (num[0] % i == 0 && num[1]%i ==0)
            {
                max = i;
            }
        }
        min = num[0] * num[1] / max;

        Console.WriteLine(max);
        Console.WriteLine(min);

        Console.ReadLine();
    }
}
