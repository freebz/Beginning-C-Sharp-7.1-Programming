// default 리터럴 추가

using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int intValue = default; // int로 대입된다는 것을 알 수 있으므로
        BigInteger bigIntValue = default; // BigInteger로 대입되므로

        Console.WriteLine(intValue);      // 출력 결과: 0
        Console.WriteLine(bigIntValue);   // 출력 결과: 0

        string txt = default; // string 타입의 기본값을 반환
        Console.WriteLine(txt ?? "(null)"); // 출력 결과: (null);


        GenericTest<int> t = new GenericTest<int>();
        Console.WriteLine(t.GetDefaultValue()); // 출력 결과: 0
    }

    class GenericTest<T>
    {
        public T GetDefaultValue()
        {
            return default; // C# 7.0 이전에는 default(T)로 반환
        }
    }
}