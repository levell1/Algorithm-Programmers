
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int[] input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        sw.WriteLine(@"     /~\
    ( oo|
    _\=/_
   /  _  \
  //|/.\|\\
 ||  \ /  ||
============
|          |
|          |
|          |");


        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}