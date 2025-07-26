

class Program
{
    static void Main()
    {

        var sw = new StreamWriter(Console.OpenStandardOutput());

        List<int> list = new List<int>();

        int num = 0;
        int curNum = 1;
        int nextNum = 1;

        for (int i = 1; i < 10000; i++)
        {
            list.Add(i);
        }

        for (int i = 1; i <= 10000; i++)
        {
            list.Remove(nextNum);

            curNum = i;

            nextNum = curNum;
            nextNum += curNum / 10000;
            curNum %= 10000;
            nextNum += curNum / 1000;
            curNum %= 1000;
            nextNum += curNum / 100;
            curNum %= 100;
            nextNum += curNum / 10;
            curNum %= 10;
            nextNum += curNum;
        }

        list.Add(1);

        list.Sort();

        foreach (var item in list)
        {
            sw.WriteLine(item);   
        }

        sw.Flush(); sw.Close();

    }

}