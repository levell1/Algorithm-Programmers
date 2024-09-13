using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int n = int.Parse(input);
        if (n == 1)
        {
            Console.WriteLine(1);
            return;
        }
        int layer = 1; 
        int range = 2;

        
        while (n >= range)
        {
            range += 6 * layer; 
            layer++;
        }


        Console.WriteLine(layer);
        Console.ReadLine();
    }
}
