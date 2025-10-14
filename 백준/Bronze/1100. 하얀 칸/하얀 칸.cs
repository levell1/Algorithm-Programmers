
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {
        char [,] board = new char[8, 8];
        int count = 1;
        int result = 0;

        for (int i = 0; i < 8; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < 8; j++)
            {
                if (count % 2 == 1)
                {
                    if (line[j] == 'F')
                    {
                        result++;
                    }
                }
                count++;
            }
            count++;
        }


        sw.WriteLine(result);
        sw.Flush(); sw.Close();
    }

}
