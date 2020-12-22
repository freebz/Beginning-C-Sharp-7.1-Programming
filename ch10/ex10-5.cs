// 예제 10.5 ReadAllText 메서드를 비동기로 처리

using System;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public delegate string ReadAllTextDelegate(string path);

        static void Main(string[] args)
        {
            string filePath = @"C:\windows\system32\drivers\etc\HOSTS";

            SyncFileRead(filePath);
            Console.ReadLine(); // 비동기 스레드가 완료될 때까지 대기하는 용도

            AwaitFileRead(filePath);
            Console.ReadLine();
        }

        static void SyncFileRead(string filePath)
        {
            // 델리게이트를 이용한 비동기 처리
            ReadAllTextDelegate func = File.ReadAllText;
            func.BeginInvoke(filePath, actionCompleted, func);
        }

        static void actionCompleted(IAsyncResult ar)
        {
            ReadAllTextDelegate func = ar.AsyncState as ReadAllTextDelegate;
            string fileText = func.EndInvoke(ar);

            // 파일의 내용을 화면에 출력
            Console.WriteLine(fileText);
        }

        static Task<string> ReadAllTextAsync(string filePath)
        {
            return Task.Factory.StartNew(() =>
            {
                return File.ReadAllText(filePath);
            });
        }

        private static async Task AwaitFileRead(string filePath)
        {
            string fileText = await ReadAllTextAsync(filePath);
            Console.WriteLine(fileText);

            // Task 반환 타입을 갖는 메서드이지만 async 예약어가 지정됐으므로
            // C# 컴파일러가 적절하게 코드를 자동으로 변환해 주기 때문에 return 문이 필요 없다.
        }
    }
}