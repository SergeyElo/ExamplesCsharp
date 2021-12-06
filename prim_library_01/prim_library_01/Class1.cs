using System;

namespace prim_library_01
{
    public class MyClass
    {
        public long Fakt(int n)
        {
            long p = 1;
            for (int i = 1; i <= n; i++)
            {
                p *= i;
            }
            return p;

        }
    }
}
