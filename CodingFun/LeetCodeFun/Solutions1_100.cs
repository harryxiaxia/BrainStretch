using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeFun
{
    public class Solutions1_100
    {
        //1.Two Sum
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums == null) throw new ArgumentException("Input is invalid");
            return null;
        }

        //2. Add two number
        public class ListNode
        {
            public int val { get; set; }
            public ListNode next { get; set; }
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return null;
        }

        //33. Search in Rotated Sorted Array
        //6 7 8 9 10 11 13 14 1 2 3 4 5
        //7 8 9 1 2 3 4 5 6 
        //[4,5,6,7,0,1,2]
        //[4,5,6,7,8,1,2,3]
        public int Search_33(int[] nums, int target)
        {
            int lo = 0;
            int hi = nums.Length - 1;
            while (lo <= hi)
            {
                int mid = (lo + hi) / 2;
                if (target == nums[mid]) return mid;
                else if (nums[lo] <= nums[mid])
                {
                    if (target > nums[mid]) lo = mid + 1;
                    else
                    {
                        if (target >= nums[lo]) hi = mid - 1;
                        else lo = mid + 1;
                    }
                }
                else
                {
                    if (target < nums[mid]) hi = mid - 1;
                    else
                    {
                        if (target <= nums[hi]) lo = mid + 1;
                        else hi = mid - 1;
                    }
                }
            }

            return -1;
        }
        //TODO:
        //153. Find Minimum in Rotated Sorted Array
        //81. Search in Rotated Sorted Array II
    }
}
