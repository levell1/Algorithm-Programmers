
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int N = inputArr[0];
        int Q = inputArr[1];

        var list = new int[N + 1];
      

        int edge = 0;
        int cur = 1;
        while (true)
        {
            int start = cur;
            int left = cur * 2;
            int right = cur * 2 + 1;

            list[left]=start;
            edge++;
            if (edge == N - 1)
            {
                break;
            }

            list[right] = start;
            edge++;
            if (edge == N - 1)
            {
                break;
            }
            cur++;
        }
        var Occupied = new bool[N + 1];
        int result ;

        for (int i = 0; i < Q; i++)
        {
            int pos = Convert.ToInt32(Console.ReadLine());
            result = 0;
            BFS(pos);
            if (result==0)
            {
                Occupied[pos] = true;
            }

            sw.WriteLine(result);
        }

        sw.Flush(); sw.Close();


        void BFS(int start)
        {
            if (Occupied[start])
            {
                result = start;
            }
            int next = list[start];
            if (start>1)
            {
                BFS(next);
            }
            

        }
    }
}
