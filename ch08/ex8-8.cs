// 예제 8.8 짝수로 구성된 List<T>를 반환하는 코드

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int> { 3, 1, 4, 5, 2 };

        foreach (var item in list)
        {
            Console.WriteLine(item + " * 2 == " + (item * 2));
        }


        list.ForEach((elem) => { Console.WriteLine(elem + " * 2 == " + (elem * 2)); });

        // 또는 Array.ForEach로 나타낼 수도 있고
        Array.ForEach(list.ToArray(),
            (elem) => { Console.WriteLine(elem + " * 2 == " + (elem * 2)); });

        // 또는 람다 식이 아닌 익명 메서드로도 나타낼 수 있음
        list.ForEach( delegate(int elem)
                            { Console.WriteLine(elem + " * 2 == " + (elem * 2)); });



        List<int> evenList  = new List<int>();
        foreach (var item in list)
        {
            if (item % 2 == 0) // 짝수인지 판정해서 evenList에 추가한다.
            {
                evenList.Add(item);
            }
        }

        foreach (var item in evenList)
        {
            Console.Write(item + ", "); // 출력 결과: 4, 2,
        }
        Console.WriteLine();


        List<int> evenList2 = list.FindAll((elem) => elem % 2 == 0);
        evenList2.ForEach((elem) => { Console.Write(elem + ", "); }); // 출력 결과: 4, 2,
        Console.WriteLine();

        int count = 0;
        foreach (var item in list)
        {
            if (item > 3)
            {
                count++;
            }
        }

        Console.WriteLine("3보다 큰 수는 " + count + "개 있음.");


        int count2 = list.Count((elem) => elem > 3);
        Console.WriteLine("3보다 큰 수는 " + count2 + "개 있음.");
    }
}