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
            _currentIndex = 0;
        }

        public void Push(object el)
        {
            _elements[_currentIndex] = el;
            _currentIndex++;
        }

        public object Pop()
        {
            var element = _elements[_currentIndex - 1];
            _currentIndex--;
            return element; 
        }
    }
}
