
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        string input = Console.ReadLine();

        input = input.Replace("c=", "1");
        input = input.Replace("c-", "1");
        input = input.Replace("dz=", "1");
        input = input.Replace("d-", "1");
        input = input.Replace("lj", "1");
        input = input.Replace("nj", "1");
        input = input.Replace("s=", "1");
        input = input.Replace("z=", "1");

        sw.WriteLine(input.Length);

        sw.Flush(); sw.Close();
    }
}
