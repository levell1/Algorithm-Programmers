
using System.Text;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        string input = Console.ReadLine();
        HashSet<string> set = new HashSet<string>();

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 1; j < input.Length+1-i; j++)
            {
                set.Add (input.Substring(i, j));
            }
        }

        sw.WriteLine(set.Count);
        sw.Flush(); sw.Close();
    }
}
