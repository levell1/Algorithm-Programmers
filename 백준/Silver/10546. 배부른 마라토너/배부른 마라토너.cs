
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        var marathon = new Dictionary<string, int>();

        for (int i = 0; i < input; i++)
        {
            string name = Console.ReadLine();
            if (!marathon.ContainsKey(name))
            {
                marathon.Add(name, 1);
            }
            else
            {
                marathon[name]++;
            }
        }
        for (int i = 0; i < input-1; i++)
        {
            string name = Console.ReadLine();
            if (marathon.ContainsKey(name))
            {
                marathon[name]--;
                if (marathon[name] == 0)
                {
                    marathon.Remove(name);
                }
            }
        }

        Console.WriteLine($"{marathon.Keys.First()}");
        
        sw.Flush(); sw.Close();

    }
}
