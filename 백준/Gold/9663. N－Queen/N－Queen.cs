using System.Text;

class Program
{
    static int n;
    static int[] field;
    static int result = 0;
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        string input = Console.ReadLine();
        n = Convert.ToInt32(input);
        field = new int[n];
        Queen(0);

        sw.Write(result);
        sw.Flush(); sw.Close();

    }
    static void Queen(int row)
    {
        if (row == n)
        {
            result++;
            return;
        }

        for (int col = 0; col < n; col++)
        {
            field[row] = col;
            if (IsSafe(row))
            {
                Queen(row + 1);
            }
        }

    }
    static bool IsSafe(int row)
    {
        for (int i = 0; i < row; i++)
        {
            if (field[i] == field[row] || Math.Abs(field[row] - field[i]) == row - i)
                return false;
        }
        return true;
    }
}