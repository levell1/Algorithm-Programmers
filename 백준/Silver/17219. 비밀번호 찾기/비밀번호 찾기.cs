using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '),Convert.ToInt32);

        Dictionary<string,string> password = new Dictionary<string,string>();

        for (int i = 0; i < input[0]; i++)
        {
            string[] sitePass = Console.ReadLine().Split(' ');
            password.Add(sitePass[0], sitePass[1]);
        }

        for (int i = 0; i < input[1]; i++)
        {
            string find = Console.ReadLine();
            Console.WriteLine(password[find]);
        }
        Console.ReadLine();
    }
}
