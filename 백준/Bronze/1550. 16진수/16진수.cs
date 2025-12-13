
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        string N = Console.ReadLine();

        int a = 0;
        foreach (char c in N)
        {
            a *= 16;
            if (c >= '0' && c <= '9') 
            {
                a += c - '0';
            }
            else
            {
                a += c - 'A' + 10;
            }
        }

        sw.WriteLine(a);
        sw.Flush(); sw.Close();
    }

}
