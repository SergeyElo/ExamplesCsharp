using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mystack
{
    class SuperStack<T>
    {
        private T[] _items;
        public int Count { get; private set; }
        public int Kol
        {
            get { return _items.Length; }
        }
        public SuperStack()
        {
            const int defkol = 5;
            _items = new T[defkol];
        }
        public SuperStack(int userkol)
        {
            _items = new T[userkol];
        }
        public void Push(T item)
        {
            if (Count == _items.Length)
            {
                T[] _newArray = new T[Count * 2];
                Array.Copy(_items, _newArray, Count);
                _items = _newArray;
            }
            _items[Count++] = item;
        }
        public void Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            _items[--Count] = default;
        }
        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            return _items[Count - 1];
        }
    }

}

