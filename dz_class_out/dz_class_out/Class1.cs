using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_class_out
{
    class Triangle
    {
        public static bool Geron(double a, double b, double c, out double rez)
        {
            rez = 0;
            if ((a + b < c) || (a + c < b) || (b + c < a))
            {
                return false;
            }
            double p = (a + b + c) / 2;
            rez = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return true;
        }
    }
}
