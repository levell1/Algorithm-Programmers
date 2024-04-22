using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        int num=0;
        int[] skipn = new int[skip.Length];
        char c;


        for(int i =0;i<skip.Length;i++)
        {
            skipn[i] = (int) skip[i];
        }
        Array.Sort(skipn);
        
        for(int i = 0;i<s.Length;i++)
        {
            num = (int) s[i];
            for(int k =0;k<skip.Length;k++)
                {
                    if(skipn[k] == num)
                    {
                        num++;
                    }
                }
            for(int j = 0; j<index; j++)
            {
                num++;
                
                checkskip(skipn, skip, ref num);
                
                check(ref num);
                
                checkskip(skipn, skip, ref num);
                
                check(ref num);
            }

            
            c = (char) num;
            answer += c;
        }
        
        
        return answer;
    }
    
   public void check(ref int num)
   {
       if (num > 122)
       {
           num = num - ((int)'z' - (int)'a') - 1;
       }
   }
    
    public void checkskip(int[] skipn, string skip, ref int num)
    {
        for (int k = 0; k < skip.Length; k++)
        {
            if (skipn[k] == num)
            {
                num++;
            }
        }
    }
    
}