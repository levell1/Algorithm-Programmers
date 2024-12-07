class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        //int input = Convert.ToInt32(Console.ReadLine());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int h = inputArr[0];
        int w = inputArr[1];
        int[,] board = new int[h, w];

        int[] zero0 = new int[] { 0, 0 };int[] zero1 = new int[] { 0, 1 };int[] zero2 = new int[] { 0, 2 };int[] zero3 = new int[] { 0, 3 };
        int[] one0 = new int[] { 1, 0 }; int[] one1 = new int[] { 1, 1 }; int[] one2 = new int[] { 1, 2 };
        int[] two0 = new int[] { 2, 0 }; int[] two1 = new int[] { 2, 1 }; int[] two2 = new int[] { 2, 2 };
        int[] three0 = new int[] { 3, 0 };


        int[][][] tetrominos = new int[][][]
        {
        // 1. 막대기 모양 (4가지)
        new int[][] { zero0, zero1, zero2, zero3 },
        new int[][] { zero0, one0, two0, three0 },

        // 2. 정사각형 모양 (1가지)
        new int[][] { zero0, zero1, one0, one1 },

        // 3. L자 모양 (8가지)
        new int[][] { zero0, zero1, zero2, one0 },
        new int[][] { zero0, zero1, one1,two1 },
        new int[][] { zero2, one2, one1, one0 },
        new int[][] { zero0, one0, two0, two1 },
        new int[][] { zero1, one1, two1, two0 },
        new int[][] { zero0, zero1, zero2, one2 },
        new int[][] { zero0, zero1, one0, two0 },
        new int[][] { zero0, one0, one1, one2 },
        
        // 4. Z자 모양 (4가지)
        new int[][] { zero0, zero1, one1, one2 },
        new int[][] { zero2, zero1, one1, one0 },
        new int[][] { zero0, one0, one1, two1 },
        new int[][] { zero1, one1, one0, two0 },

        // 5. ㅗ 모양 (4가지)
        new int[][] { zero0, zero1, zero2, one1 },
        new int[][] { one0, zero1, one1, two1 },
        new int[][] { one0, one1, one2, zero1 },
        new int[][] { zero0, one0, two0, one1 }

        };

        for (int i = 0; i < h; i++)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            for (int j = 0; j < w; j++)
            {
                board[i, j] = line[j];
            }
        }
        int maxSum = 0;

        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                foreach (var tetromino in tetrominos)
                {
                    int sum = 0;
                    bool isValid = true;

                    foreach (var cell in tetromino)
                    {
                        int x = i + cell[1];
                        int y = j + cell[0];

                        if (x < 0 || x >= h || y < 0 || y >= w)
                        {
                            isValid = false;
                            break;
                        }

                        sum += board[x, y];
                    }

                    if (isValid)
                        maxSum = Math.Max(maxSum, sum);
                }
            }
        }

        sw.WriteLine(maxSum);
        sw.Flush(); sw.Close();
        Console.ReadLine();
       
    }
}