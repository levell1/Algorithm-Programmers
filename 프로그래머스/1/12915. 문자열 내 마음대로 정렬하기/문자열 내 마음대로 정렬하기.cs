public class Solution {
    public string[] solution(string[] strings, int n) 
    {
        char[] c = new char[2]; 
        string s;   
        
        for(int i= 0; i < strings.Length-1 ; i++)
        {
            c[0] = strings[i][n];
            
            for (int j=i+1;j<strings.Length;j++)
            {
                c[1] = strings[j][n];
                if(c[0]>c[1])
                {
                    c[0] = c[1];
                    s = strings[i] ;
                    strings[i] = strings[j];
                    strings[j] = s;
                }
            }
            
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