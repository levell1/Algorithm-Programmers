using System;
using System.Text;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int testcase = Convert.ToInt32(input);
        int[] ints = new int[testcase];
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < testcase; i++)
        {
            ints[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(ints);
        foreach (int i in ints) 
        {
            sb.Append(i);
            sb.AppendLine();
        }

        Console.WriteLine(sb.ToString());  

        Console.ReadLine();
    }
    
}
