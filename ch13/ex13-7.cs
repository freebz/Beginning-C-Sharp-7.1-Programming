// 패턴 매칭 - 제네릭 추가

using System;

class Program
{
    static void Main(string[] args)
    {
        WriteLog(DateTime.Now);
        WriteLog(DateTime.UtcNow);
    }

    // 제네릭 인자의 객체는 is 연산자와 switch/case 패턴 매칭 구문에서 허용되지 않으므로
    // 컴파일 오류 발생(C# 7.0)
    public static void WriteLog<T>(T item)
    {
        if (item is DateTime time)
        {
            Console.WriteLine(time.ToString());
        }

        switch (item)
        {
            case DateTime dt when dt.Kind == DateTimeKind.Utc:
                Console.WriteLine(dt.ToLocalTime());
                break;

            case DateTime dt when dt.Kind == DateTimeKind.Unspecified:
                Console.WriteLine("Invalid DateTime Kind");
                break;

            case DateTime dt:
                Console.WriteLine(dt);
                break;
        }
    }
}