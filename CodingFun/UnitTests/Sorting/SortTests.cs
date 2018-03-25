using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms4th.Sorting;

namespace UnitTests.Sorting
{
    [TestClass]
    public class SortTests
    {
        private bool IsSorted<T>(T[] array) where T : IComparable
        {
            for (var i = 0; i < array.Length-1; i++)
                if (array[i].CompareTo(array[i + 1]) > 0)
                    return false;

            return true;
        }
        [TestMethod]
        public void QuickSortThreeWay()
        {
            var array = new int[] { 5, 6, 4, 3, 5, 7, 8, 1 };
            ISortStrategy<int> threeWayQuickSort = new QuickSortThreeWay<int>();
            threeWayQuickSort.Sort(array);

            Assert.IsTrue(IsSorted(array));
        }
    }
}
