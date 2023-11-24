using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode_solve
{
    public class Es88_MergeSortedArray
    {
        public static void Main(string[] args)
        {
            int[] num1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int[] num2 = new int[] { 2, 5, 6 };
            int m = 3;
            int n = 3;

            Merge(num1, m, num2, n);

        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] modifiedarray = new int[m+n];
            List<int> list = new List<int>();
            foreach (var item in nums1)
            {
                list.Add(item);
            }
            foreach (var item in nums2)
            {
                list.Add(item);
            }

            int index = 0;
            foreach (var item in list)
            {
               if(item !=0)
                {
                    modifiedarray[index] = item;
                    index++;
                }
            }
            
            for (int i = 0; i < modifiedarray.Length; i++)
            {
              int tmp = modifiedarray[i];
              for (int j = i+1; j < modifiedarray.Length; j++) 
              { 
                  if(modifiedarray[j] < modifiedarray[i])
                    {
                        tmp = modifiedarray[i];
                        modifiedarray[i] = modifiedarray[j];
                        modifiedarray[j] = tmp;
                    }
              }
            }

            Console.Write("["); int pointer = 0;
            //Console.Write(string.Join(",", modifiedarray));
            foreach (var item in modifiedarray)
            {
                Console.Write(item);
                Console.Write(pointer == modifiedarray.Length-1? "":",");
                pointer++;
            }
            Console.Write("]");
        }

        #region using buldin function
        //public static void Merge(int[] nums1, int m, int[] nums2, int n)
        //{
        //    int[] modifiedarray = new int[m + n];
        //    List<int> list = new List<int>();
        //    list.AddRange(nums1); list.AddRange(nums2);
        //    list.RemoveAll(x => x == 0);
        //    modifiedarray = list.ToArray();

        //    for (int i = 0; i < modifiedarray.Length; i++)
        //    {
        //        int tmp = modifiedarray[i];
        //        for (int j = i + 1; j < modifiedarray.Length; j++)
        //        {
        //            if (modifiedarray[j] < modifiedarray[i])
        //            {
        //                tmp = modifiedarray[i];
        //                modifiedarray[i] = modifiedarray[j];
        //                modifiedarray[j] = tmp;
        //            }
        //        }
        //    }

        //    Console.Write("[");
        //    Console.Write(string.Join(",", modifiedarray));
        //    Console.Write("]");
        //}
        #endregion
    }
}
