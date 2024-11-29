
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputarr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        for (int i = 0; i < input; i++)
        {
            string str = Console.ReadLine();
            sw.WriteLine($"{str[0]}{str[str.Length-1]}");
        }

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}