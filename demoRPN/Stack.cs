using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoRPN
{
    class Stack<T>:iStack<T>
    {
        private int _max, _top;
        private T[] _stack;
        public int Count { get; private set; }

        public Stack(int n = 0)
        {
            Init(n);
        }

        public void Init(int n)
        {
            _max = n;
            _stack = new T[_max];
            Count = _top = 0;
        }

        public void Push(T elem)
        {
            _stack[_top] = elem;
            if (Count < _max) Count++;
            _top = (_top + 1) % _max;
        }

        public T Pop()
        {
            if (Count == 0) throw new NullReferenceException("Empty List");
            if (_top == 0) _top = _max - 1;
            else
                --_top;
            var elem = _stack[_top];
            Count--;
            return elem;
        }
        public T Peek()
        {
            int a = 0;
            if (Count == 0) throw new NullReferenceException("Empty List");
            if (_top == 0) _top = _max - 1;
            else
                a = _top - 1;
            var elem = _stack[a];
            return elem;
        }
    }
}
