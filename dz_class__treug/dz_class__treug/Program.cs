using System;

namespace dz_class__treug
{
    class Program
    {
        static void Main(string[] args)
        { Triangle x = new Triangle();
            Console.WriteLine($"s1={x.Square(a: 2, b: 3, c: 4.0):0.####}");
            Console.WriteLine($"s2={x.Square(a: 2, h: 3):0.####}");
            Console.WriteLine($"s3={x.Square(ab: 2, ac: 3, alpha: 90):0.####}");
        }
    }
}
