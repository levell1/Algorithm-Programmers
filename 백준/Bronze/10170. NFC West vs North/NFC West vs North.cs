class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int T = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        sw.WriteLine("NFC West       W   L  T");
        sw.WriteLine("-----------------------");
        sw.WriteLine("Seattle        13  3  0");
        sw.WriteLine("San Francisco  12  4  0");
        sw.WriteLine("Arizona        10  6  0");
        sw.WriteLine("St. Louis      7   9  0");
        sw.WriteLine();
        sw.WriteLine("NFC North      W   L  T");
        sw.WriteLine("-----------------------");
        sw.WriteLine("Green Bay      8   7  1");
        sw.WriteLine("Chicago        8   8  0");
        sw.WriteLine("Detroit        7   9  0");
        sw.WriteLine("Minnesota      5  10  1");
        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}
