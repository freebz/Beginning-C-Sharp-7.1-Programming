// 예제 9.3 dynamic 사용 예

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic d = 5;

            int sum = d + 10;
            Console.WriteLine(sum);
        }
    }
}