class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static int[,] paper;
    static List<(int, int)> empty;
    static bool solved;
    static void Main()
    {

        paper = new int[9, 9];
        empty = new List<(int, int)>();

        for (int i = 0; i < 9; i++)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int j = 0; j < 9; j++)
            {
                paper[i, j] = line[j];
                if (line[j]==0)
                {
                    empty.Add((i, j));
                }
                
            }
        }

        Sudoku(0);

        sw.Flush(); sw.Close();
    }

    static void Sudoku(int count)
    {
        if (solved)
        {
            return;
        }

        if (count==empty.Count)
        {
            Print();
            solved = true;
            return;
        }

        var (x, y) = empty[count];
        for (int i = 1; i <= 9; i++)
        {
            if (Check(x, y, i))
            {
                paper[x, y] = i;
                Sudoku(count + 1);
                paper[x, y] = 0;
            }
            
        }
    }

    static bool Check(int x, int y,int num) 
    {
        for (int i = 0; i < 9; i++)
        {
            if (paper[x,i]==num)
            {
                return false;
            }
        }

        for (int i = 0; i < 9; i++)
        {
            if (paper[i, y] == num)
            {
                return false;
            }
        }

        int areaX = (x / 3) * 3;
        int areaY = (y / 3) * 3;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (paper[areaX + i,areaY+j]==num)
                {
                    return false;
                }
            }
        }
        return true;
    }

    static void Print()
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                sw.Write($"{paper[i, j]} ");
            }
            sw.WriteLine();
        }
    }
}

