using System;
using System.Collections.Generic;

namespace prim_dictionary_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> countries = new Dictionary<int, string>(5);
            countries.Add(1, "Россия");
            countries.Add(3, "Египет");
            countries.Add(2, "Франция");
            countries.Add(4, "Бельгия");
            Console.WriteLine("first dictionary:");
            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            string country = countries[3]; // получение элемента по ключу
            countries[4] = "Италия"; // изменение объекта
            countries.Remove(2);// удаление по ключу
            Console.WriteLine("second dictionary:");
            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

        }
    }
}
