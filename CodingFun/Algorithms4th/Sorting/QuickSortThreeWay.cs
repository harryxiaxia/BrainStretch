using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms4th.Sorting
{
    public class QuickSortThreeWay<T> : ItemComparable<T>, ISortStrategy<T> where T : IComparable
    {
        public void Sort(T[] array)
        {
            QuickSort(array, 0, array.Length-1);
        }

        private void QuickSort(T[] array, int lo, int hi)
        {
            if (lo > hi) return;
            int lt = lo;
            int gt = hi;
            int i = lo + 1;
            T p = array[lo];
            while(i <= gt)
            {
                int cmp = array[i].CompareTo(array[lt]);
                if      (cmp < 0) Swap(array, i++, lt++);
                else if (cmp > 0) Swap(array, i, gt--);
                else i++;
            }

            QuickSort(array, lo, lt - 1);
            QuickSort(array, gt + 1, hi);
        }

        //Actually it's too much code but maybe working.
        private PartitionRange Partition(T[] array, int lo, int hi)
        {
            var partition = new PartitionRange { Start = lo, End = lo };
            var i = lo+1;
            var j = hi;
            while(true)
            {
                if (i > j)
                    break;

                while (Less(array[i], array[partition.Start]))
                {
                    if (i > j)
                        break;
                    Swap(array, i, partition.Start);
                    i++;
                    partition.Start++;
                    partition.End++;
                }

                while (array[j].CompareTo(array[partition.End]) > 0)
                {
                    if (i > j)
                        break;
                    j--;
                }

                while(array[i].CompareTo(array[partition.Start])==0)
                {
                    if (i > j)
                        break;
                    i++;
                    partition.End++;
                }

                Swap(array, i, j); 
                if (array[i].CompareTo(array[partition.End]) == 0)
                {
                    if (i > partition.End + 1)
                        Swap(array, i, partition.End + 1);
                    partition.End++;
                }
            }

            return partition;
        }

        class PartitionRange
        {
            public int Start { get; set; }
            public int End { get; set; }
        }
    }
}
