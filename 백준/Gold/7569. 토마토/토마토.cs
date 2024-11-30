

using System.Collections;
using System.Data;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int boxSizex = inputArr[0];
        int boxSizey = inputArr[1];
        int boxSizez = inputArr[2];

        int[] movex = { 0, 0, -1, 1, 0, 0 };// 상 하 좌 우 위 아래
        int[] movey = { 1, -1, 0, 0, 0, 0 };
        int[] movez = { 0, 0, 0, 0, 1, -1 };

        int[,,] tomatoBox = new int[boxSizex, boxSizey, boxSizez];

        Queue<(int, int, int)> queue = new Queue<(int, int, int)>();

        for (int k = 0; k < boxSizez; k++)
        {
            for (int j = 0;j < boxSizey; j++)
            {
                int[] tomatostate = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
                for (int i = 0; i < boxSizex; i++)
                {
                    tomatoBox[i, j, k] = tomatostate[i];
                    if (tomatostate[i] == 1)
                    {
                        queue.Enqueue((i, j, k));
                    }
                }
            }
        }

        int day = 0;

        BFS();

        sw.WriteLine($"{checkday()}");
        sw.Flush(); sw.Close();
        Console.ReadLine();

        void BFS()
        {
            while (queue.Count > 0)
            {
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    (int x, int y, int z) curPos = queue.Dequeue();
                    for (int j = 0; j < 6; j++)
                    {
                        (int x, int y, int z) NextPos = (curPos.x + movex[j], curPos.y + movey[j], curPos.z + movez[j]);
                        if (NextPos.x >= 0 && NextPos.x < boxSizex &&
                            NextPos.y >= 0 && NextPos.y < boxSizey &&
                            NextPos.z >= 0 && NextPos.z < boxSizez)
                        {
                            if (tomatoBox[NextPos.x, NextPos.y, NextPos.z] == 0)
                            {
                                tomatoBox[NextPos.x, NextPos.y, NextPos.z] = 1;
                                queue.Enqueue(NextPos);
                            }
                        }
                    }
                }
                day++;
            }
            
        }



        int checkday()
        {
            for (int k = 0; k < boxSizez; k++)
            {
                for (int j = 0; j < boxSizey; j++)
                {
                    for (int i = 0; i < boxSizex; i++)
                    {
                        if (tomatoBox[i, j, k] == 0)
                        {
                            return -1;
                        }
                    }
                }
            }
            return day-1;
        }
    }
}
