
class Program
{
    static int[] input;
    static int E, S, M;
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        E = input[0];   //15
        S = input[1];   //28
        M = input[2];   //19
        
        int count = 0;

        while (true)
        {
            count++;
            if ((count - 1) % 15 == E - 1 && (count - 1) % 28 == S - 1 && (count - 1) % 19 == M - 1)
            {
                break;
            }
        }

        sw.WriteLine(count);
        sw.Flush(); sw.Close();
    }

   
}
