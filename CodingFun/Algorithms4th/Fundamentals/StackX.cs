using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms4th.CustomException;

namespace Algorithms4th.Fundamentals
{
    public class StackX<TItem> : IEnumerable<TItem>
    {
        private Node<TItem> _top;
        private int _size;

        public StackX()
        {
            _top = null;
            _size = 0;
        }

        public void Push(TItem item)
        {
            var newNode = new Node<TItem> { Value = item };

            if (_top == null)
                _top = newNode;
            else
            {
                newNode.Next = _top;
                _top = newNode;
            }

            _size++;
        }

        public TItem Pop()
        {
            if (IsEmpty())
                throw new NoSuchElementException("Stack is empty.");

            Node<TItem> top = _top;
            var item = _top.Value;        
            _top = _top.Next;
            top = null;
            _size--;
            return item;
        }

        public TItem Peek()
        {
            if (IsEmpty())
                throw new NoSuchElementException("Stack is empty.");

            return _top.Value;
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
            return new StackEnumerator<TItem>(_top);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        class StackEnumerator<T> : IEnumerator<T>
        {
            private Node<T> _first;
            private Node<T> _current;
            public T Current => _current.Value;

            object IEnumerator.Current => _current.Value;

            public StackEnumerator(Node<T> top)
            {
                _first = new Node<T>();
                _first.Next = top;
                _current = _first;
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
