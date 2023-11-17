using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        String str = string.Format("{0}",n);
        for(int i=0; i < str.Length ; i++)
        {
        answer += int.Parse(str.Substring(i,1));
        }
        return answer;
    }
}