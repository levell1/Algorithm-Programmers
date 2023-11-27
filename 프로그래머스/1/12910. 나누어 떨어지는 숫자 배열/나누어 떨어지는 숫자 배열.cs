using System;
public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int x =0;
        int[] answer;
        for(int i = 0; i<arr.Length;i++)
        {
            if(arr[i]%divisor==0)
            {
                x++;
            }
        }
        
        if(x == 0)
        {
            answer = new int[] {-1};
        }else
        {
            answer = new int[x];
        }
        
        x = 0;
        
        for(int i = 0; i<arr.Length;i++)
        {
            if(arr[i]%divisor==0){
                answer[x]=arr[i];
                x++;
            }
        }
        Array.Sort(answer);
        
        return answer;
    }
}