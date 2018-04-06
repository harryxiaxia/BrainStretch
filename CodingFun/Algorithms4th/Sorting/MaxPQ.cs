using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms4th.CustomException;

namespace Algorithms4th.Sorting
{
    public class MaxPQ<T> : ItemComparable<T> where T : IComparable
    {
        private T[] _array;
        private int _lastIndex;
        private int _arrLength;

        public MaxPQ()
        {
            //Default size it 2;
            _lastIndex = 0;
            _arrLength = 2;
            _array = new T[_arrLength];
        }

        public MaxPQ(int max) { }

        public MaxPQ(T[] a) { }

        public void Insert(T item)
        {
            if (_lastIndex == _arrLength-1)
                Resize(_arrLength * 2);

            _array[++_lastIndex] = item;
            Swim(_lastIndex);
        }

        public T Max()
        {
            if (_lastIndex == 0)
                throw new NoSuchElementException("PQ is empty");
            return _array[0];
        }

        public T DelMax()
        {
            if (_lastIndex == 0)
                throw new NoSuchElementException("PQ is empty");
            T item = _array[1];
            Swap(_array, 1, _lastIndex);
            _array[_lastIndex] = default(T);
            _lastIndex--;
            Sink(1);
            return item;
        }

        public bool IsEmpty()
        {
            return _lastIndex == 0;
        }

        public int Size()
        {
            return _lastIndex;
        }

        private void Resize(int Length)
        {
            var newArray = new T[Length];
            for(int i=0; i<_lastIndex; i++)            
                newArray[i] = _array[i];            
            _array = newArray;
            _lastIndex = Length;
        }

        private void Swim(int k)
        {
            while(k > 1 && Less(_array[k/2], _array[k]))
            {
                Swap(_array, k / 2, k);
                k /= 2;
            }
        }

        private void Sink(int k)
        {
            while(2*k <= _lastIndex)
            {
                int j = 2 * k;
                if (j < _lastIndex && Less(_array[j], _array[j + 1])) j++;
                if (Less(_array[j], _array[k])) break;
                Swap(_array, j, k);
                k = j;
            }
        }

        private bool IsMaxHeap()
        {
            return IsMaxHeap(1);
        }

        private bool IsMaxHeap(int index)
        {
            if (index > _lastIndex) return true;
            var left = 2 * index;
            var right = 2 * index + 1;

            if (left <= _lastIndex && Less(_array[index], _array[left])) return false;
            if (right <= _lastIndex && Less(_array[index], _array[right])) return true;

            return IsMaxHeap(2 * index) && IsMaxHeap(2 * index + 1);
        }
    }
}
