using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms4th.Fundamentals
{
    /// <summary>
    /// Bags. A bag is a collection where removing items is not supported—its purpose is to provide clients with the ability to collect items and then to iterate through the collected items.
    /// </summary>
    /// <typeparam name="Item">The type of added item</typeparam>
    public class Bag<Item> : IEnumerable<Item>
    {
        class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }
        }

        private Node<Item> _firstNode;
        private int _size;

        public Bag()
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
            return new BagEnumerator<Item>(_firstNode);
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        class BagEnumerator<TItem> : IEnumerator<TItem>
        {
            private Node<TItem> _firstNode = new Node<TItem>();
            private Node<TItem> _currentNode;
            public BagEnumerator(Node<TItem> item)
            {
                _firstNode.Next = item;
                _currentNode = _firstNode;
            }
            public TItem Current => _currentNode.Value;

            object IEnumerator.Current => _currentNode.Value;

            public void Dispose() {}

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
