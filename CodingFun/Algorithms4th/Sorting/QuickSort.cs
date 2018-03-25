using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms4th.Sorting
{
    class QuickSort<T> : ItemComparable<T>, ISortStrategy<T> where T : IComparable
    {
        public void Sort(T[] array)
        {
            QuickSortClassic(array, 0, array.Length);
        }

        private void QuickSortClassic(T[] array, int lo, int hi)
        {
            if (lo > hi)
                return;
            var p = Partition(array, lo, hi);
            QuickSortClassic(array, lo, p);
            QuickSortClassic(array, p + 1, hi);
        }

        private int Partition(T[] array, int lo, int hi)
        {
            int i = lo;
            int j = hi + 1;
            T p = array[lo];

            while(true)
            {
                while (Less(array[++i], p))
                    if (i == hi) break;

                while (Less(p, array[--j]))
                    if (j == lo) break;

                if (i >= j)
                    break;
                Swap(array, i, j);
            }
            Swap(array, lo, j);
            return j;
        }
    }
}
