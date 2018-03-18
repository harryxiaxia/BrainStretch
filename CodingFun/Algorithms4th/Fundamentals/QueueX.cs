using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms4th.Fundamentals
{
    public class QueueX<TQueue> : IEnumerable<TQueue>
    {
        public IEnumerator<TQueue> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public QueueX() { }

        public void Enqueue(TQueue item)
        {
            throw new NotImplementedException();
        }

        public TQueue Dequeue()
        {
            throw new NotImplementedException();
        }

        public bool IsEmtpy()
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            throw new NotImplementedException();
        }
    }
}
