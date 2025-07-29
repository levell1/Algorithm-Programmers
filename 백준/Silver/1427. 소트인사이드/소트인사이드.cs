
class Program
{
    static void Main()
    {

        var sw = new StreamWriter(Console.OpenStandardOutput());

        string N = Console.ReadLine();
        char[] sorted = N.OrderByDescending(c => c).ToArray();

        foreach (var c in sorted)
        {
            sw.Write(c);
        }

        
        sw.Flush(); sw.Close();

    }

}