
class Program
{
    static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

    static void Main()
    {

        char result ='E' ;
        for (int i = 0; i < 3; i++)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int count = 0;
            result = 'E';
            for (int j = 0; j < 4; j++)
            {
                if (n[j]==0)
                {
                    count++;
                }
                
            }
            if (count==1)
            {
                result = 'A';
            }
            else if (count == 2)
            {
                result = 'B';
            }
            else if (count == 3)
            {
                result = 'C';
            }
            else if (count == 4)
            {
                result = 'D';
            }
            sw.WriteLine(result);
        }

        
        sw.Flush(); sw.Close();
    }

}


