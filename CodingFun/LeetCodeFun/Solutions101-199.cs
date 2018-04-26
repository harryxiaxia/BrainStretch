using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeFun
{
    class Solutions101_199
    {
        //190. Reverse Bits
        public uint reverseBits_190(uint n)
        {
            uint result = 0;
            for(var k=0; k<32; k++, n>>=1)
            {
                uint tmp = n & 0x01;
                tmp <<= (31 - k);
                result += tmp;
            }
            return result;
        }
    }
}
