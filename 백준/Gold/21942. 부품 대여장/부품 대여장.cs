class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int[] monthDayCount = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        string[] inputArr = Console.ReadLine().Split(" ");
        
        int infoCount = Convert.ToInt32(inputArr[0]);
        string[] time = inputArr[1].Split("/");
        int day = Convert.ToInt32(time[0]);
        long rentalToMin = convertAndHourToMin(time[1],day);

        long convertAndHourToMin(string hourmin, int day) 
        {
            string[] hourMin = hourmin.Split(":");
            int hour = Convert.ToInt32(hourMin[0]);
            int min = Convert.ToInt32(hourMin[1]);
            return day * 24 * 60 + hour * 60 + min;
        }

        int fine = Convert.ToInt32(inputArr[2]);


        var problems = new SortedDictionary<string, Dictionary<string ,long >>();
        var checkList = new SortedDictionary<string,long>();
        for (int i = 0; i < infoCount; i++)
        {
            string[] info = Console.ReadLine().Split(" ");
            string robotPart = info[2];
            string name = info[3];
            int[] monthDay = Array.ConvertAll(info[0].Split("-"), Convert.ToInt32);
            int monthToDay = 0;
            if (monthDay[1]>1)
            {
                int curMonth = monthDay[1];
                for (int j = 0; j < curMonth-1; j++) 
                {
                    monthToDay += monthDayCount[j];
                }
            }

            int curDay = monthToDay + monthDay[2];

            long curToMin = convertAndHourToMin(info[1], curDay);

            long returnTime = curToMin + rentalToMin;

            if (!problems.ContainsKey(name))
            {
                problems[name] = new Dictionary<string, long>();
                checkList[name] = 0;
            }


            if (problems[name].ContainsKey(robotPart))
            {
                long overTime = curToMin - problems[name][robotPart];
                if (overTime>0)
                {
                    checkList[name] += overTime*fine;
                }
                
                problems[name].Remove(robotPart);
            }
            else
            {
                problems[name].Add(robotPart, returnTime);
            }
            
            
        }
        bool hasfine = false;
        foreach (var item in checkList)
        {
            long money = item.Value;
            if (item.Value>0)
            {
                sw.WriteLine($"{item.Key} {money}");
                hasfine=true;
            }
        }

        if (!hasfine)
        {
            sw.WriteLine(-1);
        }

        sw.Flush(); sw.Close();

    }
}
