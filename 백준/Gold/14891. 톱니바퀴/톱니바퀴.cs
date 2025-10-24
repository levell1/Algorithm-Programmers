
using System.Security.AccessControl;
using static System.Net.WebRequestMethods;

class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static List<char>[] gears = new List<char>[4];


    static void Main()
    {

        //int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        for (int i = 0; i < 4; i++)
        {
            string gear = Console.ReadLine();
            gears[i] = new List<char>();
            gears[i] = gear.ToList();
        }

        int K = int.Parse(Console.ReadLine());

        for (int i = 0; i < K; i++)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = input[0]-1;
            int rotation = input[1];
            RotationGear(n, rotation);
        }
        int result = 0;
        if (gears[0][0] == '1')
            result += 1;
        if (gears[1][0] == '1')
            result += 2;
        if (gears[2][0] == '1')
            result += 4;
        if (gears[3][0] == '1')
            result += 8;

        sw.WriteLine(result);
        sw.Flush(); sw.Close();
    }

    static void RotationGear(int n, int rotation)
    {
        int[] dirs = new int[4];
        dirs[n] = rotation;

        for (int i = n-1; i >=0; i--)
        {
            if (gears[i][2] != gears[i + 1][6])
            {
                dirs[i] = -dirs[i + 1];
            }
            else
                break;
        }
        for (int i = n + 1; i < 4; i++)
        {
            if (gears[i][6] != gears[i - 1][2])
            {
                dirs[i] = -dirs[i - 1];
            }
            else
                break;
        }
        for (int i = 0; i < 4; i++)
        {
            if (dirs[i]==0)
            {
                continue;
            }
            Rotation(i, dirs[i]);
        }
    }

    static void Rotation(int cur,int rotation) 
    {
        if (rotation == 1)
        {
            char temp = gears[cur][7];
            gears[cur].RemoveAt(7);
            gears[cur].Insert(0, temp);
        }
        else
        {
            char temp = gears[cur][0];
            gears[cur].RemoveAt(0);
            gears[cur].Add(temp);
        }
    }

}
