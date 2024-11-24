using System.ComponentModel;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

        (int startTime,int endTime)[] time =new (int, int)[input];

        for (int i = 0; i < input; i++)
        {
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            time[i].startTime = nums[0];
            time[i].endTime = nums[1];

        }

        Array.Sort(time, (a, b) =>
        {
            if (a.endTime == b.endTime)
                return a.startTime.CompareTo(b.startTime);
            return a.endTime.CompareTo(b.endTime);

        });

        int count = 0;
        int lastTime = 0;

        foreach (var t in time)
        {
            if (t.startTime >= lastTime)
            {
                count++;
                lastTime = t.endTime;
            }

        }

        sw.Write($"{count}");

        sw.Flush(); sw.Close();
        Console.ReadLine();
    }
}