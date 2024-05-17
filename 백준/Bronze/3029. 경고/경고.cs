using System;

namespace Algorism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(':');
            string[] input2 = Console.ReadLine().Split(':');

            int[] first = new int[] { int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2]) };
            int[] second = new int[] { int.Parse(input2[0]), int.Parse(input2[1]), int.Parse(input2[2]) } ;
            int[] result = new int[3];
            
            for (int i = 2; i > 0; i--)
            {
                if (second[i] < first[i])
                {
                    second[i-1] -= 1;
                    second[i] += 60;
                }
            }

            if (second[0] < first[0])
            {
                second[0] += 24;
            }

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = second[i] - first[i];
            }
            if (first[0] == second[0]&& first[1] == second[1]&& first[2] == second[2])
            {
                result[0] = 24;
            }
            Console.WriteLine($"{result[0]:D2}:{result[1]:D2}:{result[2]:D2}");
            Console.ReadLine();
        }
    }
}