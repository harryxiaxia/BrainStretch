using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeFun
{
    class Solutions200_300
    {
        //268. Missing Number - passed
        public int MissingNumber_sum_268(int[] nums)
        {
            var length = nums.Length;
            var sum = (length + 1) * length / 2;
            foreach (var n in nums)
                sum -= n;
            return sum;
        }

        //268. Missing Number () - passed
        //Related: 41, 136, 287, 765
        public int MissingNumber_xor_268(int[] nums)
        {
            var max = nums.Length;
            for(var i=0; i<nums.Length; i++)
            {
                max ^= i;
                max ^= nums[i];
            }
            return max;
        }
    }
}
