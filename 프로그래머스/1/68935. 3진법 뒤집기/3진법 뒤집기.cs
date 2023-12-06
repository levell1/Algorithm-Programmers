using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        List<int> list = new List<int>();
        int x=1;
        
        while(n>0)
        {
            list.Add(n%3);
            n=n/3;
        }
        
        list.Reverse();
        
        for(int i = 0; i<list.Count;i++)
        {
            answer += list[i]*x;
            x=x*3;
        }
        
        return answer;
    }
}