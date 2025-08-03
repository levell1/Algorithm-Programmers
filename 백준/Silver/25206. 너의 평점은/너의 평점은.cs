
class Program
{

    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        int n = 1;
        int result;
        double sum = 0;
        double count=0;
        for (int i = 0; i < 20; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            if (input[2]=="P")
            {
                continue;
            }
            double grade = Convert.ToDouble(input[1]);
            double rankScore = RankToGrade(input[2]);
            sum += grade * rankScore;
            count += grade;

        }

        sw.WriteLine((sum/count).ToString("F6"));
        sw.Flush(); sw.Close();
    }

    static double RankToGrade(string rank) 
    {
        if (rank=="A+")
        {
            return 4.5;
        }
        else if (rank == "A0")
        {
            return 4.0;
        }
        else if (rank == "B+")
        {
            return 3.5;
        }
        else if (rank == "B0")
        {
            return 3.0;
        }
        else if (rank == "C+")
        {
            return 2.5;
        }
        else if (rank == "C0")
        {
            return 2.0;
        }
        else if (rank == "D+")
        {
            return 1.5;
        }
        else if (rank == "D0")
        {
            return 1.0;
        }
        else
        {
            return 0.0;
        }
    }

}