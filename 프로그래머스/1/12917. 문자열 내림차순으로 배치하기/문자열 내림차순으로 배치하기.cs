using System;
public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] carr= s.ToCharArray();
        
        Array.Sort(carr);
        Array.Reverse(carr);
        
        answer = new String(carr);
        return answer;
    }
}