using System;
using System.Collections.Generic;
//풀이보고 참고
public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        List<int> list = new List<int>();
        
        foreach(int burger in ingredient)
        {
            list.Add(burger);
            
            if(list.Count >= 4)
            {           
                if(list[list.Count - 4] == 1 && list[list.Count - 3] == 2 && 
                   list[list.Count - 2] == 3 && list[list.Count - 1] == 1)
                {
                    answer++;
                    list.RemoveRange(list.Count - 4, 4);
                }
            }
        }
        return answer;
    }
}