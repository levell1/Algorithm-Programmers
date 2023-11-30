using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        List<int> answer = new List<int>(arr);
        int min= answer.Min();
        if(arr.Length==1){
            answer.Clear();
            answer.Add(-1);
        }
        else
        {
            answer.Remove(min);
        }
        return answer.ToArray();
    }
}