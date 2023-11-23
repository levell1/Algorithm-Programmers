public class Solution {
    public bool solution(int x) {
        bool answer = false;
        int sum = x/10000;
        for(int i = 10000;i>=10;i=i/10)
        {
            sum+= (x%i)/(i/10);
        }
        if(x%sum==0){answer=true;}
        return answer;
    }
}