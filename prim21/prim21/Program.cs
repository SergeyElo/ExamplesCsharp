using System;
using System.Collections.Generic;

namespace prim21
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> spisok1 = new Queue<string>();
            spisok1.Enqueue("Петров");
            spisok1.Enqueue("Иванова");
            spisok1.Enqueue("Кулик");
            spisok1.Enqueue("Листова");
            spisok1.Enqueue("Николаевичев");
            Console.WriteLine("Очередь: ");
            foreach (string s in spisok1)
            {
                Console.WriteLine(s);
            }
            Stack<string> spisok2 = new Stack<string>();
            spisok2.Push("пассажир1");
            spisok2.Push("пассажир2");
            spisok2.Push("пассажир3");
            Console.WriteLine("Стек: ");
            foreach (string s in spisok2)
            {
                Console.WriteLine(s);
            }
            Dictionary<int, string> slov = new Dictionary<int, string>();
            slov.Add(1, "сом");
            slov.Add(3, "окунь");
            slov.Add(2, "карась");
            slov.Add(8, "щука");
            Console.WriteLine("Словарь:");
            foreach (KeyValuePair<int, string> dic in slov)
            {
                Console.WriteLine(dic.Key + "-" + dic.Value);
            }

        }
    }
}
