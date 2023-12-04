public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int row = arr1.GetLength(0);
        int col = arr1.GetLength(1);
        int[,] answer = new int[row,col];
        for(int i = 0; i<row;i++)
        {
            for(int j = 0; j<col;j++)
            {
                answer[i,j] = arr1[i,j]+arr2[i,j];
            }
            
        }
        return answer;
    }
}