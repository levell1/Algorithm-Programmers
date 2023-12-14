using System;
using System.Linq;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int len=0;
        int len2=0;
        int temp;

        for(int i = 0; i<sizes.GetLength(0);i++){
            if(sizes[i,0]>sizes[i,1])
            {
                temp = sizes[i,0];
                sizes[i,0] = sizes[i,1];
                sizes[i,1] = temp;
            }
        }

        for(int i = 0; i<sizes.GetLength(0);i++)
        {
            if(len<sizes[i,0])
            {
                len = sizes[i,0];   
            }
            if(len2<sizes[i,1])
            {
                len2 = sizes[i,1];   
            }
            
        }
        answer = len*len2;
        return answer;
    }
}