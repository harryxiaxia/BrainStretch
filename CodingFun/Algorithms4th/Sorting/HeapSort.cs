using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms4th.Sorting
{
    public class HeapSort<T> : ItemComparable<T>, ISortStrategy<T> where T : IComparable
    {
        //Heap sort is really beautiful!

        //Heap construction

        //sort down
        public void Sort(T[] array)
        {
            var newArray = new T[array.Length+1];
            for (int i = 0; i < array.Length; i++)
                newArray[i + 1] = array[i];
            var n = newArray.Length;
            //Heap construction
            for(var j=n/2; j>=1; j--)
                Sink(newArray, j);

            while(n>1)
            {
                Swap(newArray, 1, n--);
                Sink(newArray, 1);
            }
        }

        private void Sink(T[] array, int d)
        {
            throw new NotImplementedException();
        }
    }
}
