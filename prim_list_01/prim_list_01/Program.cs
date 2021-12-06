using System;
using System.Collections.Generic;

namespace prim_list_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 45 };
            numbers.Add(6); // добавление элемента
            numbers.AddRange(new int[] { 7, 8, 9 });
            numbers.Insert(0, 666); // вставляем на первое место в списке число 666
            numbers.RemoveAt(1); //  удаляем второй элемент
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            numbers.Sort();
            Console.WriteLine("sort list:");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

        }
    }
}
