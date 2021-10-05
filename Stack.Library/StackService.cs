using System;

namespace Stack.Library
{
    public class BasicStack
    {
        private object[] _elements;
        private int _currentIndex;
        public BasicStack(int capacity)
        {
            _elements = new object[capacity];
            _currentIndex = -1;
        }

        public void Push(object el)
        {
            if (el == null)
            {
                throw new ArgumentNullException("Null cannot be pushed into the stack.");
            }
            else
            {
                _currentIndex++;
                _elements[_currentIndex] = el;
            }
        }

        public object Pop()
        {
            if (_currentIndex == -1)
            {
                return null;
            }
            else
            {
                var element = _elements[_currentIndex];
                _currentIndex--;
                return element;
            } 
        }
    }
}
