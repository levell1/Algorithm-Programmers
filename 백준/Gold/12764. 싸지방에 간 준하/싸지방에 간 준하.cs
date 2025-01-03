using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        var list = new List<(int start, int end)>();
        for (int i = 0; i < input; i++)
        {
            int[] startEnd = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int start = startEnd[0];
            int end = startEnd[1];
            list.Add((start, end));
        }

        list.Sort();

        var min = new SortedList<int , int>();
        var count = new List<int>();
        int removeCount = 0;

        for (int i = 0; i < input; i++)
        {
            var (curStart, curEnd) = list[i];

            if (min.Count > 0 && min.Keys.First() <= curStart)
            {
                int pos = min.Values.First();
                int find = min.Keys.First();
                for (int j = 0; j < min.Count; j++)
                {
                    if (min.Keys[j]>curStart)
                    {
                        break;
                    }

                    if (pos>= min.Values[j])
                    {
                        pos = min.Values[j];   
                        find = min.Keys[j];
                    }
                }
                min.Remove(find);
                min.Add(curEnd,pos);
                count[pos]++;
                removeCount++;
            }
            else
            {
                min.Add(curEnd, i-removeCount);
                count.Add(1);
            }
        }


        sw.WriteLine(count.Count);
        sw.Write(string.Join(" ", count));

        sw.Flush(); sw.Close();

    }
}
