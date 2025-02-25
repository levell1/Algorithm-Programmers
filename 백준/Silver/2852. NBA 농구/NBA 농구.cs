
using System.Text;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        int n = Convert.ToInt32(Console.ReadLine());
        
        int score1 = 0;
        int score2 = 0;
        int time1 = 0;
        int time2 = 0;
        int time = 48 * 60;
        bool winning1 = false;
        bool winning2 = false;
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            int team = int.Parse(input[0]);
            int[] minSec = Array.ConvertAll(input[1].Split(":"), Convert.ToInt32);
            int curTime = minSec[0] * 60 + minSec[1];
            switch (team)
            {
                case 1: score1++; break;
                case 2: score2++; break;
            }

            if (score1>score2&&!winning1)
            {
                time1 += time - curTime;
                winning1 = true;
                winning2 = false;
            }
            else if (score2>score1&&!winning2) 
            {
                time2 += time - curTime;
                winning1 = false;
                winning2 = true;
            }
            else if (score1 == score2) 
            {
                if (winning1)
                {
                    time1 -= time - curTime;
                }else if (winning2)
                {
                    time2 -= time - curTime;
                }
                winning1 = false;
                winning2 = false;
            }

        }



        sw.WriteLine($"{time1 / 60:D2}:{time1 % 60:D2}");
        sw.WriteLine($"{time2 / 60:D2}:{time2 % 60:D2}");

        sw.Flush(); sw.Close();
    }
}
