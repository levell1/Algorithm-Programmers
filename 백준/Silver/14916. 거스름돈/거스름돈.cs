using System;



class Program
{
    static void Main()
    {
        int input = Convert.ToInt32(Console.ReadLine());

        int count = -1;
        int money = input;

        if (money % 5 == 0)
        {
            count = money / 5;
        }
        for (int i = money / 5; i >= 0; i--)
        {
            int a = money - (i * 5);
            if ((a)%2==0)
            {
                count = i;
                count +=a/2;
                break;
            }
        }

        Console.WriteLine(count);
        Console.ReadLine();
    }
}


