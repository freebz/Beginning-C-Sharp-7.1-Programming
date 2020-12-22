// #pragma의 "CS" 접두사 지원

#pragma warning disable 0168

#pragma warning disable CS0168

// C# 6.0부터 위의 2가지 구문 모두 지원

class Program
{
    static void Main(string[] args)
    {
        int i; // 경고 CS0168: 'i' 변수가 선언되었지만 사용되지 않았습니다.
    }
}