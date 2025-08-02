
using System.Text;

class Program
{
    static int result = 0;
    static StringBuilder sb = new StringBuilder();
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = Convert.ToInt32(Console.ReadLine());

        Hanoi(n, 1, 3, 2);
        
        sw.WriteLine(result);
        sw.WriteLine(sb.ToString());
        sw.Flush(); sw.Close();

    }
    static void Hanoi(int n, int from, int to, int via)
    {
        result++;
        if (n == 1)
        {
            sb.AppendLine($"{from} {to}");
            return;
        }

        Hanoi(n - 1, from, via, to); 
        sb.AppendLine($"{from} {to}"); 
        Hanoi(n - 1, via, to, from); 
    }

}