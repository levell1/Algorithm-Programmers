

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        int[] dice = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int result = 0;
        if (dice[0] == dice[1] && dice[1] == dice[2])
        {
            result = 10000 + dice[0] * 1000;
        }
        else if (dice[0] == dice[1])
        {
            result = 1000 + dice[0] * 100;
        }
        else if (dice[1] == dice[2])
        {
            result = 1000 + dice[1] * 100;
        }
        else if (dice[2] == dice[0])
        {
            result = 1000 + dice[2] * 100;
        }
        else
        {
            result = dice.Max() * 100;
        }

        sw.WriteLine(result);
        sw.Flush(); sw.Close();
    }

}
