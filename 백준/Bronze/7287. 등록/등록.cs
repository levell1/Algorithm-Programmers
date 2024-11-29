
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        sw.WriteLine(168);
        sw.WriteLine("whddnr0317");

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}