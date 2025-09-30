
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static List<int> numbers;
    static int channel;
    static int min;
    static int digits;
    static void Main()
    {

        numbers = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            numbers.Add(i);
        }
        channel = int.Parse(Console.ReadLine());
        digits = channel.ToString().Length;
        int m = int.Parse(Console.ReadLine());
        int[] remove= new int[m];
        if (m!=0)
        {
            remove = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        }
        
        for (int i = 0; i < m; i++)
        {
            numbers.Remove(remove[i]);
        }
        min = Math.Abs(channel - 100);
        if (channel != 100)
        {
            if (digits >1)
            {
                Find(0, 0, -1);
            }
            Find(0, 0, 0);
            Find(0, 0, 1);

        }
        else 
        {
            min = 0;
            digits = 0;
        }
        
        sw.WriteLine(min);
        sw.Flush(); sw.Close();
    }

    static void Find(int num, int count,int dif) 
    {
        int digit = (int)Math.Pow(10, (digits - count - 1 + dif));
        
        if (count== digits+dif)
        {
            min = Math.Min(min, Math.Abs(channel - num) + digits + dif);            
            return;
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            num += numbers[i] * digit;
            Find(num, count + 1,dif);
            num -= numbers[i] * digit;
        }
    }
}

