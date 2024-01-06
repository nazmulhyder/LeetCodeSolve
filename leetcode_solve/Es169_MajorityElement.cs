using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace leetcode_solve
{
    public class Es169_MajorityElement
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(majorityElement(new int[] {1,2,3,3,3}));
        }

        public static int majorityElement(int[] nums)
        {
            var distinctNum = nums.Distinct().ToArray(); 
            Dictionary<int, int> keyOccurences = new Dictionary<int, int>();
            var tmpCount = 0;
            foreach (int num in distinctNum)
            {
                tmpCount = 0;
                keyOccurences.Add(num,0);
                foreach (int x in nums)
                {
                    if(num == x) { tmpCount++;}
                }

                keyOccurences[num]= tmpCount;
            }
           

            return keyOccurences.OrderByDescending(x => x.Value).First().Key;
        }
    }
}
