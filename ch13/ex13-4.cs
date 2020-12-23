using System;
using System.Net;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args) => Console.WriteLine(await new WebClient().DownloadStringTaskAsync("http://www.microsoft.com"));
}