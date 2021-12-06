using System;
using System.IO;
using System.Collections;

namespace prim_read_ArrayList_from_file
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ArrayList a = new ArrayList();
            using (var sr = new StreamReader("test1.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();                  
                    a.Add(line);
                }
            }
            Console.WriteLine($"Прочитано из файла строк: {a.Count - 1}");
            foreach (object x in a)
            {
                Console.WriteLine($"{x}", x);
            }
        }
    }
}
