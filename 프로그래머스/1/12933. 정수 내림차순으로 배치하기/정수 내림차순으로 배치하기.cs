//using System;
public class Solution {
    public long solution(long n) 
    {
        long answer = 0;
        string s = n.ToString();
        long len = s.Length;
        int[] arr = new int[len];
        int temp;
        long x = 1;
        
        for(int i =0; i<len; i++)   
        {
            arr[i] = s[i]-'0';
        }
        
        //Array.Sort(arr);
        for(long i = 0; i<len; i++)
        {
            for(long j= i+1; j<len;j++)
            {
                if(arr[i] < arr[j])
                {
                    temp = arr[i];
                    arr[i]=arr[j];
                    arr[j]=temp;
                }
            }
        }
        for(long i= len-1; i>=0; i--)
        {
            answer += arr[i] * x;
            x=x*10;
        }
        
        return answer;
    }
}