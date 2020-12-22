using System;

class Program
{
    static void Main(string[] args)
    {
        Program pg = new Program();
        var result = pg.ParseInteger("15");

        Console.WriteLine(result.Parsed); // 튜플의 첫 번째 인자를 Parsed로 접근
        Console.WriteLine(result.Number); // 튜플의 두 번째 인자를 Number로 접근
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