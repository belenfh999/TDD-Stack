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
            _currentIndex++;
            _elements[_currentIndex] = el;
        }

        public object Pop()
        {
            if (_currentIndex == -1)
            {
                return null;
            }
            var element = _elements[_currentIndex];
            _currentIndex--;
            return element; 
        }
    }
}
