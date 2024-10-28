using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

class Program
{
    static void Main()
    {

        int inputN = int.Parse (Console.ReadLine());
        int[] N = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        Array.Sort(N);

        int inputM = int.Parse(Console.ReadLine());
        int[] M = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < inputM; i++)
        {

            int left =0;
            int right =N.Length-1;
            bool check = true;
            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (N[mid] == M[i]) 
                {
                    sb.Append("1 ");
                    check = false;
                    break;
                }
                else if(N[mid] > M[i])
                {
                    right = mid-1;
                }
                else
                {
                    left = mid+1;
                }
            }
            if (check)
            {
                sb.Append("0 ");
            }
            
        }
        
        Console.WriteLine(sb.ToString());
        Console.ReadLine();
    }
}

