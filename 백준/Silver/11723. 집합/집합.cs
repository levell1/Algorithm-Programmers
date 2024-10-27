using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main()
    {
        List<int> list = new List<int>();
        
        int M = Convert.ToInt32( Console.ReadLine());
        int bitMask = 0;
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < M; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string comment = input[0];

            int x = input.Length > 1 ? int.Parse(input[1]) : 0;

            switch (comment) 
            {
                case "add":
                    bitMask |= 1 << (x - 1);
                    break;
                case "remove":
                    bitMask &= ~(1 << (x - 1));
                    break;
                case "check":
                    stringBuilder.AppendLine((bitMask & (1 << (x - 1))) != 0 ? "1":"0");
                    break;
                case "toggle":
                    bitMask ^= 1 << (x - 1);
                    break;
                case "all":
                    bitMask = (1 << 20) - 1;
                    break;
                case "empty":
                    bitMask = 0;
                    break;
                default: break;
            }
        }
        
        Console.Clear();
        Console.Write(stringBuilder.ToString());
        Console.ReadLine();

        
    }
}
