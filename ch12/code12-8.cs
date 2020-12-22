using System;

class Program
{
    static void Main(string[] args)
    {
        Program pg = new Program();
        (bool, int) result = pg.ParseInteger("15");

        Console.WriteLine(result.Item1); // 튜플의 첫 번째 인자를 Item1로 접근
        Console.WriteLine(result.Item2); // 튜플의 두 번째 인자를 Item2로 접근
    }

    (bool, int) ParseInteger(string text)
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