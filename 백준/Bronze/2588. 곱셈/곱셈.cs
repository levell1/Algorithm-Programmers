
using System;

class Program
{
    static void Main()
    {

        var sw = new StreamWriter(Console.OpenStandardOutput());

        int a = Convert.ToInt32( Console.ReadLine());
        string b = Console.ReadLine();


        int first = a * (b[2] - '0');
        int second = a * (b[1] - '0');
        int third = a * (b[0] - '0');

        sw.WriteLine(first);
        sw.WriteLine(second);
        sw.WriteLine(third);

        sw.WriteLine(first+ second*10+ third*100);

        sw.Flush(); sw.Close();

    }

}