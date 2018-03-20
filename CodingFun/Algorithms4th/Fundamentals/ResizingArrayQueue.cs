using Algorithms4th.CustomException;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms4th.Fundamentals
{
    //Todo: Change to use array
    public class ResizingArrayQueue<TItem> : IEnumerable<TItem>
    {
        private TItem[] array;
        private int _arrLen = 2;
        private int _first = 0;
        private int _last = 0;
        private int _size;

        public ResizingArrayQueue()
        {
            array = new TItem[_arrLen];
            _size = 0;
        }

        public void Enqueue(TItem item)
        {
            if (IsEmtpy())
                array[_last] = item;
            else
            {
                if ((_last + 1) % _arrLen == _first)
                    ExpandArray();
                _last = (_last + 1) % _arrLen;
                array[_last] = item;
            }
            _size++;
        }

        private void ExpandArray()
        {
            var newArr = new TItem[_arrLen * 2];
            int index = _first;
            for(int i=0; i<_arrLen; i++)
            {
                newArr[i] = array[index];
                index = (index + 1) % _arrLen;
            }
            _first = 0;
            _last = _arrLen - 1;
            array = newArr;
            _arrLen = array.Length;
        }

        public TItem Peek()
        {
            if (IsEmtpy())
                throw new NoSuchElementException("Queue is empty.");

            return array[_first];
        }

        public TItem Dequeue()
        {
            if (IsEmtpy())
                throw new NoSuchElementException("Queue is empty.");

            var value = array[_first];
            if(_first != _last)
                _first = (_first + 1) % _arrLen;
            _size--;
            if (_size <= _arrLen / 4)
                ShrinkArray();
            return value;
        }

        private void ShrinkArray()
        {
            var newArr = new TItem[_arrLen / 2];
            int index = _first;
            for(int i = 0; i < _size; i++)
            {
                newArr[i] = array[index];
                index = (index + 1) % _arrLen;
            }
            array = newArr;
            _arrLen = array.Length;
            _first = 0;
            _last = _size - 1;
        }

        public bool IsEmtpy()
        {
            return _size == 0;
        }

        public int Size()
        {
            return _size;
        }

        public IEnumerator<TItem> GetEnumerator()
        {
            int index = _first;
            for(int i = 0; i < _size; i++)
            {
                yield return array[index];
                index = (index + 1) % _arrLen;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        class Node<TNode>
        {
            public TNode Value { get; set; }
            public Node<TNode> Next { get; set; }
        }
    }
}
