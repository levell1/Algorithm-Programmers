public class Solution {
    public string solution(int num) {
        string answer = "";
        if(num % 2 == 0){
            answer = "Even";
        }else
        {
        answer = "Odd";
        }
        return answer;
    }
}