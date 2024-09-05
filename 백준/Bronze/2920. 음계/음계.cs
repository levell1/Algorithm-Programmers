using System;

class Program
{
    static void Main()
    {

        string input = Console.ReadLine();
        string[] codes = input.Split(' ');
        int[] a = new int[codes.Length];
        for (int i = 0; i < codes.Length; i++)
        {
            a[i] = int.Parse(codes[i]);
        }
        int count = 0;
        string result = "mixed";
        for (int i = 0; i < codes.Length - 1; i++)
        {
            if (a[i] > a[i + 1])
            {
                count--;
            }
            else
            {
                count++;
            }

            if (count == 7)
            {
                result = "ascending";
            }
            else if (count == -7)
            {
                result = "descending";
            }
        }
        Console.WriteLine(result);

        Console.ReadLine();
    }
}
