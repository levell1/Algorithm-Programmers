
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        string input;
        while ((input = Console.ReadLine()) != null) 
        {
            sw.WriteLine(input);
        }
        sw.Flush(); sw.Close();

    }
}
