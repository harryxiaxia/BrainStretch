using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms4th.Fundamentals;

namespace UnitTests.Fundamentals
{
    [TestClass]
    public class QueueXTests
    {
        [TestMethod]
        public void QueueX_Positive()
        {
            var queue = new QueueX<int>();

            Assert.IsTrue(queue.IsEmtpy());
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(5);
            queue.Enqueue(7);
            queue.Enqueue(9);
            queue.Enqueue(16);

            Assert.AreEqual(6, queue.Size());

            Assert.AreEqual(1, queue.Dequeue());
            Assert.AreEqual(2, queue.Dequeue());
            Assert.AreEqual(5, queue.Dequeue());
            Assert.AreEqual(7, queue.Dequeue());
            Assert.AreEqual(2, queue.Size());

            queue.Enqueue(22);
            queue.Enqueue(33);
            queue.Enqueue(44);
            var list = new List<int> { 9, 16, 22, 33, 44 };
            var index = 0;
            foreach(var i in queue)
            {
                Assert.AreEqual(i, list[index++]);
            }

            Assert.AreEqual(9, queue.Peek());
        }
    }
}
