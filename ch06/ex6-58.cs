// 예제 6.58 별도의 AppDomain에 로드되는 어셈블리

using System;
using System.Reflection;
using System.Runtime.Remoting;

class Program
{
    static void Main(string[] args)
    {
        AppDomain newAppDomain = AppDomain.CreateDomain("MyAppDomain");

        string dllPath = @"ClassLibrary1.dll";
        ObjectHandle objHandle =
                newAppDomain.CreateInstanceFrom(dllPath, "ClassLibrary1.Class1");

        Console.WriteLine("엔터키를 치기 전까지 ClassLibrary1.dll 파일을 지울 수 없습니다.");
        Console.ReadLine();

        AppDomain.Unload(newAppDomain); // AppDomain을 해제시킨다.

        Console.WriteLine("이젠 ClassLibrary1.dll 파일을 지울 수 있습니다.");
        Console.ReadLine();
    }
}