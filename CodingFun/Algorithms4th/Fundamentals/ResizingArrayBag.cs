using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms4th.Fundamentals
{
    //Todo: Update code to use resizing array
    public class ResizingArrayBag<Item> : IEnumerable<Item>
    {
        private const int DefaultSize = 2;

        private int _size;
        private Item[] array;

        public ResizingArrayBag()
        {
            array = new Item[2];
            _size = 0;
        }

        public void Add(Item item)
        {
            if (array.Length == _size)
                ExpandArray();

            array[_size] = item;
            _size++;
        }

        private void ExpandArray()
        {
            var newArray = new Item[array.Length * 2];
            for (var i = 0; i < array.Length; i++)
                newArray[i] = array[i];
            Item[] oldArray = array;
            array = newArray;
            oldArray = null;
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public int Size()
        {
            return _size;
        }

        public IEnumerator<Item> GetEnumerator()
        {
            for(var i=0; i<_size; i++)
            {
                yield return array[i];
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
