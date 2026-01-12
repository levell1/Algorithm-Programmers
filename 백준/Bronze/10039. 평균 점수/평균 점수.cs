

using System.Threading.Tasks.Sources;

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        //int[] nm = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            int s = int.Parse(Console.ReadLine());
            if (s<40)
            {
                s = 40;
            }
            sum += s;
        }

        int result = sum / 5;


        sw.WriteLine(result);
        sw.Flush(); sw.Close();
    }

}


