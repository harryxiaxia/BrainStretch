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
    public class ResizingArrayQueue<TItem> //: IEnumerable<TItem>
    {
        //private TItem[] array;
        //private const int DefaultSize = 2;
        //private int _first = -1;
        //private int _last = -1;
        //private int _size;

        //public ResizingArrayQueue()
        //{
        //    array = new TItem[DefaultSize];
        //    _size = 0;
        //}

        //public void Enqueue(TItem item)
        //{
        //    if (IsEmtpy())
        //        _first++;
        //    if (array.Length == _last + 1)
        //        ExpandArray();
        //    array[++_last] = item;
        //    _size++;
        //}

        //private void ExpandArray()
        //{
        //    throw new NotImplementedException();
        //}

        //public TItem Peek()
        //{
        //    if (IsEmtpy())
        //        throw new NoSuchElementException();

        //    return _first.Value;
        //}

        //public TItem Dequeue()
        //{
        //    if (IsEmtpy())
        //        throw new NoSuchElementException();

        //    var deNode = _first;
        //    var deValue = _first.Value;
        //    _first = _first.Next;
        //    deNode = null;
        //    _size--;
        //    return deValue;
        //}

        //public bool IsEmtpy()
        //{
        //    return _first == -1;
        //}

        //public int Size()
        //{
        //    return _size;
        //}

        //public IEnumerator<TItem> GetEnumerator()
        //{
        //    return new ResizingArrayQueueEnumerator<TItem>(_first);
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return this.GetEnumerator();
        //}

        //class ResizingArrayQueueEnumerator<T> : IEnumerator<T>
        //{
        //    private Node<T> _first;
        //    private Node<T> _current;

        //    public T Current => _current.Value;

        //    object IEnumerator.Current => _current.Value;

        //    public ResizingArrayQueueEnumerator(Node<T> headInQueue)
        //    {
        //        _current = new Node<T>();
        //        _current.Next = headInQueue;
        //        _first = _current;
        //    }

        //    public void Dispose()
        //    {
        //    }

        //    public bool MoveNext()
        //    {
        //        if (_current.Next == null)
        //            return false;

        //        _current = _current.Next;
        //        return true;
        //    }

        //    public void Reset()
        //    {
        //        _current = _first;
        //    }
        //}

        //class Node<TNode>
        //{
        //    public TNode Value { get; set; }
        //    public Node<TNode> Next { get; set; }
        //}
    }
}
