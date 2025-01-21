
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

        bool impossibility = false;
        int count = 0;
        while (list.Count>0)
        {
            int curCount = list.Count;
            for (int i = 0; i < n; i++)
            {
                int cur = 0;
                if (weightN[i] >= list[cur])
                {
                    list.RemoveAt(cur);
                    if (list.Count==0)
                    {
                        break;
                    }
                }
                else
                {
                    while (true)
                    {
                        if (list.Count-1 > cur)
                        {
                            cur++;
                            if (weightN[i] >= list[cur])
                            {
                                list.RemoveAt(cur);
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                        
                    }
                }

            }
            count++;
            if (curCount==list.Count)
            {
                impossibility=true;
                break;
            }
        }

        sw.WriteLine(impossibility ? -1 : count);
        
        sw.Flush(); sw.Close();

    }
}
