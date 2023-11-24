public class Solution {
    public int solution(int num) {
        int answer = 0;
        int count=0;
        while(num!=1&&count<500){
            if(num%2==0)
            {
                num=num/2;
            }else if(num%2==1)
                
            {
                num=num*3+1;
            }
            count++;
        }
        if(num==1){answer=count;}
        else {answer = -1;}
        return answer;
    }
}