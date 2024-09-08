using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string a = "abcdefghijklmnopqrstuvwxyz";
        int count;
        int output;
        foreach (char c in a) 
        {
            count = 0;
            output = -1;
            foreach (char inputc in input)
            {
                count++;
                if (c==inputc)
                {
                    output = count-1;
                    break;
                }
            }
            
            Console.Write(output);
            Console.Write(' ');
        }

        

        Console.ReadLine();
    }
}
