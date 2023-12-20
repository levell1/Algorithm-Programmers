public class Solution {
    public string[] solution(string[] strings, int n) 
    {//sort comparison<t>
        char[] c = new char[2]; // 비교할 두 개
        string s;               // temp
        
        for(int i= 0; i < strings.Length-1 ; i++)
        {
            c[0] = strings[i][n];
            int m=i;
            
            for (int j=i+1;j<strings.Length;j++)
            {
                c[1] = strings[j][n];
                if(c[0]>c[1])
                {
                    c[0] = c[1];
                    m=j;
                }
            }
            
            s = strings[i] ;
            strings[i] = strings[m];
            strings[m] = s;
            
        }
        
        for(int i= 0; i < strings.Length-1 ; i++)
        {
            c[0] = strings[i][n];
            int m=i;
            for (int j=i+1;j<strings.Length;j++)
            {
                c[1] = strings[j][n];
                if(c[0]==c[1] && string.Compare(strings[i],strings[j])>0)
                {
                    s = strings[i] ;
                    strings[i] = strings[j];
                    strings[j] = s;
                }
            }
        }
        return strings;
    }
}