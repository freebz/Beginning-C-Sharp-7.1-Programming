// 예제 10.3 동기식 코드

using System;
using System.Net;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sync();
            Console.ReadLine();
            Async();
            Console.ReadLine();
            AwaitDownloadString();
            Console.ReadLine();
        }

        static void Sync() {
            WebClient wc = new WebClient();
            string text = wc.DownloadString("http://www.microsoft.com");
            Console.WriteLine(text);
        }

        static void Async() {
            WebClient wc = new WebClient();

            // DownloadStringAsync 동작이 완료됐을 때 호출할 이벤트 등록
            wc.DownloadStringCompleted += wc_DownloadStringCompleted;

            // DownloadString의 비동기 메서드
            wc.DownloadStringAsync(new Uri("http://www.microsoft.com"));
        }
        static void wc_DownloadStringCompleted(object sender,
                                               DownloadStringCompletedEventArgs e)
        {
            Console.WriteLine(e.Result); // e.Result == HTML 텍스트
        }

        private static async void AwaitDownloadString()
        {
            WebClient wc = new WebClient();
            string text = await wc.DownloadStringTaskAsync("http://www.microsoft.com");
            Console.WriteLine(text);
        }
    }
}