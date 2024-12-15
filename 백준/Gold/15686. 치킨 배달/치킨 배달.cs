
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());

            //int T = Convert.ToInt32(Console.ReadLine());
            int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int N = inputArr[0];
            int M = inputArr[1];

            int[,] village = new int[N+1, N+1];
            var shopXY = new List<(int, int)>();
            var homeXY = new List<(int, int)>();

            int[] moveX = new int[4] { 0, 0, -1, 1 };
            int[] moveY = new int[4] { -1, 1, 0, 0 };

            int sum = 0;
            int result = int.MaxValue;

            for (int i = 1; i <= N; i++) 
            {
                int[] line = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
                for (int j = 1; j <= N; j++) 
                {
                    village[i, j] = line[j-1];
                    if (line[j-1]==2)
                    {
                        village[i, j] = 0;
                        shopXY.Add((i, j));
                    }
                    if (line[j - 1] == 1)
                    {
                        homeXY.Add((i, j));
                    }
                }
            }
            

            var newHomeXY = new List<(int, int)>();
            comb(shopXY, M, newHomeXY, 0);
            sw.WriteLine($"{result}");
            sw.Flush(); sw.Close();

            void resetShopPos() 
            {
                for (int i = 0; i < shopXY.Count; i++)
                {
                    var (x, y) = (shopXY[i].Item1, shopXY[i].Item2);
                    village[x, y] = 0;
                }
            }

            void comb(List<(int, int)> list, int k, List<(int, int)> current, int start)
            {
                if (current.Count == k)
                {
                    sum = 0;
                    for (int i = 0; i < current.Count; i++)
                    {
                        var (x, y) = (current[i].Item1, current[i].Item2);
                        village[x, y] = 2;
                    }
                    
                    for (int i = 0; i < homeXY.Count; i++)
                    {
                        sum += bfs(homeXY[i].Item1, homeXY[i].Item2);
                    }

                    if (sum < result)
                        result = sum;

                    resetShopPos();

                    return;
                }

                for (int i = start; i < list.Count; i++)
                {
                    current.Add(list[i]);
                    comb(list, k, current, i + 1);
                    current.RemoveAt(current.Count - 1);
                }
            }



            int bfs(int startX, int startY)
            {
                Queue<(int, int, int)> que = new Queue<(int, int, int)>();
                que.Enqueue((startX, startY, 0));
                bool[,] visited = new bool[N + 1, N + 1];
                visited[startX, startY] = true;

                while (que.Count > 0)
                {
                    var (curPosX, curPosY, curDis) = que.Dequeue();

                    if (village[curPosX, curPosY]== 2)
                    {
                        return curDis;
                    }

                    for (int i = 0; i < 4; i++)
                    {
                        int nextPosX = curPosX + moveX[i];
                        int nextPosY = curPosY + moveY[i];
                        if (nextPosX > 0 && nextPosX <= N && nextPosY > 0 && nextPosY <= N
                            && !visited[nextPosX, nextPosY])
                        {
                            visited[nextPosX, nextPosY] = true;
                            que.Enqueue((nextPosX, nextPosY, curDis + 1));
                        }
                    }
                }
                return sum;
            }
        }
    }
}
