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
        private Node<TItem> _first;
        private Node<TItem> _last;
        private int _size;

        public ResizingArrayQueue()
        {
            _first = _last = null;
            _size = 0;
        }

        public void Enqueue(TItem item)
        {
            var newNode = new Node<TItem> { Value = item, Next = null };
            if (_first == null)
                _first = _last = newNode;
            else
            {
                _last.Next = newNode;
                _last = newNode;
            }
            _size++;
        }

        public TItem Peek()
        {
            if (IsEmtpy())
                throw new NoSuchElementException();

            return _first.Value;
        }

        public TItem Dequeue()
        {
            if (IsEmtpy())
                throw new NoSuchElementException();

            var deNode = _first;
            var deValue = _first.Value;
            _first = _first.Next;
            deNode = null;
            _size--;
            return deValue;
        }

        public bool IsEmtpy()
        {
            return _first == null;
        }

        public int Size()
        {
            return _size;
        }

        public IEnumerator<TItem> GetEnumerator()
        {
            return new ResizingArrayQueueEnumerator<TItem>(_first);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        class ResizingArrayQueueEnumerator<T> : IEnumerator<T>
        {
            private Node<T> _first;
            private Node<T> _current;

            public T Current => _current.Value;

            object IEnumerator.Current => _current.Value;

            public ResizingArrayQueueEnumerator(Node<T> headInQueue)
            {
                _current = new Node<T>();
                _current.Next = headInQueue;
                _first = _current;
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                if (_current.Next == null)
                    return false;

                _current = _current.Next;
                return true;
            }

            public void Reset()
            {
                _current = _first;
            }
        }

        class Node<TNode>
        {
            public TNode Value { get; set; }
            public Node<TNode> Next { get; set; }
        }
    }
}
