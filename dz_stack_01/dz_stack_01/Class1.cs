using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_stack_01
{
    class MyStack
    {
        private object[] _items;
        public int Count { get; private set; }
        public int Kol
        {
             get
            {
                return _items.Length;
            }
        }
        public MyStack()
        {
            const int defaultkol = 4;
            _items = new object[defaultkol];
        }
        public MyStack(int kol)
        {
            _items = new object[kol];
        }
        public void Push(object item)
        {
            if (_items.Length == Count)
            {
                object[] largerArray = new object[Count * 2];
                Array.Copy(_items, largerArray, Count);
                _items = largerArray;
            }
            _items[Count++] = item;
        }
        public void Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            _items[--Count] = null;
        }
        public object Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            return _items[Count - 1];
        }
    }
}
