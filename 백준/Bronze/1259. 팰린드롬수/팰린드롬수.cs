using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string input =" ";

        while (true) 
        {
            input = Console.ReadLine();
            string reverse = new string(input.Reverse().ToArray());
            if (input =="0")
            {
                break;
            }
            if (reverse == input)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        
        Console.ReadLine();
    }
}
