using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int testcase = Convert.ToInt32(input);
        HashSet<string> words = new HashSet<string>();

        for (int i = 0; i < testcase; i++)
        {
            words.Add(Console.ReadLine());
        }

        List<string> list = words.ToList();
        list.Sort((x, y) =>
        {
            if (x.Length == y.Length)
            {
                return x.CompareTo(y);
            }
            else
            {
                return x.Length.CompareTo(y.Length);
            }
        });

        foreach (string word in list)
        {
            Console.WriteLine(word);
        }
        

        Console.ReadLine();
    }
    
}
