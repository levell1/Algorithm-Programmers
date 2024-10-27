using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main()
    {
        List<int> list = new List<int>();
        int[] all = new int[20] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
        
        int M = Convert.ToInt32( Console.ReadLine());
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < M; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string comment = input[0];
            int x=0;
            if (input.Length>1)
            {
                x = int.Parse(input[1]);
            }
            
            switch (comment) 
            {
                case "add":
                    Add(x); 
                    break;
                case "remove":
                    Remove(x);
                    break;
                case "check":
                    Check(x);
                    break;
                case "toggle":
                    Toggle(x);
                    break;
                case "all":
                    All();
                    break;
                case "empty":
                    Empty();
                    break;
                default: break;
            }

        }
        Console.Clear();
        Console.Write(stringBuilder.ToString());
        Console.ReadLine();

        void Add(int x) 
        {
            if (list.Contains(x))
            {
                return;
            }
            list.Add(x);
        }
        void Remove(int x)
        {
            if (list.Contains(x))
            {
                list.Remove(x);
            }
            
        }
        void Check(int x)
        {
            if (list.Contains(x))
            {
                stringBuilder.AppendLine("1");
            }
            else
            {
                stringBuilder.AppendLine("0");
            }
        }
        void Toggle(int x)
        {
            if (list.Contains(x))
            {
                list.Remove(x);
            }
            else
            {
                list.Add(x);
            }
        }
        void All()
        {
            list = all.ToList();
        }
        void Empty()
        {
            list.Clear();
        }
    }
}
