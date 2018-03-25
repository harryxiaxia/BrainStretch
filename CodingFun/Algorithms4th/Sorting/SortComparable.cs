using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms4th.Sorting
{
    class SortItemComparable<T> where T : IComparable
    {
        public bool Less(T t1, T t2)
        {
            return t1.CompareTo(t2) < 0;
        }
    }
}
