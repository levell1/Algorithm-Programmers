using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main()
    {

        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        HashSet<string> names = new HashSet<string>();
        
        StringBuilder sb = new StringBuilder();
        int count = 0;
        for (int i = 0; i < input[0]; i++)
        {
            string str = Console.ReadLine();
            names.Add(str);
        }
        List<string> list = new List<string>();
        for (int i = 0; i < input[1]; i++)
        {
            string str = Console.ReadLine();
            if (names.Contains(str))
            {
                list.Add(str);
            }
        }
        Console.WriteLine(list.Count);
        list.Sort();
        foreach (string str in list) 
        {
            Console.WriteLine(str);
        }
        Console.ReadLine();
    }
}


