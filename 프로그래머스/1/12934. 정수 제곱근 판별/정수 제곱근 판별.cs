public class Solution {
    public long solution(long n) {
        long answer = 0;
        for(long x = 1; x<=n; x++)
        {
            if(n/x == x&&n%x==0){
                x=x+1;
                answer = x * x ;
                break;
            }
            answer = -1;
        }
        
        return answer;
    }
}