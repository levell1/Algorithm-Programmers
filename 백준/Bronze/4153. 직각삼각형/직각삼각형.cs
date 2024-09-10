using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        while (true) 
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int[] num = { Convert.ToInt32(numbers[0]), Convert.ToInt32(numbers[1]), Convert.ToInt32(numbers[2]) };
            Array.Sort(num);

            if (num[0] == 0)
            {
                break;
            }

            if (Math.Pow(num[0],2)+ Math.Pow(num[1], 2)== Math.Pow(num[2], 2))
            {
                sb.AppendLine("right");
            }
            else
            {
                sb.AppendLine("wrong");
            }

            
        }
        
        Console.WriteLine(sb.ToString());
        Console.ReadLine();
    }
}
