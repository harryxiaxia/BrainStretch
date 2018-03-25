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
        private int _size;
        private int _arrLength;

        public MaxPQ()
        {
            //Default size it 2;
            _arrLength = 2;
            _array = new T[_arrLength];
        }

        public MaxPQ(int max) { }

        public MaxPQ(T[] a) { }

        public void Insert(T item)
        {
            if (_size == _arrLength)
                Resize(_arrLength * 2);

            _array[_size++] = item;
            Swap(_array, 0, _size - 1);
            Swim(_size-1);
        }

        public T Max()
        {
            if (_size == 0)
                throw new NoSuchElementException("PQ is empty");
            return _array[0];
        }

        public T DelMax()
        {
            if (_size == 0)
                throw new NoSuchElementException("PQ is empty");
            T item = _array[0];
            Swap(_array, 0, _size - 1);
            _size--;
            Sink(0);
            return item;
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public int Size()
        {
            return _size;
        }

        private void Resize(int Length)
        {
            var newArray = new T[Length];
            for(int i=0; i<_size; i++)            
                newArray[i] = _array[i];            
            _array = newArray;
            _size = Length;
        }

        private void Swim(int index)
        {
            while(index > 0)
            {
                if (Less(_array[index / 2], _array[index]))
                    Swap(_array, index / 2, index);
                index /= index;
            }
        }

        private void Sink(int index)
        {
            while(index <= _size-1)
            {
                int lc = index * 2;
                int rc = index * 2 + 1;
                if (lc > _size - 1)
                    break;

                if(rc > _size - 1)
                {
                    if (Less(_array[index], _array[lc]))
                        Swap(_array, index, lc);
                }
                else
                {
                    if (Less(_array[lc], _array[rc]) && Less(_array[index], _array[rc]))
                        Swap(_array, index, rc);

                    if (Less(_array[rc], _array[lc]) && Less(_array[index], _array[lc]))
                        Swap(_array, index, lc);
                }
            }
        }
    }
}
