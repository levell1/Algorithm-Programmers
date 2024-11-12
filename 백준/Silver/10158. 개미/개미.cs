using System;
using System.Text;


class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();

        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        int width = input[0];
        int height = input[1];

        int[] pq = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        int p = pq[0];
        int q = pq[1];

        int t =Convert.ToInt32(Console.ReadLine());

        move(p, q, t);

        Console.ReadLine();

        void move(int x, int y,int time) 
        {
            x = (x + t) % (width * 2);
            y = (y + t) % (height * 2);

            if (x >width) x = width-(x-width);
            if (y >height) y = height-(y- height);
            
            Console.WriteLine($"{x} {y}");
        }
    }
}