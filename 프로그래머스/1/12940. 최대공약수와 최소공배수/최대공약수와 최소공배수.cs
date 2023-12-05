public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[] {0,0};
        for(int i = 1; i <= n;i++)
        {
            if(n%i==0)
            {
                for(int j = 1; j<=m;j++)
                {
                    if(m%j==0&&i==j)
                    {
                        answer[0]=j;
                        break;
                    }
                }
            }
        }
        answer[1]=n*m/answer[0];
        return answer;
    }
}