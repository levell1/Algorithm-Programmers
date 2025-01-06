
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
            int next = start/2;
            if (start>1)
            {
                BFS(next);
            }
        }
    }
}
