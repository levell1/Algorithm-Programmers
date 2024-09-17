using System;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int num = Convert.ToInt32(input);
        int a = 665;
        int count = 0;
        string nums;
        while (count<num) 
        {
            a++;
            nums =a.ToString();
            if (nums.Contains("666"))
            {
                count++;
            }
            
        }

        Console.WriteLine(a);
        Console.ReadLine();
    }
    
}
