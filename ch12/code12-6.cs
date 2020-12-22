using System;

class Program
{
    static void Main(string[] args)
    {
        Program pg = new Program();
        dynamic result = pg.ParseInteger("15");

        Console.WriteLine(result.Parsed); // True
        Console.WriteLine(result.Number); // 15
    }

    dynamic ParseInteger(string text)
    {
        int number = 0;

        try
        {
            number = Int32.Parse(text);
            return new { Number = number, Parsed = true };
        }
        catch
        {
            return new { Number = number, Parsed = false };
        }
    }
}