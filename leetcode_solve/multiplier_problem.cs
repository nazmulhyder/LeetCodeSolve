using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_solve
{
    class multiplier_problem
    {
        public static void Main(string[] args)
        {
            int[] myNum = { 13, -4, -5, 12, 3 };
            Console.WriteLine(calculateCPUTime(myNum));
        }

        public static int calculateCPUTime(int[] arr)
        {
            int cpuCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] * arr[j] < 0)
                    {
                        cpuCount += 16;
                    }
                    if (arr[i] * arr[j] >= 0)
                    {
                        cpuCount += 1;
                    }
                }
            }

            return cpuCount;
        }
    }
}
