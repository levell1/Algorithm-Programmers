class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int T = Convert.ToInt32(Console.ReadLine());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int x = inputArr[0];
        int y = inputArr[1];
        int w = inputArr[2];
        int h = inputArr[3];

        int result = Math.Min(Math.Min(w - x, x),Math.Min( h - y, y));

        sw.WriteLine(result);
        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}
