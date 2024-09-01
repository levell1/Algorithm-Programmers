using System;

class Program
{
    static void Main()
    {

        string input = Console.ReadLine();
        int testcase = Convert.ToInt32(input);

        for (int i = 0; i < testcase; i++)
        {
            string inputa = Console.ReadLine();
            string[] numstring = inputa.Split(' ');
            int a = Convert.ToInt32(numstring[0]);
            foreach (char c in numstring[1])
            {
                Console.Write(new string(c, a));
            }
            Console.WriteLine();

        }
    }
}