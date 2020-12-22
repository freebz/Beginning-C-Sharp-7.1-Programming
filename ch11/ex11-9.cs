// delegate를 인자로 받는 중복 정의 메서드 선택 정확도 향상

using System;
using System.Threading.Tasks;

class Program
{
    static Task NullTask()
    {
        Console.WriteLine("NullTask");
        return null;
    }

    static void Main()
    {
        Task.Run(NullTask); // C# 5.0 이전에는 컴파일 오류
        Console.ReadLine();
    }
}