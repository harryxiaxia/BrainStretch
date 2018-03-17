using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms4th.Fundamentals
{
    public class BinarySearch
    {
        public static int IndexOf(int[] a, int key)
        {
            if (a == null)
                throw new ArgumentException();

            int lo = 0;
            int hi = a.Length - 1;

            while(lo <= hi)
            {
                int mid = (lo + hi) / 2;
                if (key > a[mid])
                    lo = mid + 1;
                else if (key < a[mid])
                    hi = mid - 1;
                else
                    return mid;
            }

            return -1;
        }

        public static int Rank(int key, int[] a)
        {
            return IndexOf(a, key);
        }
    }
}
