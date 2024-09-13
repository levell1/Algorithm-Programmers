using System;

class Program
{
    static void Main()
    {
        int L = int.Parse(Console.ReadLine()); // 문자열의 길이 입력
        string input = Console.ReadLine();     // 문자열 입력

        long hashValue = 0;
        long r = 31; // 고정된 r 값
        long M = 1234567891; // 고정된 M 값
        long pow = 1; // r의 거듭제곱 값을 저장하는 변수

        for (int i = 0; i < L; i++)
        {
            int charValue = input[i] - 'a' + 1; // 'a'는 1, 'b'는 2, ..., 'z'는 26
            hashValue = (hashValue + charValue * pow) % M;
            pow = (pow * r) % M; // r의 다음 거듭제곱 값을 계산
        }

        // 결과 출력
        Console.WriteLine(hashValue);
    }
}