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
        ValueTask<(string, int tid)> result =
            FileReadAsync(@"C:\windows\system32\drivers\etc\HOSTS");
        
        int tid = Thread.CurrentThread.ManagedThreadId;
        Console.WriteLine($"MainThreadID: {tid}, AsyncThreadID: {result.Result.tid}");
    }

    static string _fileContents = string.Empty;

    private static async ValueTask<(string, int)> FileReadAsync(string filePath)
    {
        if (string.IsNullOrEmpty(_fileContents) == false)
        {
            return (_fileContents, Thread.CurrentThread.ManagedThreadId);    
        }

        _fileContents = await ReadAllTextAsync(filePath);
        return (_fileContents, Thread.CurrentThread.ManagedThreadId);
    }

    static Task<string> ReadAllTextAsync(string filePath)
    {
        return Task.Factory.StartNew(() =>
        {
            return File.ReadAllText(filePath);
        });
    }
}