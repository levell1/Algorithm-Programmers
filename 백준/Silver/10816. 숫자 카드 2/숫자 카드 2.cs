using System;
using System.IO;

class Program
{
    static void Main()
    {
        // 첫 번째 입력: N개의 숫자 카드 입력
        int testcase = Convert.ToInt32(Console.ReadLine());
        int[] N = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        // 두 번째 입력: M개의 숫자 입력
        int testcase1 = Convert.ToInt32(Console.ReadLine());
        int[] M = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        // 숫자 카드 배열 정렬
        Array.Sort(N);

        var sw = new StreamWriter(Console.OpenStandardOutput());

        // 각 M에 대해 이분 탐색으로 등장 횟수 찾기
        foreach (int num in M)
        {
            int lowerBound = LowerBound(N, num);
            int upperBound = UpperBound(N, num);

            // 등장 횟수는 upperBound - lowerBound
            sw.Write((upperBound - lowerBound) + " ");
        }

        sw.Flush(); 
        sw.Close();
    }

    // Lower Bound: target이 처음 등장하는 위치
    static int LowerBound(int[] arr, int target)
    {
        int left = 0, right = arr.Length;

        while (left < right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] >= target)
                right = mid;
            else
                left = mid + 1;
        }

        return left;
    }

    // Upper Bound: target보다 큰 숫자가 처음 등장하는 위치
    static int UpperBound(int[] arr, int target)
    {
        int left = 0, right = arr.Length;

        while (left < right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] > target)
                right = mid;
            else
                left = mid + 1;
        }

        return left;
    }
}
