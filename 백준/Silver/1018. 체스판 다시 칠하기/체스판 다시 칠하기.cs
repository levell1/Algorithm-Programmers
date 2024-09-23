using System;


class Program
{

    static void Main()
    {
        string input = Console.ReadLine();
        string[] xy = input.Split(' ');
        int[] testcase = new int[2];
        testcase[0] = Convert.ToInt32(xy[0]);
        testcase[1] = Convert.ToInt32(xy[1]);
        int count = 64;
        int min = 64;
        
        char[,] board = new char[testcase[0], testcase[1]];
        char WB= 'W';
        for (int i = 0; i < testcase[0]; i++)
        {
            string WorB = Console.ReadLine();
            WorB.ToCharArray();
            for (int j = 0; j < testcase[1]; j++)
            {
                board[i, j] = WorB[j];
            }
        }

        for (int i = 0; i < testcase[0]-7; i++)
        {
            for (int j = 0; j < testcase[1]-7; j++)
            {
                WB = 'W';
                for (int two = 0; two < 2; two++)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        for (int z = 0; z < 8; z++)
                        {
                            if (board[i + k, j + z].Equals(WB))
                            {
                                count--;
                            }
                            WB = (WB == 'W') ? 'B' : 'W';
                        }
                        WB = (WB == 'W') ? 'B' : 'W';
                    }
                    if (min > count)
                    {
                        min = count;
                    }
                    WB = 'B';
                    count = 64;
                }
            }
           
        }

        Console.WriteLine(min);

        Console.ReadLine();
    }
    
}
