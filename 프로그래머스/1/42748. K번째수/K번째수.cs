using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)] ;
        int[] a;
        for(int i = 0; i < commands.GetLength(0) ;i++)
        {
            int q = commands[i,0]-1;
            int p = commands[i,1]-1;
            a= new int[p-q+1];
            if(p!=q)
            {
                for(int j = q; j<=p; j++)
                {
                    a[j-q]= array[j];
                }
            }else
            {
                a[0]=array[p];
            }
            Array.Sort(a);
            int z = commands[i,2]-1;
            answer[i]=a[z];
                

        }
        
        return answer;
    }
}