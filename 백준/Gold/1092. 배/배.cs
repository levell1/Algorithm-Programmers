
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        int n = Convert.ToInt32(Console.ReadLine());
        int[] weightN = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        Array.Sort(weightN,(b,a) => a.CompareTo(b));

        int m = Convert.ToInt32(Console.ReadLine());
        int[] weightM = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        Array.Sort(weightM, (b, a) => a.CompareTo(b));
        var list = weightM.ToList();

        int count = 0;
        while (list.Count>0)
        {
            if (weightN[0] < weightM[0])
            {
                break;
            }
            int cur = 0;
            for (int i = 0; i < n;)
            {
                if (weightN[i] >= list[cur])
                {
                    list.RemoveAt(cur);
                    i++;
                }
                else
                {
                    cur++;
                }
                if (cur >= list.Count) break;
            }
            count++;
        }

        sw.WriteLine(count==0 ? -1 : count);
        
        sw.Flush(); sw.Close();

    }
}
