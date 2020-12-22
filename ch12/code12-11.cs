// Deconstruct 메서드

using System;

class Rectangle
{
    public int X { get; }
    public int Y { get; }
    public int Width { get; }
    public int Height { get; }

    public Rectangle(int x, int y, int width, int height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }

    public void Deconstruct(out int x, out int y)
    {
        x = X;
        y = Y;
    }

    public void Deconstruct(out int x, out int y, out int width, out int height)
    {
        x = X;
        y = Y;
        width = Width;
        height = Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle(5, 6, 20, 25);
        {
            (int x, int y) = rect;
            Console.WriteLine($"x == {x}, y == {y}");   // 출력 결과: x == 5, y == 6
        }

        {
            (int _, int _) = rect; // 의미 없는 구문이지만.

            (int _, int y) = rect;
            Console.WriteLine($"y == {y}"); // 출력 결과: y == 6
        }

        {
            (int x, int y, int width, int height) = rect;
            Console.WriteLine($"x == {x}, y == {y}, width = {width}, height = {height}");
                                // 출력 결과: x == 5, y == 6, width = 20, height = 25

            (int _, int _, int _, int _) = rect; // 의미 없는 구문이지만.

            (int _, int _, int w, int h) = rect;
            Console.WriteLine($"w == {w}, h == {h}");   // 출력 결과: w == 20, h == 25

            (var _, var _, var _, var last) = rect;
            Console.WriteLine($"last == {last}");   // 출력 결과: last == 25
        }
    }
}