using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace leetcode_solve
{
    class twoSum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the size of array?");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] inpArray = new int[n];
            Console.WriteLine("Give input of array");
            for (int i = 0; i < n; i++)
            {
                inpArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("What is the target no?");
            int targetNo = Convert.ToInt32(Console.ReadLine());
            int[] resultArray;
            resultArray = TwoSum(inpArray, targetNo);
            Console.Write("[");
            for (int i=0;i< resultArray.Length;i++)
            {
                Console.Write(resultArray[i]);
                if (i != resultArray.Length-1)
                    Console.Write(",");
            }
            Console.Write("]");
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
