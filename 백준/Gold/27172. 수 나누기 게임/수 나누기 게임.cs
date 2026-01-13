using System.Dynamic;

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] x = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

        int MAX = 1000000;
        bool[] exists = new bool[MAX + 1];
        int[] s = new int[MAX + 1];

        foreach (var c in x)
        {
            exists[c] = true;
        }

        foreach (var a in x)
        {
            for (int i = a * 2; i <= MAX; i += a)
            {
                if (exists[i])
                {
                    s[a] += 1;
                    s[i] -= 1;
                }
            }
        }

        foreach (var c in x)
        {
            sw.Write(s[c] + " ");
        }

        
        sw.Flush(); sw.Close();
    }

}


