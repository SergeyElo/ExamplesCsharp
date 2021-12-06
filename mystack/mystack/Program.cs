using System;

namespace mystack
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SuperStack<string> t = new SuperStack<string>();
            t.Push("first");
            t.Push("second");
            Console.WriteLine(t.Peek());
            t.Pop();
            Console.WriteLine(t.Peek());

        }
    }
}
