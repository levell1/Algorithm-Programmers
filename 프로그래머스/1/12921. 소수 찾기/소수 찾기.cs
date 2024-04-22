public class Solution {
    public int solution(int n) {
        int answer = 0;
        bool check = true;
        
        for(int i=2;i<=n;i++)
        {
            for(int j=2;j*j<=i;j++)
            {
                if(i % j == 0)
                {
                    check=false;
                    break;
                }
            }
            if(check){
                answer++;
            }
            check = true;
        }
        
        return answer;
    }
}