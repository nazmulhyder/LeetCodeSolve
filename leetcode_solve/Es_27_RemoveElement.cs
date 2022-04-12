using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_solve
{
    internal class Es_27_RemoveElement
    {
        public static void Main(string[] args)
        {
            int[] nums = { 3, 2, 2, 3 };
            int resultLen = RemoveElement(nums,3);

            // {1,2,3,4} len = 3
            Console.WriteLine("Original Array Len {0}", nums.Length);
            Console.WriteLine("Result Array Len {0}", resultLen);
        }

        public static int RemoveElement(int[] nums,int val)
        {
            int index = 0;
            foreach(int num in nums)
            {
               if(num != val)
                {
                    nums[index] = num;
                    index++;
                }
            }
            return index;
        }
    }
}
