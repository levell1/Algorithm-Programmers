using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        for(int i = 0; i < t.Length-p.Length+1; i++)
        {
            string strA = t.Substring(i, p.Length);
            int compare = strA.CompareTo(p);
            if (compare<=0) answer++;
        }
        return answer;
    }
}