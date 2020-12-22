using System;

class Program
{
    static void Main(string[] args)
    {
        MyMatrix matrix = new MyMatrix();
        matrix.Put(0, 0) = 1;

        int result = matrix.Put(1, 1) = 1;
        Console.WriteLine(result); // 출력 결과: 1
    }
}

class MyMatrix
{
    int[,] _matrix = new int[100, 100];

    public ref int Put(int column, int row)
    {
        return ref _matrix[column, row];
    }
}