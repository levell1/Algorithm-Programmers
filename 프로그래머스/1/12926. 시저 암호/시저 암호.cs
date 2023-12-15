public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        char[] c = s.ToCharArray();
        int[] Ascii= new int[c.Length];
        for(int i = 0; i<c.Length; i++)
        {
            Ascii[i] = (int)c[i];
            if(Ascii[i]!=32)
            {
                if(92>Ascii[i])
                {
                    Ascii[i]+=n;
                    if(90 < Ascii[i])
                    {
                        Ascii[i]-=26;
                    }
                }else
                    Ascii[i]+=n;
                if(Ascii[i]>122)
                {
                    Ascii[i]-=26;
                }
            }
            
            
            c[i] = (char)Ascii[i];
            
        }
        answer = new string(c);
        
        return answer;
    }
}