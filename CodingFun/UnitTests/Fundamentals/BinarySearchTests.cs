using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms4th.Fundamentals;

namespace UnitTests.Fundamentals
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void BinarySearch_Rank_Positive()
        {
            var arr1 = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.AreEqual(0, BinarySearch.Rank(1, arr1));

            var arr2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.AreEqual(8, BinarySearch.Rank(9, arr2));

            var arr3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.AreEqual(3, BinarySearch.Rank(4, arr3));

            var arr4 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.AreEqual(-1, BinarySearch.Rank(10, arr4));

            var arr5 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.AreEqual(-1, BinarySearch.Rank(0, arr5));        

            var arr6 = new int[] { };
            Assert.AreEqual(-1, BinarySearch.Rank(2, arr6));

            var arr7 = new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 };
            var rank = BinarySearch.Rank(4, arr7);
            Assert.IsTrue(rank == 5 || rank == 6);
        }
    }
}
