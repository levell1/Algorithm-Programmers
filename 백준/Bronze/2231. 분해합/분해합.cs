using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int num = Convert.ToInt32(input);
        int M;
        int temp;
        int min = 0;
        for (int i = 0; i < num; i++)
        {
            M = 0;
            M += i;
            temp = i;
            while (temp != 0) 
            {
                M += temp % 10; 
                temp = temp/10;
            }
            if (M==num)
            {
                min = i;
                break;
            }
        }

        Console.WriteLine(min);
        Console.ReadLine();
    }
}
