using System;
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        double monsterDef = inputArr[0];
        double off = inputArr[1];

        double result = monsterDef - (monsterDef * off / 100);
        int answer = 1;

        if (result >= 100)
        {
            answer = 0;
            if (off == 100)
            {
                answer = 1;
            }
        }

        sw.WriteLine(answer);
        sw.Flush(); sw.Close();
    }
}