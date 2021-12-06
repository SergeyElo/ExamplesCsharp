using System;

namespace dz_stack_01
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack t = new MyStack();
            t.Push(1);
            t.Push(2);
            Console.WriteLine(t.Peek());
            t.Pop();
            Console.WriteLine(t.Peek());
            Console.WriteLine($"count={t.Kol}");
            t.Push(9);
            t.Push(10);
            t.Push(12);
            t.Push(77);
            Console.WriteLine($"count={t.Kol}");
        }
    }
}
