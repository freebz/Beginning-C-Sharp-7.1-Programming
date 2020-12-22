using System;

class Program
{
    static void Main(string[] args)
    {
        Program pg = new Program();
        (bool success, int n) result = pg.ParseInteger("15");

        Console.WriteLine(result.success); // 튜플의 첫 번째 인자에 success로 접근
        Console.WriteLine(result.n); // 튜플의 두 번째 인자에 n으로 접근


        (var success, var number) = pg.ParseInteger("50");
        Console.WriteLine(success); // 튜플의 첫 번째 인자의 값을 담은 success 변수
        Console.WriteLine(number); // 튜플의 두 번째 인자의 값을 담은 number 변수


        (var _, var _) = pg.ParseInteger("70"); // 2개의 값을 모두 생략

        (var _, var n) = pg.ParseInteger("70"); // 마지막 값만 n으로 받음
        Console.WriteLine(n);
    }

    (bool Parsed, int Number) ParseInteger(string text)
    {
        int number = 0;
        bool result = false;

        try
        {
            number = Int32.Parse(text);
            result = true;
        }
        catch { }

        return (result, number);
    }
}