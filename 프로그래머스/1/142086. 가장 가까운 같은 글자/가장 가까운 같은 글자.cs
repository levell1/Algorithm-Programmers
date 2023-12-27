using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        
        char[] cA = s.ToCharArray();
        int num=1;
        for(int i = cA.Length-1 ; i>=0;i--)
        {
            int count =-1;
            for(int j = 0; j<i;j++)
            {
                if(cA[i]==cA[j])
                {
                    count=i-j;
                }
            }
            answer[cA.Length-num] = count;
            num++;            
        }
        
        return answer;
    }
}