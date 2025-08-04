
using System.Text;

class Program
{
    static int n;
    static string str1 = "\"재귀함수가 뭔가요?\"";
    static string str2 = "\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.";
    static string str3 = "마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.";
    static string str4 = "그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"";
    static StringBuilder sb = new StringBuilder();
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //input = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        n = Convert.ToInt32( Console.ReadLine());
        long[] dp = new long[n + 1];

        sw.WriteLine("어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.");

        Write(0);
        

        sw.WriteLine(sb.ToString());
        sw.Flush(); sw.Close();
    }

    static void Write(int count) 
    {
        string underbar = new string('_', count*4);

        sb.AppendLine($"{underbar}{str1}");

        if (count==n)
        {
            sb.AppendLine($"{underbar}\"재귀함수는 자기 자신을 호출하는 함수라네\"");
        }
        else
        {
            sb.AppendLine($"{underbar}{str2}");
            sb.AppendLine($"{underbar}{str3}");
            sb.AppendLine($"{underbar}{str4}");
            Write(count + 1);
        }

        sb.AppendLine($"{underbar}라고 답변하였지.");
    }
}