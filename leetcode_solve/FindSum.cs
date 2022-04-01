using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_solve
{
    class FindSum
    {
        public static void Main(string[] args)
        {
            int[] arr1 = new[] {1, 3, 5, 7};
            int[] arr2 = new[] {6, 7, 9, 12 };
            int desireOutput = 36;
            int[] resultArr;
            resultArr = findSum(arr1, arr2, desireOutput);
            foreach (var item in resultArr)
            {
                Console.Write(' ');
                Console.Write(item);
            }
        }

        public static int[] findSum(int[] array1, int[] array2,int findOutput)
        {
            int[] resultArray = new int[2];

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] + array2[j] == findOutput)
                    {
                        resultArray[0] = i+1;
                        resultArray[1] = j+1;
                        break;
                    }
                }
            }

            return resultArray;
        }
    }
}
