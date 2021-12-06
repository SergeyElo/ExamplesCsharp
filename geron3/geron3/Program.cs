using System;

namespace geron3
{
    class Program
    {        
        static void Main(string[] args)
        {
            double a = Input("Введите сторону a:");
            double b = Input("Введите сторону b:");
            double c = Input("Введите сторону c:");
            Geron(a, b, c);
        }
        static double Input(string s)
        {
            double x;       
            Console.WriteLine(s);
            x = double.Parse(Console.ReadLine());
            return x;
        }
        static void Geron(double sa, double sb, double sc)
        {
            double p = (sa + sb + sc) / 2;
            double s = Math.Sqrt(p * (p - sa) * (p - sb) * (p - sc));
            Console.WriteLine($"Площадь треугольника={s:0.##}");
        }
    }
}
