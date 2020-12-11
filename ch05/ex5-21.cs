// 예제 5.21 IDisposable을 상속받는 FileLogger 타입

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        FileLogger log = new FileLogger("sample.log");

        log.Write("Start");
        log.Write("End");

        log.Dispose();
    }
}

class FileLogger : IDisposable
{
    FileStream _fs;

    public FileLogger(string filename)
    {
        _fs = new FileStream(filename, FileMode.Create);
    }

    public void Write(string txt)
    {
        // ... 구현 생략 ...
    }

    public void Dispose()
    {
        _fs.Close();
    }
}