using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms4th.Fundamentals
{
    //Todo: Update code to use resizing array
    public class ResizingArrayBag<Item> : IEnumerable<Item>
    {
        class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }
        }

        private Node<Item> _firstNode;
        private int _size;

        public ResizingArrayBag()
        {
            _firstNode = null;
            _size = 0;
        }

        public void Add(Item item)
        {
            var newNode = new Node<Item> { Value = item };
            newNode.Value = item;
            newNode.Next = _firstNode;
            _firstNode = newNode;
            _size++;
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public int Size()
        {
            return _size;
        }

        public IEnumerator<Item> GetEnumerator()
        {
            return new ResizingArrayBagEnumerator<Item>(_firstNode);
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        class ResizingArrayBagEnumerator<TItem> : IEnumerator<TItem>
        {
            private Node<TItem> _firstNode = new Node<TItem>();
            private Node<TItem> _currentNode;
            public ResizingArrayBagEnumerator(Node<TItem> item)
            {
                _firstNode.Next = item;
                _currentNode = _firstNode;
            }
            public TItem Current => _currentNode.Value;

            object IEnumerator.Current => _currentNode.Value;

            public void Dispose() { }

            public bool MoveNext()
            {
                if (_currentNode.Next == null)
                    return false;

                _currentNode = _currentNode.Next;
                return true;
            }

            public void Reset()
            {
                _currentNode = _firstNode;
            }
        }
    }
}
