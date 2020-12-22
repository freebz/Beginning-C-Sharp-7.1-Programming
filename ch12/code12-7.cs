using System;

class Program
{
    static void Main(string[] args)
    {
        Program pg = new Program();
        Tuple<bool, int> result = pg.ParseInteger("15");

        Console.WriteLine(result.Item1); // 첫 번째 제네릭 인자를 Item1로 접근
        Console.WriteLine(result.Item2); // 두 번째 제네릭 인자를 Item2로 접근
    }

    Tuple<bool, int> ParseInteger(string text)
    {
        int number = 0;
        bool result = false;

        try
        {
            number = Int32.Parse(text);
            result = true;
        }
        catch { }

        return Tuple.Create(result, number);
    }
}