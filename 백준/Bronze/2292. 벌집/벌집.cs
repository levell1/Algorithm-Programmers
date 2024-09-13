using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int n = int.Parse(input);

        int layer = 1; 
        int range = 2;

        
        while (n >= range)
        {
            if (n == 1)
            {
                break;
            }
            range += 6 * layer; 
            layer++;
        }


        Console.WriteLine(layer);
        Console.ReadLine();
    }
}
