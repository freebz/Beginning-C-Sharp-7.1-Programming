// Main 메서드에 async 예약어 허용

using System;
using System.Net;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        MainAsync(); // 별도의 async 메서드를 만들어 호출
    }

    private static async Task MainAsync()
    {
        WebClient wc = new WebClient();
        string text = await wc.DownloadStringTaskAsync("http://www.microsoft.com");
        Console.WriteLine(text);       
    }
}