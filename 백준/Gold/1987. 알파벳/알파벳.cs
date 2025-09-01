

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static char[,] board;
    static int[] alphabet;

    static readonly int[] dx = { 0, 0, 1, -1 };
    static readonly int[] dy = { 1, -1, 0, 0 };

    static int r ;
    static int c ;
    static int max;
    static void Main()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);

        r = input[0];
        c = input[1];

        board = new char[r, c];
        alphabet = new int[26];

        max = 0;

        for (int i = 0; i < r; i++)
        {
            string str = Console.ReadLine();

            for (int j = 0; j < c; j++)
            {
                board[i, j] = str[j];
            }
        }

        DFS(0, 0,1);

        sw.WriteLine(max);
        sw.Flush(); sw.Close();
    }
    
    static void DFS(int x, int y,int count) 
    {
        alphabet[board[x, y] - 'A']++;
        max = Math.Max(max, count);

        for (int i = 0; i < 4; i++)
        {
            int nx = dx[i] + x;
            int ny = dy[i] + y;

            if (nx >= 0 && ny >= 0 && nx < r && ny < c)
            {
                if (alphabet[board[nx, ny] - 'A'] == 0)
                {
                    DFS(nx, ny, count + 1);
                }
            }
        }
        alphabet[board[x, y] - 'A'] = 0;

    }
}
