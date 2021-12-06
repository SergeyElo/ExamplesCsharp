using System;

namespace geron4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=0, b=0, c=0;
            Vvod(ref a, ref b, ref c);
            Vyvod(a, b, c);
        }
        static void Vvod(ref double a, ref double b, ref double c)
        {
            do
            {
                Console.WriteLine("a=");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("b=");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("c=");
                c = double.Parse(Console.ReadLine());
            }
            while ((a + b < c) | (a + c < b) | (b + c < a));
        }
        static void Vyvod(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"area={s:####.##}");
        }
    }
}
