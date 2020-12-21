// 예제 8.9 Where 사용 예

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int> { 3, 1, 4, 5, 2 };

        IEnumerable<int> enumList = list.Where((elem) => elem % 2 == 0);
        Array.ForEach(enumList.ToArray(), (elem) => { Console.WriteLine(elem); });
    }
}