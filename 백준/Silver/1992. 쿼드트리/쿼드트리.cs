
using System.ComponentModel;

class Program
{
    static int n;
    static int[,] map;

    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        n = Convert.ToInt32(Console.ReadLine());
        map = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < n; j++)
            {
                map[i, j] = line[j] - '0';
            }
        }

        QuadTree(0, 0, n);

        sw.Flush(); sw.Close();
    }


    static void QuadTree(int x, int y, int size) 
    {
        if (IsSame(x,y,size))
        {
            sw.Write(map[x, y]);
            return;
        }

        int half = size / 2;
        sw.Write("(");
        QuadTree(x, y, half);
        QuadTree(x, y + half, half);
        QuadTree(x + half, y, half);
        QuadTree(x + half, y + half, half);
        sw.Write(")");
    }

    static bool IsSame(int x, int y, int size) 
    {
        int a = map[x, y];
        for (int i = x; i < x + size; i++)
        {
            for (int j = y; j < y + size; j++)
            {
                if (map[i, j] != a)
                {
                    return false;
                }

            }
        }
        return true;
    }
}
