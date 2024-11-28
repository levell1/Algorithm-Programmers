using System;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());


        int N = Convert.ToInt32(Console.ReadLine());
        int M = Convert.ToInt32(Console.ReadLine());
        string S = Console.ReadLine();

        int result = 0;
        
        for (int i = 0; i <= M - (N*2+1); i++)
        {
            int count = 0;
            while (i < M - 2)
            {
                if (S[i] == 'I' && S[i + 1] == 'O' && S[i + 2] == 'I')
                {
                    i += 2;
                    count++;
                }
                else
                {
                    break;
                }

                if (count == N)
                {
                    result++;
                    count--;
                }
            }
        }
        

        sw.WriteLine(result);
        

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}