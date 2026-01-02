
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static int[,] board;
    static List<(int, int)> empty = new List<(int, int)>();
    static bool finished = false;
    static void Main()
    {
        //int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

        board = new int[9, 9];

        for (int i = 0; i < 9; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < 9; j++)
            {
                board[i, j] = line[j] - '0';
                if (board[i, j] == 0)
                {
                    empty.Add((i, j));
                }
            }
        }

        DFS(0);

        sw.WriteLine();
        sw.Flush(); sw.Close();
    }

    static void DFS(int a)
    {
        if (a == empty.Count)
        {
            Write();
            finished = true;
            return;
        }

        var (r, c) = empty[a];

        for (int i = 1; i <= 9; i++)
        {
            if (Check(r, c, i))
            {
                board[r, c] = i;
                DFS(a + 1);
                if (finished) return;
                board[r, c] = 0;
            }
        }
    }
    static void Write()
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                sw.Write(board[i, j]);
            }
            sw.WriteLine();
        }
    }

    static bool Check(int r, int c, int num)
    {
        for (int i = 0; i < 9; i++)
        {
            if (board[r,i] ==num)
            {
                return false;
            }
            if (board[i,c]==num)
            {
                return false;
            }
        }
        int sr = (r / 3) * 3;
        int sc = (c / 3) * 3;

        for (int i = sr; i < sr+3; i++)
        {
            for (int j = sc; j < sc+3; j++)
            {
                if (board[i, j] == num)
                {
                    return false;
                }
            }
        }

        return true;
    }
}


