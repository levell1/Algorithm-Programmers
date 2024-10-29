using System;
using System.Collections;
using System.Text;


class Program
{
    static void Main()
    {

        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

        Hashtable hashtable = new Hashtable();

        StringBuilder sb = new StringBuilder(); 

        for (int i = 1; i <= input[0]; i++)
        {
            string name = Console.ReadLine();
            string a = i.ToString();
            hashtable.Add(a, name);
            hashtable.Add(name, a);
        }

        for (int i = 0; i < input[1]; i++)
        {
            string find = Console.ReadLine();

            sb.AppendLine(hashtable[find].ToString());

        }

        Console.WriteLine(sb.ToString());
        Console.ReadLine();
    }
}


