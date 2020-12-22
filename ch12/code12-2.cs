// 반환값 및 로컬 변수에 ref 기능 추가(ref returns and locals)

using System;

class Program
{
    static void Main(string[] args)
    {
        CallVal();
        CallRef();
    }

    private static void CallVal()
    {
        int a = 5;
        int b = a;

        a = 6;

        Console.WriteLine(a); // 6
        Console.WriteLine(b); // 5
    }

    private static void CallRef()
    {
        int a = 5;
        ref int b = ref a;

        a = 6;

        Console.WriteLine(a); // 6
        Console.WriteLine(b); // 6
    }
}