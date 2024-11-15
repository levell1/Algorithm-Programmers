using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int input = Convert.ToInt32(Console.ReadLine());
        int[,] paper = new int[input,input];
        int blue = 0;
        int white = 0;


        for (int i = 0; i < input; i++)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(' '),Convert.ToInt32);
            for (int j = 0; j < input; j++)
            {
                paper[i, j] = line[j];
            }
        }

        divide(paper, input);
        
        void divide(int[,] paperField, int n) 
        {
            bool check = checkColor(paperField,n);
            if (check)
            {
                return; 
            }
            n /= 2;
            int[,] first = new int[n,n];
            int[,] second = new int[n, n];
            int[,] third = new int[n, n];
            int[,] fourth = new int[n, n];
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    first[i, j] = paperField[i,j];
                    second[i, j] = paperField[i+n, j];
                    third[i, j] = paperField[i, j+n];
                    fourth[i, j] = paperField[i+n, j+n];
                }
            }
            divide(first, n);
            divide(second, n);
            divide(third, n);
            divide(fourth, n);
        }


        bool checkColor(int[,] field, int n ) 
        {
            int a = field[0,0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (field[i,j]!=a)
                    {
                        return false;
                    }
                }
            }
            if (a==1)
            {
                blue++;
            }
            else
            {
                white++;
            }
            return true;
        }

        sb.AppendLine(white.ToString());
        sb.AppendLine(blue.ToString());

        Console.WriteLine(sb.ToString());
    }
}
