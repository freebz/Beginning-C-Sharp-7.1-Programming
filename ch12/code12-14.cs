// 사용자 정의 Task 타입을 async 메서드의 반환 타입으로 사용 가능

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        DoFileRead();
        DoFileRead();
    }

    static void DoFileRead()
    {
        Task<(string, int tid)> result =
              FileReadAsync(@"C:\windows\system32\drivers\etc\HOSTS");
        int tid = Thread.CurrentThread.ManagedThreadId;
        Console.WriteLine($"MainThreadID: {tid}, AsyncThreadID: {result.Result.tid}");
    }

    private static async Task<(string, int)> FileReadAsync(string filePath)
    {
        string fileText = await ReadAllTextAsync(filePath);
        return (fileText, Thread.CurrentThread.ManagedThreadId);
    }

    static Task<string> ReadAllTextAsync(string filePath)
    {
        return Task.Factory.StartNew(() =>
        {
            return File.ReadAllText(filePath);
        });
    }
}