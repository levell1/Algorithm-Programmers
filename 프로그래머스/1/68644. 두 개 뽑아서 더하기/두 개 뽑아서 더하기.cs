using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[] {};
        List<int> list = new List<int>();
        
        for(int i = 0;i<numbers.Length-1;i++)
        {
            for(int j = i+1; j<numbers.Length;j++)
            {
                list.Add(numbers[i]+numbers[j]);
            }
        }
        list = list.Distinct().ToList();
        answer = list.ToArray();
        Array.Sort(answer);
        return answer;
    }
}