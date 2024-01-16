using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "No";
        int count =0;
        int counts=0;
        
        for(int i =0;i<goal.Length;i++)
        {
            if(cards1.Length>count&&goal[i] == cards1[count])
            {
                count++;
            }
            else if(cards2.Length>counts&&goal[i] == cards2[counts])
            {
                counts++;
            }else
            {
                return "No";
            }
        }

        if(count==cards1.Length&&counts==cards2.Length)
        {
            answer="Yes";
        }
        
            
        return "Yes";
    }
}