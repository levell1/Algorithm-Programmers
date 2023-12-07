public class Solution {
    public string solution(string s) {
        string answer = "";
        s= s.ToUpper();
        string[] words = s.Split(' ');
        for(int i =0; i<words.Length;i++)
        {
            char[] str = words[i].ToCharArray();
            for(int j=1; j<words[i].Length; j++)
            {
                if(j%2==1)
                {
                str[j]=char.ToLower(str[j]);
                }
            }
            words[i] = new string(str);
        }
        answer = string.Join(' ',words);
        return answer;
    }
}