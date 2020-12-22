using System;
using System.Net;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Action<(int, int)> detectZeroOR = (args) =>
        {
            switch (args)
            {
                case var r when r.Equals((0, 0)):
                case var r1 when r1.Item1 == 0:
                case var r2 when r2.Item2 == 0:
                    Console.WriteLine("Zero found.");
                    return;
            }

            Console.WriteLine("Both nonzero.");
        };

        detectZeroOR((0, 0));
        detectZeroOR((1, 0));       
        detectZeroOR((0, 10));
        detectZeroOR((10, 15));
    }
}