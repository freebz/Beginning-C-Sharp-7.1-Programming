// 예제 5.6 appSettings의 값을 읽는 코드

using System;
using System.Configuration;

class Program
{
    static void Main(string[] args)
    {
        string txt = ConfigurationSettings.AppSettings["AdminEmailAddress"];
        Console.WriteLine(txt);     // 출력 결과: admin@sysnet.pe.kr

        txt = ConfigurationException.AppSettings["Delay"];
        int delay = int.Parse(txt);
        Console.WriteLine(delay);   // 출력 결과: 5000
    }
}