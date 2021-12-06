using System;

namespace prim_kwur
{
    class Program
    {
        static void Main(string[] args)
        {
            Kwur(1, 2, 3);
            Kwur(-5, 2, 1);
            Kwur(1, 2, 1);
        }

        static void Kwur(double a, double b, double c)
        { string rez = "";
            double d = b * b - 4 * a * c;
            if ( d < 0)
            {
                rez = "Нет корней";
            }
            else
            {
                if (d == 0)
                {
                    rez = "Один корень: x=" + string.Format("{0:0.####}", -b / (2 * a));
                }
                else
                {
                    rez = "Два корня: x1= " + string.Format("{0:0.####}", (-b + Math.Sqrt(d)) / (2 * a)) 
                        + "\t  x2 = " + string.Format("{0:0.####}", (-b - Math.Sqrt(d)) / (2 * a));
                }
            }
            Console.WriteLine(rez);
        }
    }
}
