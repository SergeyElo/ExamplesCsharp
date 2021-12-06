using System;

namespace prim_class_01
{
    class Men
    {
        public string name;
        public int age;

        public Men() { name = "Noname"; age = 10; }
        public Men(string s) { name = s; age = 10; }
        public Men(int g) { name = "Noname"; age = g; }
        public Men(string s, int g) { name = s; age = g; }

        public void GetInfo()
        {
            Console.WriteLine($"Name:{name} age:{age}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Men m1 = new (); // до 9 версии С# надо было: new Person()
            Men m2 = new ("Vasya");
            Men m3 = new (22);
            Men m4 = new ("Kosyan", 54);

            m1.GetInfo();
            m2.GetInfo();
            m3.GetInfo();
            m4.GetInfo();
        }
    }
}
