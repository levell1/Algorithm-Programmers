using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        var problems = new SortedDictionary<int, SortedSet<int>>(); // l p
        var problemsg = new Dictionary<int, SortedDictionary<int , SortedSet<int>>>(); // g,l p 
        var problemLevelG = new Dictionary<int, (int level, int g)>();

        for (int i = 0; i < input; i++)
        {
            int[] addPL = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            int p = addPL[0];
            int l = addPL[1];
            int g = addPL[2];
            if (!problems.ContainsKey(l))
            {
                problems[l] = new SortedSet<int>();
            }

            if (!problemsg.ContainsKey(g))
            {
                problemsg[g] = new SortedDictionary<int, SortedSet<int>>();
            }
            if (!problemsg[g].ContainsKey(l))
            {
                problemsg[g][l] = new SortedSet<int>();
            }
            problems[l].Add(p);
            problemsg[g][l].Add(p);
            problemLevelG[p] = (l,g);
        }

        input = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < input; i++)
        {
            string[] commend = Console.ReadLine().Split(" ");
            int commendNum = 0;
            int problemNum = 0;
            int commendG = 0;
            switch (commend[0])
            {
                case "recommend":
                    commendG = Convert.ToInt32(commend[1]);
                    commendNum = Convert.ToInt32(commend[2]);

                    if (commendNum == 1)
                    {
                        var find = problemsg[commendG].Last();
                        sw.WriteLine(find.Value.Max());
                    }
                    else if (commendNum == -1)
                    {
                        var find = problemsg[commendG].First();
                        sw.WriteLine(find.Value.Min());
                    }
                    break;
                case "recommend2":
                    commendNum = Convert.ToInt32(commend[1]);

                    if (commendNum == 1)
                    {
                        var find = problems.Last();
                        sw.WriteLine(find.Value.Max());
                    }
                    else if (commendNum == -1)
                    {
                        var find = problems.First();
                        sw.WriteLine(find.Value.Min());
                    }
                    break;
                case "recommend3":

                    commendNum = Convert.ToInt32(commend[1]);
                    int commendLevel = Convert.ToInt32(commend[2]);
                    bool exist = false;
                    var keys = problems.Keys;
                    if (commendNum == 1)
                    {
                        foreach (var item in keys)
                        {
                            if (item >= commendLevel)
                            {
                                sw.WriteLine(problems[item].Min());
                                exist = true;
                                break;
                            }
                        }
                        if (!exist)
                        {
                            sw.WriteLine(-1);
                        }
                    }
                    else if (commendNum == -1)
                    {

                        foreach (var item in keys.Reverse())
                        {
                            if (item < commendLevel)
                            {
                                sw.WriteLine(problems[item].Max());
                                exist = true;
                                break;
                            }
                        }
                        if (!exist)
                        {
                            sw.WriteLine(-1);
                        }
                    }
                    break;
                case "solved":
                    problemNum = Convert.ToInt32(commend[1]);
                    var (level, group) = problemLevelG[problemNum];
                    problemLevelG.Remove(problemNum);

                    problems[level].Remove(problemNum);
                    if (problems[level].Count == 0)
                    {
                        problems.Remove(level);
                    }
                    if (problemsg[group].ContainsKey(level))
                    {
                        problemsg[group][level].Remove(problemNum);
                        if (problemsg[group][level].Count == 0)
                            problemsg[group].Remove(level);
                        if (problemsg[group].Count == 0)
                            problemsg.Remove(group);
                    }
                    break;
                case "add":
                    int p = Convert.ToInt32(commend[1]);
                    int l = Convert.ToInt32(commend[2]);
                    int g = Convert.ToInt32(commend[3]);

                    if (!problems.ContainsKey(l))
                    {
                        problems[l] = new SortedSet<int>();
                    }

                    if (!problemsg.ContainsKey(g))
                    {
                        problemsg[g] = new SortedDictionary<int, SortedSet<int>>();
                    }
                    if (!problemsg[g].ContainsKey(l))
                    {
                        problemsg[g][l] = new SortedSet<int>();
                    }
                    problems[l].Add(p);
                    problemsg[g][l].Add(p);
                    problemLevelG[p] = (l, g);
                    break;
                default:
                    break;
            }

        }

        sw.Flush(); sw.Close();

    }
}
