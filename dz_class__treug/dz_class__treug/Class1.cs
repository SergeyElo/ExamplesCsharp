using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_class__treug
{
    class Triangle
    {
        public double Square(double a, double b, double c)
        {   double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public double Square(double a, double h)
        {
            return a * h / 2;
        }
        public double Square(double ab, double ac, int alpha)
        {
            return ab * ac * Math.Sin(alpha * Math.PI / 180) / 2;
        }
    }
}
