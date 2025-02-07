
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int n = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int n = Convert.ToInt32(Console.ReadLine());
        List<(int start,int end)> list = new List<(int, int)>();
        for (int i = 0; i < n; i++)
        {
            int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int start = inputArr[0] * 100 + inputArr[1];   
            int end = inputArr[2] * 100 + inputArr[3];
            list.Add((start,end));
        }

        list.Sort((a, b) => a.start == b.start ? b.end.CompareTo(a.end) : a.start.CompareTo(b.start));

        int count = 0;
        int cur = 301;
        int late = 0;
        int index = 0;
        while (cur<=1130) 
        {
            bool find = false;
            while (index < n && list[index].start <= cur) 
            {
                if (list[index].end>late)
                {
                    late = list[index].end;
                    find = true;
                }
                index++;
            }

            if (find)
            {
                cur = late;
                count++;
            }
            else
            {
                count = 0;
                break;
            }
        }


        sw.WriteLine(count);
        sw.Flush(); sw.Close();

    }
}
