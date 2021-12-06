using System;

namespace prim_math_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга");
            double radius = Double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Площадь круга с радиусом {0:##.##} равна {1:####.##}", radius, area);
        }
    }
}
