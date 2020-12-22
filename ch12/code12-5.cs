// 튜플

using System;

public class IntResult
{
    public bool Parsed { get; set; }
    public int Number { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Program pg = new Program();
        IntResult result = pg.ParseInteger("15");

        Console.WriteLine(result.Parsed); // True
        Console.WriteLine(result.Number); // 15
    }

    IntResult ParseInteger(string text)
    {
        IntResult result = new IntResult();

        try
        {
            result.Number = Int32.Parse(text);
            result.Parsed = true;
        }
        catch
        {
            result.Parsed = false;
        }

        return result;
    }
}