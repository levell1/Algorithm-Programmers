class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int T = Convert.ToInt32(Console.ReadLine());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int min = inputArr.Min();
        int launchDay = Array.IndexOf(inputArr, min);
        sw.WriteLine(launchDay);
        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}
