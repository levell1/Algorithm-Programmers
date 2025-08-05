


class Program
{

    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        string str = Console.ReadLine();
        int[] count = new int[10];

        int max = 0;

        foreach (var c in str)
        {
            count[c - '0']++;
        }

        int sum = (count[6] + count[9]+1) / 2;
        count[6] = sum;
        for (int i = 0; i < 9; i++)
        {
            if (max < count[i])
            {
                max = count[i];
            }
        }
        

        sw.WriteLine(max);
        sw.Flush(); sw.Close();
    }



}