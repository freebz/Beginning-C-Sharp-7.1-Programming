// 예제 6.9 StreamWriter 사용 예

using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        MemoryStream ms = new MemoryStream();

        StreamWriter sw = new StreamWriter(ms, Encoding.UTF8);
        sw.WriteLine("Hello World");
        sw.WriteLine("Anderson");
        sw.Write(32000);
        sw.Flush();

        ms.Position = 0; // Position을 돌려 놓는 것을 잊으면 안 된다.

        StreamReader streamReader= new StreamReader(ms, Encoding.UTF8);
        string txt = streamReader.ReadToEnd();
        Console.WriteLine(txt);
    }
}