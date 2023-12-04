public class Solution {
    public bool solution(string s) {
        bool answer = false;
        int i = 0;
        if(s.Length==4 || s.Length==6)
        {
            answer = int.TryParse(s, out i);
        }
        return answer;
    }
}