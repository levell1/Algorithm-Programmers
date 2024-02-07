using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        bool check=true;
        for(int i = 0; i<nums.Length-2; i++)
        {
            for(int j = i+1; j<nums.Length-1; j++)
            {
               for(int k = j+1; k < nums.Length; k++)
                {
                    check = true;
                    float sum = nums[i]+nums[j]+nums[k];
                    for(int s = 2; s < sum/2; s++)
                    {
                        if (sum % s == 0)
                        {
                            check=false;
                            break;
                        }
                    }
                   if(check){answer++;}
                } 
            }
        }
        return answer;
    }
}