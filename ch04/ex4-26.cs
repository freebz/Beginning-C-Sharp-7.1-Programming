// 예제 4.26 enum 타입의 사용

using System;
enum Days
{
    Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
}

class Program
{
    static void Main(string[] args)
    {
        Days today = Days.Sunday;
        Console.WriteLine(today); // 출력 결과: Sunday
    }
}