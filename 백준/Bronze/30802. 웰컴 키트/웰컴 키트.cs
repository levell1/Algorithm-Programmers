using System;

class Program
{
    static void Main()
    {
        string people = Console.ReadLine();
        int peoplei = Convert.ToInt32(people);

        string size= Console.ReadLine();
        string[] sizearr = size.Split(' ');
        int[] sizearrint = new int[sizearr.Length];

        string nums = Console.ReadLine();
        string[] numsarr = nums.Split(' ');
        int t = Convert.ToInt32(numsarr[0]);
        int p = Convert.ToInt32(numsarr[1]);

        int answert=0;

        for (int i = 0; i < sizearr.Length; i++)
        {
            sizearrint[i] = Convert.ToInt32(sizearr[i]);
            answert += (sizearrint[i] / t)+1;
            if (sizearrint[i] % t==0)
            {
                answert--;
            }
        }

        Console.WriteLine(answert);
        Console.Write($"{peoplei / p} {peoplei % p}");

        Console.ReadLine();
    }
}
