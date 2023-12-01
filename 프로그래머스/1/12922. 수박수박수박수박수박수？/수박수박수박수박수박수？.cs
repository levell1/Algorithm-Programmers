public class Solution {
    public string solution(int n) {
        string answer = "";
        string Wm="수박";
        if(n%2 == 0)
        {
            for(int i=0; i<n/2;i++)
            {
                answer += Wm;
            }
        }else
        {
            for(int i=0; i<n/2;i++)
            {
                answer += Wm;
            }
            answer += '수';
        }
        return answer;
    }    
}