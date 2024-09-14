using System;
using System.Linq;
using System.Xml.Schema;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int testcase = Convert.ToInt32(input);

        string scores = Console.ReadLine();
        string[] score = scores.Split(' ');
        double[] intscore = new double[score.Length];

        for (int i = 0; i < score.Length; i++)
        {
            intscore[i] = Convert.ToInt32( score[i]);
        }
        
        Array.Sort(intscore);
        double max = intscore[intscore.Length - 1];
        double sum = 0;
        for (int i = 0; i < score.Length; i++)
        {
            sum += intscore[i]*100 / max;
        }
        sum = sum/ score.Length;

        Console.WriteLine(sum);

        Console.ReadLine();
    }
}
