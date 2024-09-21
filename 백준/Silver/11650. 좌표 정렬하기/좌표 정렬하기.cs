using System;
using System.Collections.Generic;


class Program
{
    public struct xy 
    {
        public int x;
        public int y;

        public xy(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }
    }
    static void Main()
    {
        string input = Console.ReadLine();
        int testcase = Convert.ToInt32(input);
        List<xy> list = new List<xy>();
        int x = 0;
        int y = 0;
        for (int i = 0; i < testcase; i++)
        {
            string xys = Console.ReadLine();
            string[] xyarr = xys.Split(' ');
            x = Convert.ToInt32(xyarr[0]);
            y= Convert.ToInt32(xyarr[1]);
            list.Add(new xy(x, y));
        }

        list.Sort((a, b) =>
        {
            if (a.x == b.x)
                return a.y.CompareTo(b.y); 
            return a.x.CompareTo(b.x);
        });

        foreach (var xy in list)
        {
            Console.WriteLine($"{xy.x} {xy.y}");
        }

        Console.ReadLine();
    }
    
}
