using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms4th.Sorting
{
    class SelectionSort<T> : SortItemComparable<T>, ISortStrategy<T> where T : IComparable
    {
        public void Sort(T[] array)
        {
            throw new NotImplementedException();
        }
    }
}
