using System;

public class Solution {
    public double solution(int[] numbers) {
        double answer = 0;
        foreach(int num in numbers){
            answer+=num;
        }
        answer= answer/numbers.Length;
        return answer;
    }
}