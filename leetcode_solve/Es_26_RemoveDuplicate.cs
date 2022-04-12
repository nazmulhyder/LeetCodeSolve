using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_solve
{
    //key points
    //you can't descrease the array len, array len sould be same
    //array sorted in non-decreasing order


    internal class Es_26_RemoveDuplicate
    {
        public static void Main(string[] args)
        {
            int[] nums = {1,1,2};
            int resultLen = RemoveDuplicates(nums);

            // {1,2,3,4} len = 3
            Console.WriteLine("Original Array Len {0}", nums.Length);
            Console.WriteLine("Result Array Len {0}", resultLen);
        }
        public static int RemoveDuplicates(int[] nums)
        {
            int index = 1;
            for (int i = 0; i < nums.Length-1; i++)
            {
                //var currentIndex = nums[i];
                //var currentIndex_next = nums[i+1];
                if (nums[i] != nums[i+1])
                {
                    nums[index] = nums[i+1];
                    index++;
                }
            }
            return index;
        }
    }
}
