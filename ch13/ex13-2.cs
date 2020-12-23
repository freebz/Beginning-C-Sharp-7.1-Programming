using System;
using System.Net;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        MainAsync().GetAwaiter().GetResult();
    }

    private static async Task MainAsync()
    {
        WebClient wc = new WebClient();
        string text = await wc.DownloadStringTaskAsync("http://www.microsoft.com");
        Console.WriteLine(text);       
    }
}