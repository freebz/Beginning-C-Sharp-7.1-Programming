// 예제 4.28 delegate 대신 event 예약어를 사용한 예제

using System;

namespace ConsoleApp1
{
    class PrimeCallbackArg : EventArgs // 콜백 값을 담는 클래스 정의
    {
        public int Prime;

        public PrimeCallbackArg(int prime)
        {
            this.Prime = prime;
        }
    }

    // 소수 생성기: 소수가 발생할 때마다 등록된 콜백 메서드를 호출
    class PrimeGenerator
    {
        public event EventHandler PrimeGenerated;

        // 주어진 수까지 루프를 돌면서 소수가 발견되면 콜백 메서드 호출
        public void Run(int limit)
        {
            for (int i = 2; i <= limit; i++)
            {
                if (isPrime(i) == true && PrimeGenerated != null)
                {
                    // 콜백을 발생시킨 측의 인스턴스와 발견된 소수를 콜백 메서드에 전달
                    PrimeGenerated(this, new PrimeCallbackArg(i));
                }
            }
        }

        // 소수 판정 메서드.
        private bool isPrime(int candidate)
        {
            if ((candidate & 1) == 0)
            {
                return candidate == 2;
            }

            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0) return false;
            }

            return candidate != 1;
        }
    }

    class Program
    {
        // 콜백으로 등록될 메서드 1
        static void PrintPrime(object sender, EventArgs args)
        {
            Console.Write((args as PrimeCallbackArg).Prime + ", ");
        }

        static int Sum;

        // 콜백으로 등록될 메서드 2
        static void SumPrime(object sender, EventArgs args)
        {
            Sum += (args as PrimeCallbackArg).Prime;
        }

        static void Main(string[] args)
        {
            PrimeGenerator gen = new PrimeGenerator();

            // PrintPrime 콜백 메서드 추가
            gen.PrimeGenerated += PrintPrime;

            // SumPrime 콜백 메서드 추가
            gen.PrimeGenerated += SumPrime;

            // 1 ~ 10까지 소수를 구하고,
            gen.Run(10);
            Console.WriteLine();
            Console.WriteLine(Sum);

            // SumPrime 콜백 메서드를 제거한 후 다시 1 ~ 15까지 소수를 구하는 메서드 호출
            gen.PrimeGenerated -= SumPrime;
            gen.Run(15);
        }
    }
}