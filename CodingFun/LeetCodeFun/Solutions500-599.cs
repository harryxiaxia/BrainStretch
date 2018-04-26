using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeFun
{
    class Solutions500_599
    {
        //523. Continuous Subarray Sum - Submitted
        //[23, 2, 4, 6, 7],  k=6
        //reminder theorom
        //(a+n*k)%k=a;
        public bool CheckSubarraySum_523(int[] nums, int k)
        {
            var hashSet = new Dictionary<int, int>();
            hashSet.Add(0, -1);
            var sumReminder = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                sumReminder += nums[i];
                if(k != 0)
                    sumReminder %= k;
                if (hashSet.Keys.Contains(sumReminder))
                {
                    if(i - hashSet[sumReminder] > 1)
                        return true;
                }
                else hashSet.Add(sumReminder, i);
            }            
            return false;
        }

        //560. Subarray Sum Equals K - Submitted 
        public int SubarraySum_560(int[] nums, int k)
        {
            int count = 0;
            for(var i=0; i<nums.Length; i++)
            {
                int sum = 0;
                for(var j=i; j<nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum == k) count++;
                }
            }
            return count;
        }

        //560. Subarray Sum Equals K
        public int SubarraySum_Hashcode_560(int[] nums, int k)
        {
            int count = 0;
            var hashSet = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {

            }
            return count;
        }
    }
}
