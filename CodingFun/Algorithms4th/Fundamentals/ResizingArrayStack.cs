using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms4th.CustomException;

namespace Algorithms4th.Fundamentals
{
    //Todo: change to use array
    public class ResizingArrayStack<TItem> : IEnumerable<TItem>
    {
        private int _top;
        private int _size;
        private TItem[] _array;
        private int _arrLen;

        public ResizingArrayStack()
        {
            _top = _size = 0;
            _arrLen = 2;
            _array = new TItem[_arrLen];
        }

        public void Push(TItem item)
        {
            if (IsEmpty())
                _array[_top] = item;
            else
            {
                if (_size == _arrLen)
                    Resize(_arrLen * 2);
                _top++;
                if (_top >= _arrLen)
                    _top = 0;
                _array[_top] = item;
            }
            _size++;
        }

        private void Resize(int size)
        {
            var newArray = new TItem[size];
            for(int i=_size-1; i>=0; i--)
            {
                newArray[i] = _array[_top--];
                if (_top < 0)
                    _top = _arrLen - 1;
            }
            _top = _size-1;
            _arrLen = size;
            _array = newArray;
        }

        public TItem Pop()
        {
            if (IsEmpty())
                throw new NoSuchElementException("Stack is empty.");

            var value = _array[_top--];
            _size--;
            if (_top < 0)
                _top = _arrLen - 1;
            if(_size >= 2 && _size <= _arrLen / 4)
                Resize(_arrLen / 2);
            return value;
        }

        public TItem Peek()
        {
            if (IsEmpty())
                throw new NoSuchElementException("Stack is empty.");

            return _array[_top];
        }

        public int Size()
        {
            return _size;
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public IEnumerator<TItem> GetEnumerator()
        {
            for(var i=0; i<_size; i++)
            {
                yield return _array[_top--];
                _top = _top < 0 ? _arrLen-1 : _top;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
