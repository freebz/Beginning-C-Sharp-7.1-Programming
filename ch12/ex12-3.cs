using System;
using System.Net;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // 기존에는 아래와 같은 조건은 if 문을 통해서만 가능했지만
        // 이젠 switch/case로도 처리할 수 있다.
        {
            string text = "......";

            switch (text)
            {
                case var item when (ContainsAt(item, "http://www.naver.com")):
                    Console.WriteLine("In Naver");
                    break;

                case var item when (ContainsAt(item, "http://www.daum.net")):
                    Console.WriteLine("In Daum");
                    break;

                default:
                    Console.WriteLine("None");
                    break;
            }
        }
    }

    private static bool ContainsAt(string item, string url)
    {
        WebClient wc = new WebClient();
        wc.Encoding = Encoding.UTF8;
        string text = wc.DownloadString(url);

        return text.IndexOf(item) != -1;
    }
}