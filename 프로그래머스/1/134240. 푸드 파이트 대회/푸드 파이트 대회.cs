using System;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        string f="0";
        int a = 0;
        for(int i= food.Length-1;i>0;i--)
        {
            a = food[i]/2;
            if(a>0)
            {
                for(int j=0;j<a;j++)
                {
                    f = i.ToString() + f;
                    f += i.ToString();
                }
            }
            
        }
        answer=f;
        return answer;
    }
}