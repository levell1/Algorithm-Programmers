using System;

class Program
{
    static void Main()
    {

        long num = 1;
        for (int i = 0; i < 3; i++)
        {
            string input = Console.ReadLine();
            num *= Convert.ToInt32(input);
        }
        
        string numstring = num.ToString();

        int[] count = new int[10];

        foreach (char i in numstring) 
        {
            count[i-'0']++;
        }

        for (int i = 0; i < count.Length; i++)
        {
            Console.WriteLine(count[i]);
            
        }

        Console.ReadLine();
    }
}