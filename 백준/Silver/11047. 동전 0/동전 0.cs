using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main()
    {

        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        int[] type = new int[input[0]];

        for (int i = 0; i < type.Length; i++)
        {
            type[i] = Convert.ToInt32(Console.ReadLine());
        }
        int count = 0;
        int sum = input[1];
        for (int i = type.Length - 1; i >= 0; i--)
        {
            if (type[i] <= sum)
            {
                count += sum/type[i];
                sum %= type[i];
            }
        }

        Console.WriteLine(count);
        Console.ReadLine();
    }
}


