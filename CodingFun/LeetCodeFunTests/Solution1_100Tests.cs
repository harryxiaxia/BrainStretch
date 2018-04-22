using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeFun;

namespace LeetCodeFunTests
{
    [TestClass]
    public class Solution1_100Tests
    {
        [TestMethod]
        public void RotatedSortArray_Positive_33()
        {
            var solution = new Solutions1_100();
            var arr = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            var arr1 = new int[] {4, 5, 6, 7, 8, 1, 2, 3};
            var arr2 = new int[] { 3, 1 };
            Assert.AreEqual(4, solution.Search_33(arr, 0));
            Assert.AreEqual(-1, solution.Search_33(arr, 3));
            Assert.AreEqual(4, solution.Search_33(arr1, 8));
            Assert.AreEqual(1, solution.Search_33(arr2, 1));
        }
    }
}
