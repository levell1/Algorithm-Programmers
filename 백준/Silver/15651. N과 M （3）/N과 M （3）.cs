using System.Text;

class Program
{
    static int n, m;
    static int[] select;
    static StringBuilder sb = new StringBuilder();
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] input = Console.ReadLine().Split(" ");
        n = Convert.ToInt32(input[0]);
        m = Convert.ToInt32(input[1]);
        select = new int[m];

        NM(0);

        sw.Write(sb.ToString());
        sw.Flush(); sw.Close();

    }
    static void NM(int depth)
    {
        if (depth == m)
        {
            for (int i = 0; i < m; i++)
            {
                sb.Append(select[i]).Append(' ');
            }
            sb.AppendLine();
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            select[depth] = i;
            NM(depth + 1);

        }

    }
}