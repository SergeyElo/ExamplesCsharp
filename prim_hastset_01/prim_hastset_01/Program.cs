using System;
using System.Collections.Generic;

namespace prim_hastset_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создадим два множества
            SortedSet<char> ss = new SortedSet<char>();
            SortedSet<char> ss1 = new SortedSet<char>();

            ss.Add('A');
            ss.Add('B');
            ss.Add('C');
            ss.Add('Z');
            ShowColl(ss, "Первая коллекция: ");

            ss1.Add('X');
            ss1.Add('Y');
            ss1.Add('Z');
            ShowColl(ss1, "Вторая коллекция");

           // ss.SymmetricExceptWith(ss1);
           // ShowColl(ss, "Исключили разноименность (одинаковые элементы) двух множеств: ");

            ss.UnionWith(ss1);
            ShowColl(ss, "Объединение множеств: ");

            ss.ExceptWith(ss1);
            ShowColl(ss, "Вычитание множеств");

            Console.ReadLine();
        }

        static void ShowColl(SortedSet<char> ss, string s)
        {
            Console.WriteLine(s);
            foreach (char ch in ss)
                Console.Write(ch + " ");
            Console.WriteLine("\n");
        }
    }
}
