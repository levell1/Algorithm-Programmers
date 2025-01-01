
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        var problems = new SortedDictionary<int, SortedSet<int>>();
        var problemlevel = new Dictionary<int, int>();
        for (int i = 0; i < input; i++)
        {
            int[] addPL = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int p = addPL[0];
            int l = addPL[1];

            if (!problems.ContainsKey(l))
                problems[l] = new SortedSet<int>();
            problems[l].Add(p);
            problemlevel[p] = l;
        }


        input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        
        for (int i = 0; i < input; i++)
        {
            string[] commend =Console.ReadLine().Split(" ");
            int commendNum = 0;
            int problemNum = 0;
            int level = 0;
            switch (commend[0])
            {
                case "recommend":
                    commendNum = Convert.ToInt32(commend[1]);
                    if (commendNum == -1)
                    {
                        var find = problems.First();
                        sw.WriteLine(find.Value.Min);
                    }
                    else if (commendNum == 1)
                    {

                        var find = problems.Last();
                        sw.WriteLine(find.Value.Max);
                    }
                    break;
                case "solved":
                    problemNum = Convert.ToInt32(commend[1]);
                    level = problemlevel[problemNum];
                    problemlevel.Remove(problemNum);
                    problems[level].Remove(problemNum);
                    if (problems[level].Count==0)
                    {
                        problems.Remove(level);
                    }
                    break;
                case "add":
                    problemNum = Convert.ToInt32(commend[1]);
                    level = Convert.ToInt32(commend[2]);
                    if (!problems.ContainsKey(level))
                        problems[level] = new SortedSet<int>();
                    problems[level].Add(problemNum);
                    problemlevel[problemNum] = level;
                    break;
                default:
                    break;
            }

        }

        sw.Flush(); sw.Close();

    }
}
