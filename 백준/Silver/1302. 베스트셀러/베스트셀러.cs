
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        var books = new Dictionary<string, int>() ;
        
        for (int i = 0; i < input; i++)
        {
            string name = Console.ReadLine();
            if (!books.ContainsKey(name))
            {
                books.Add(name, 1);
            }
            else
            {
                books[name]++;
            }
        }

        var result = books.OrderBy(x => -x.Value).ThenBy(x => x.Key);

        Console.WriteLine($"{result.ElementAt(0).Key}");
        
        sw.Flush(); sw.Close();

    }
}
