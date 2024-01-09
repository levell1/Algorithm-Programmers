using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> list= new List<int>();
        
        for(int i =0 ; i<score.Length ; i++)
        {
            list.Add(score[i]);
            list.Sort();
            
            if(i>=k)
            {
                list.RemoveAt(0);
            }
            answer[i] = list[0];
        }
        
        return answer;
    }
}