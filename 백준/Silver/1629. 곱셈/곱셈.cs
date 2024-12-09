
class Program
{
    static void Main()
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());

        //int T = Convert.ToInt32(Console.ReadLine());
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
        long a = inputArr[0];
        long b = inputArr[1];
        long c = inputArr[2];

        long result = 1;  
        a = a % c;         

        while (b > 0)      
        {
            if (b % 2 == 1) 
            {
                result = (result * a) % c;  
            }
            a = (a * a) % c;  
            b /= 2;           
        }    


        sw.Write(result);
        sw.Flush(); sw.Close();
        Console.ReadLine();
      
        
    }
}