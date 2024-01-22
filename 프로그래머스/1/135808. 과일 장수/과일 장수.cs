using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;

        Array.Sort(score);
        Array.Reverse(score);
        for(int i = m;i<=score.Length;i=i+m)
        {
            answer += score[i-1]*m;
        }
        
        return answer;
    }
}