public class Solution {
    public int[] solution(long n) {
        string str = n.ToString();
        int len = str.Length;
        int[] answer = new int[len];
        int num = 0;
        for(int i = str.Length-1; i>=0 ;i--)
        {
            answer[str.Length-i-1]= str[i]-'0';
        }
        return answer;
    }
}