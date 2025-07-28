
class Program
{

    static void Main()
    {

        var sw = new StreamWriter(Console.OpenStandardOutput());

        int X = Convert.ToInt32(Console.ReadLine());
        int result = 0;

        for (int i = 1; i <= X; i++)
        {
            if (d(i))
            {
                result++;
            }
        }

        sw.WriteLine(result);
        sw.Flush(); sw.Close();

    }

    static bool d(int n) 
    {
        Queue<int> que = new Queue<int>();

        while (n>=1)
        {
            que.Enqueue(n% 10);
            n /= 10;
        }      

        int first = que.Dequeue();
        int cur=0;
        int num = 0;
        if (que.Count > 0)
        {
            cur = que.Dequeue();
            num = first - cur;
        }

        while (que.Count>0)
        {
            if (num!= cur - que.Dequeue())
            {
                return false;
            }
        }

        return true;
    }

}