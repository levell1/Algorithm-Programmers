using System;

public class Solution {
    public int solution(int[] number) {
        int answer = 0;
        int len = number.Length;
        for(int i =0 ; i < len ; i++)
        {
            for(int j = i+1 ; j < len ; j++)
            {
                for(int x = j+1; x<len;x++)
                {
                    if(number[i]+number[j]+number[x]==0)
                    {
                        answer+=1;
                    }
                }
            }
        }
        return answer;
    }
}