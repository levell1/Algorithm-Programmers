using System;
using System.Web;


class Program
{
    static void Main()
    {
        string inputa = Console.ReadLine();
        string inputb = Console.ReadLine();
        string inputc = Console.ReadLine();

        int i=0;
        if (int.TryParse(inputa, out int resulta))
        {
            i = resulta + 3;
        }else if (int.TryParse(inputb, out int resultb)) 
        {
            i = resultb + 2;
        }
        else if (int.TryParse(inputc, out int resultc))
        {
            i = resultc + 1;
        }

        string a;
        if (i % 3 == 0 && i % 5 == 0)
        {
            a = "FizzBuzz";
        }
        else if (i % 3 == 0 && i % 5 != 0)
        {
            a = "Fizz";
        }
        else if (i % 3 != 0 && i % 5 == 0)
        {
            a = "Buzz";
        }
        else
        {
            a = i.ToString();
        }
        Console.WriteLine(a);

        Console.ReadLine();
    }
    
}
