using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        object[] objList = new object[] { 100, null, DateTime.Now, new ArrayList() };

        foreach (object item in objList)
        {
            switch (item)
            {
                case 100: // 상수 패턴
                    Console.WriteLine(item);
                    break;

                case null: // 상수 패턴
                    Console.WriteLine("null");
                    break;

                case DateTime dt: // 타입 패턴 (값 형식) - 필요 없다면 dt 변수 생략 가능
                    Console.WriteLine(dt);
                    break;

                case ArrayList arr: // 타입 패턴 (참조 형식) - 필요 없다면 arr 변수 생략 가능
                    Console.WriteLine(arr.Count);
                    break;

                case var elem: // Var 패턴 (이렇게 사용하면 default와 동일)
                    Console.WriteLine(elem);
                    break;
            }
        }
    }
}