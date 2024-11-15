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

        divide(paper,0,0, input);
        
        void divide(int[,] paperField, int x, int y, int n) 
        {
            bool check = checkColor(paperField,x,y,n);
            if (check)
            {
                return; 
            }
            n /= 2;

            divide(paperField,x,y, n);
            divide(paperField,x,y+n, n);
            divide(paperField,x+n,y, n);
            divide(paperField,x+n,y+n, n);
        }


        bool checkColor(int[,] field,int x,int y, int n ) 
        {
            int a = field[x,y];
            for (int i = x; i < x+n; i++)
            {
                for (int j = y; j < y+n; j++)
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
