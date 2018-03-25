﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms4th.Sorting
{
    public interface ISortStrategy<T>
    {
        void Sort(T[] array);
    }
}
