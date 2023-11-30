using System;
public class Solution {
    public int[] solution(int[] arr) {
        int[] answer;
        Array.Sort(arr);
        Array.Reverse(arr);
        if(arr.Length==1){
            answer= new int[]{-1};
        }
        else
        {
            answer= new int[arr.Length-1];
            for(int i = 0; i<arr.Length-1;i++)
            {
                answer[i]= arr[i];
            }
        }
        return answer;
    }
}