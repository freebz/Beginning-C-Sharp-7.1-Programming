// 예제 12.1 is 연산자를 이용한 상수 패턴과 타입 패턴 사례

using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        object[] objList = new object[] { 100, null, DateTime.Now, new ArrayList() };

        foreach (object item in objList)
        {
            if (item is 100) // 상수 패턴
            {
                Console.WriteLine(item);
            } else if (item is null) // 상수 패턴
            {
                Console.WriteLine("null");
            } else if (item is DateTime dt) // 타입 패턴(값 형식) - 필요 없다면 dt 변수 생략 가능
            {
                Console.WriteLine(dt);
            } else if (item is ArrayList arr) // 타입 패턴(참조 형식) - 필요 없다면 arr 변수 생략 가능
            {
                Console.WriteLine(arr.Count);
            } else if (item is var elem) // 타입 패턴과는 달리 변수명을 생략할 수 없다.
            {
                Console.WriteLine(elem);
            }
        }
    }
}