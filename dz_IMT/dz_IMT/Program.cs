using System;

namespace dz_IMT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Family? ");
            string family = Console.ReadLine();
            Console.WriteLine("Name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Age (year)? ");
            double age = double.Parse(Console.ReadLine());
            Console.WriteLine("Weight (kg) ? ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Height (m)? ");
            double height = double.Parse(Console.ReadLine());

            double imt = weight / (height * height);
            string s = "Your profile: \nFull name: " + family + " " + name
                + string.Format("\nAge: {0:0.#}\nWeight: {1:0.#}\nHeight: {2:0.##}\nBody Mass Index: {3:0.####}"
                   , age, weight, height, imt);
            Console.WriteLine(s);
        }
    }
}
