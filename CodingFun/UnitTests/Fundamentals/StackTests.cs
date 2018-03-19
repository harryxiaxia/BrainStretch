using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms4th.Fundamentals;
using System.Collections.Generic;

namespace UnitTests.Fundamentals
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void StackX_Positive()
        {
            var stack = new StackX<int>();

            Assert.IsTrue(stack.IsEmpty());
            stack.Push(1);
            stack.Push(3);
            stack.Push(5);
            stack.Push(7);
            stack.Push(9);
            Assert.AreEqual(5, stack.Size());
            Assert.AreEqual(9, stack.Peek());

            Assert.AreEqual(9, stack.Pop());
            Assert.AreEqual(7, stack.Pop());
            Assert.AreEqual(3, stack.Size());
            Assert.AreEqual(5, stack.Peek());

            stack.Push(66);
            var list = new List<int> { 66, 5, 3, 1 };
            int index = 0;
            foreach(var i in stack)            
                Assert.AreEqual(list[index++], i);            
        }
    }
}
