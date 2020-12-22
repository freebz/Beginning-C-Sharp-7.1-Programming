// 재정의된 메서드의 선택 정확도를 향상

using System;

class Program
{
    static void WriteLine(uint? arg)
    {
        Console.WriteLine("uint? == " + arg);
    }

    static void WriteLine(int? arg)
    {
        Console.WriteLine("int? == " + arg);
    }

    static void Main(string[] args)
    {
        WriteLine(null); // C# 5.0 이전에는 컴파일 오류 발생
        WriteLine(5); // C# 5.0/6.0 모두 int 인자를 받는 메서드 선택
    }
}