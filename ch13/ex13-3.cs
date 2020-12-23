using System;
using System.Net;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        WebClient wc = new WebClient();
        string text = await wc.DownloadStringTaskAsync("http://www.microsoft.com");
        Console.WriteLine(text);       
    }
}