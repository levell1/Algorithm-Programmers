//풀이 참조
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int input = Convert.ToInt32(Console.ReadLine());
        //int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

        string input = Console.ReadLine();

        var op = new Stack<char>();
        var result = new List<char>();
        foreach (char i in input) 
        {

            if ('A'<=i&&i<='Z')
            {
                result.Add(i);
            }
            else if(i=='(')
            {
                op.Push(i);
            }
            else if (i == ')')
            {
                while (op.Count > 0 && op.Peek() != '(')
                {
                    result.Add(op.Pop());
                }
                op.Pop(); // 여는 괄호 제거
            }
            else
            {
                while (op.Count > 0 && Precedence(op.Peek()) >= Precedence(i))
                {
                    result.Add(op.Pop());
                }
                op.Push(i);
            }

        }

        // 스택에 남은 연산자를 결과에 추가
        while (op.Count > 0)
        {
            result.Add(op.Pop());
        }

        int Precedence(char op)
        {
            return op switch
            {
                '+' or '-' => 1,
                '*' or '/' => 2,
                '(' => 0 
            };
        }


        sw.Write(string.Join("",result));
        sw.Flush(); sw.Close();

    }
}
