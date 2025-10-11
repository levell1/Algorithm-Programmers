
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
    static readonly int[] dx = { 0, 0, -1, 1 };
    static readonly int[] dy = { 1, -1, 0, 0 };
    static int[] dice;
    static int[,] board;
    static void Main()
    {
        int[] nmxyk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = nmxyk[0];
        int m = nmxyk[1];
        int x = nmxyk[2];
        int y = nmxyk[3];
        int k = nmxyk[4];
        board = new int[n, m];
        for (int i = 0; i < n; i++)
        {

            int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int j = 0; j < m; j++)
            {
                board[i, j] = line[j];
            }
        }

        dice = new int[6]; // 위 아래, 상 하 좌 우

        int[] com = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        for (int i = 0; i < com.Count(); i++)
        {
            int nx = x + dx[com[i]-1];
            int ny = y + dy[com[i]-1];


            if (nx < 0 || ny < 0 || nx >= n || ny >= m)
                continue;

            Move(com[i]);

            if (board[nx,ny]==0)
            {
                board[nx, ny] = dice[1];
            }
            else
            {
                dice[1] = board[nx, ny];
                board[nx, ny] = 0;
            }

            sw.WriteLine(dice[0]);
            x = nx;
            y = ny;
                
        }

        sw.Flush(); sw.Close();
    }

    static void Move(int dir) 
    {
        int temp;
        if (dir == 1)
        {
            temp = dice[0];
            dice[0] = dice[4];
            dice[4] = dice[1];
            dice[1] = dice[5];
            dice[5] = temp;
        } else if (dir == 2) 
        {
            temp = dice[0];
            dice[0] = dice[5];
            dice[5] = dice[1];
            dice[1] = dice[4];
            dice[4] = temp;
        }
        else if (dir == 3)
        {
            temp = dice[0];
            dice[0] = dice[3];
            dice[3] = dice[1];
            dice[1] = dice[2];
            dice[2] = temp;
        }
        else
        {
            temp = dice[0];
            dice[0] = dice[2];
            dice[2] = dice[1];
            dice[1] = dice[3];
            dice[3] = temp;
        }
    }
}
