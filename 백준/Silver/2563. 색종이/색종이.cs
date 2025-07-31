

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = Convert.ToInt32(Console.ReadLine());

        bool[,] field = new bool[100,100];

        

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            int x = Convert.ToInt32(input[0]);
            int y = Convert.ToInt32(input[1]);

            int curx = x;
            int cury = y;

            for (int j = x; j < x+10; j++)
            {
                for (global::System.Int32 k = y; k < y+10; k++)
                {
                    if (j <= 100 && k <= 100)
                    {
                        field[j, k] = true;
                    }
                }
            }
           

        }
        int result = 0;
        foreach (var item in field)
        {
            if (item)
            {
                result++;
            }
        }
        sw.Write(result);
        sw.Flush(); sw.Close();

    }
    
}