
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        
        string[] inputArr = Console.ReadLine().Split(" ");
        int[] first = Array.ConvertAll(inputArr[0].Split(":"), Convert.ToInt32);
        int[] start = Array.ConvertAll(inputArr[1].Split(":"), Convert.ToInt32);
        int[] end = Array.ConvertAll(inputArr[2].Split(":"), Convert.ToInt32);
        int firstTime = first[0] * 60 + first[1];
        int startTime = start[0] * 60 + start[1];
        int endTime = end[0] * 60 + end[1];


        string input;

        var attendance = new HashSet<string>();
        var attendanceCheck = new HashSet<string>();

        while ((input=Console.ReadLine())!=null) 
        {
            if (input=="")
            {
                break;
            }
            string[] info = input.Split(" ");
            int[] time = Array.ConvertAll(info[0].Split(":"), Convert.ToInt32);
            int currentTime = time[0] * 60 + time[1];

            if (currentTime<=firstTime)
            {
                attendance.Add(info[1]);
            }else if (currentTime >= startTime && currentTime <= endTime)
            {
                if (attendance.Contains(info[1]))
                {
                    attendanceCheck.Add(info[1]);
                }
            }
        }
        
        sw.Write(attendanceCheck.Count);

        sw.Flush(); sw.Close();

    }
}
