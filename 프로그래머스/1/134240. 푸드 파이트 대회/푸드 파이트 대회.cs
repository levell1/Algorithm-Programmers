using System;

public class Solution {
    public string solution(int[] food) {
        string answer = "0";
        int a = 0;
        for(int i= food.Length-1;i>0;i--)
        {
            a = food[i]/2;
                for(int j=0;j<a;j++)
                {
                    answer = i.ToString() + answer;
                    answer += i.ToString();
                }           
        }

        return answer;
    }
}