using System;
using System.Collections.Generic;
using System.Text;



class Program
{
    static void Main()
    {

        string[] input = Console.ReadLine().Split('.');

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Length%2!=0)
            {
                Console.WriteLine(-1);
                sb.Clear();
                sb.Append(".");
                break;
            }

            if (input[i].Length%4==0)
            {
                string result = "".PadLeft(input[i].Length, 'A');
                sb.Append(result);
            }
            else if (input[i].Length%2==0) 
            {
                string result = "".PadLeft(input[i].Length-2, 'A');
                result = result+"BB";
                sb.Append(result);
            }
            sb.Append(".");
        }

        sb.Remove(sb.Length-1, 1);

        Console.WriteLine(sb.ToString());
        Console.ReadLine();
    }
}


