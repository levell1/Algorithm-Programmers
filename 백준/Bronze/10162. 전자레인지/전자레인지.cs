class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {

        //int[] knm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int T = int.Parse( Console.ReadLine());
        int a, b, c;
        a = T / 300;
        T %= 300;
        b = T / 60;
        T %= 60; 
        c = T / 10;
        T %= 10;
        
        

        sw.WriteLine(T>0? "-1":$"{a} {b} {c}");
        sw.Flush(); sw.Close();
    }

    
}
