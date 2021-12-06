using System;

namespace mas01
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Input kol in massiv:");
            int kolmas = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[kolmas];
            for (int i = 0; i < kolmas; i++)
            {
                Console.Write("{0}-е число: ", i + 1);
                a[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < kolmas - 1; i++)
            {
                for (int j = i + 1; j < kolmas; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }                
            }
            Console.WriteLine("Sort massiv:");
            for (int i = 0; i < kolmas; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
