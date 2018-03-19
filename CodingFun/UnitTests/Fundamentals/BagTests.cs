using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms4th.Fundamentals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Fundamentals
{
    [TestClass]
    public class BagTests
    {
        [TestMethod]
        public void Bag_Positive()
        {
            var bag = new Bag<int>();

            Assert.IsTrue(bag.IsEmpty());
            bag.Add(1);
            bag.Add(4);
            bag.Add(6);
            bag.Add(6);
            bag.Add(7);
            bag.Add(9);
            Assert.AreEqual(6, bag.Size());

            var bagList = new List<int> { 1, 4, 6, 6, 7, 9 };
            List<int> oriList = new List<int>();
            foreach (var i in bag)
                oriList.Add(i);

            Assert.IsTrue(bagList.Except(oriList).Count() == 0);
        }

        [TestMethod]
        public void ResizingArrayBag_Positive()
        {
            var bag = new ResizingArrayBag<int>();

            Assert.IsTrue(bag.IsEmpty());
            bag.Add(1);
            bag.Add(4);
            bag.Add(6);
            bag.Add(6);
            bag.Add(7);
            bag.Add(9);
            Assert.AreEqual(6, bag.Size());

            var bagList = new List<int> { 1, 4, 6, 6, 7, 9 };
            List<int> oriList = new List<int>();
            foreach (var i in bag)
                oriList.Add(i);

            Assert.IsTrue(bagList.Except(oriList).Count() == 0);
        }
    }
}
