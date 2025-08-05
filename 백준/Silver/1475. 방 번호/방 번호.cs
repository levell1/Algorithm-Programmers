


class Program
{

    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        string str = Console.ReadLine();
        string nums = "0123456789";

        Dictionary<char, int> dic = new Dictionary<char, int>()
        { {'0',0 },{'1',0 },{'2',0 },{'3',0 },{'4',0 },{'5',0 },
        {'6',0 },{'7',0 },{'8',0 },{'9',0 }
        };

        int min = 0;

        foreach (var num in nums)
        {
            foreach (var c in str)
            {
                if (c==num)
                {
                    dic[num]++;
                }
            }
            if (num=='6'||num=='9')
            {
                continue;
            }
            if (min < dic[num])
            {
                min = dic[num];
            }

        }
        
        double sum = Math.Ceiling((double)(dic['6'] + dic['9']) / 2);
        if (min < sum)
        {
            min = (int)sum;
        }

        sw.WriteLine(min);
        sw.Flush(); sw.Close();
    }



}